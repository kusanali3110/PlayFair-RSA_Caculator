using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;

namespace PlayFair_RSA_Caculator
{
    public partial class RSA_ChildForm : Form
    {
        private RsaKeyParameters _publicKey;
        private RsaKeyParameters _privateKey;
        public RSA_ChildForm()
        {
            InitializeComponent();
        }

        private void RSA_ChildForm_Load(object sender, EventArgs e)
        {
            grpBoxBitLength_Resize(sender, e);
        }

        private void grpBoxBitLength_Resize(object sender, EventArgs e)
        {
            int grpBox_Width = grpBoxBitLength.Width;

            radBtn512.Location = new Point(10, radBtn512.Location.Y);
            radBtn2048.Location = new Point(grpBox_Width - radBtn2048.Width - 10, radBtn2048.Location.Y);
            int radBtn1024_X = (grpBox_Width - radBtn512.Width - radBtn1024.Width - radBtn2048.Width - 20) / 2 + radBtn512.Width + 10;
            radBtn1024.Location = new Point(radBtn1024_X, radBtn1024.Location.Y);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            grpBoxBitLength_Resize(sender, e);
        }

        private void btnSaveKeyPair_Click(object sender, EventArgs e)
        {
            GenerateAndSaveKeyPair();
        }

        private void btnOpenPubKey_Click(object sender, EventArgs e)
        {
            ReadPublicKeyFile();
        }

        private void btnOpenPriKey_Click(object sender, EventArgs e)
        {
            ReadPrivateKeyFile();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // Open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*", // Only allow .txt file
                Title = "Open Text File"
            };

            // If any file is chosen
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read file content
                    string fileContent = File.ReadAllText(openFileDialog.FileName);

                    // Fill in the input field
                    inputField.Clear();
                    inputField.Text = fileContent;
                }
                catch (Exception ex)
                {
                    // Show error if any
                    MessageBox.Show("An error has been found: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Encrypt();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Decrypt();
        }

        private bool is512()
        {
            return radBtn512.Checked;
        }

        private bool is1024()
        {
            return radBtn1024.Checked;
        }

        private bool is2048()
        {
            return radBtn2048.Checked;
        }

        // Methods
        private void GenerateAndSaveKeyPair()
        {
            // Passpharse
            string passphrase = passphraseField.Text;

            if (string.IsNullOrEmpty(passphrase))
            {
                MessageBox.Show("Passphrase cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Bit length
            int bitLength;
            if (is512()) bitLength = 512;
            else if (is1024()) bitLength = 1024;
            else bitLength = 2048;

            // Generate key
            var rsaKeyPair = GenerateRsaKeyPair(bitLength);

            // Public key
            string publicKey = ExportPublicKey(rsaKeyPair.Public);

            // Private key (encrypt with passphrase)
            string privateKey = ExportPrivateKeyWithPassphrase(rsaKeyPair.Private, passphrase);

            // Open saveFileDialog to save public key
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Public Key (*.pub)|*.pub|All files (*.*)|*.*",
                Title = "Save Public Key"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Save
                    File.WriteAllText(saveFileDialog.FileName, publicKey);

                    // Save private key with a similar name to public key without .pub
                    string privateKeyPath = Path.Combine(
                        Path.GetDirectoryName(saveFileDialog.FileName),
                        Path.GetFileNameWithoutExtension(saveFileDialog.FileName)
                    );

                    File.WriteAllText(privateKeyPath, privateKey);

                    MessageBox.Show("Keys saved successfully! Private key was saved in the same directory", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    passphraseField.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving keys: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Generate RSA keypair
        private AsymmetricCipherKeyPair GenerateRsaKeyPair(int keySize)
        {
            var keyGen = new RsaKeyPairGenerator();
            keyGen.Init(new KeyGenerationParameters(new SecureRandom(), keySize));
            return keyGen.GenerateKeyPair();
        }

        // Export public key
        private string ExportPublicKey(AsymmetricKeyParameter publicKey)
        {
            using (var stringWriter = new StringWriter())
            {
                var pemWriter = new PemWriter(stringWriter);
                pemWriter.WriteObject(publicKey);
                return stringWriter.ToString();
            }
        }

        // Export private key with passphrase
        private string ExportPrivateKeyWithPassphrase(AsymmetricKeyParameter privateKey, string passphrase)
        {
            using (var stringWriter = new StringWriter())
            {
                // Create object to encrypt private key with bcrypt KDF (OpenSSH standard)
                var encryptor = new Pkcs8Generator(privateKey,
                    Pkcs8Generator.PbeSha1_3DES)
                {
                    Password = passphrase.ToCharArray()
                };

                var encryptedObject = encryptor.Generate();

                // Write in PEM format
                var pemWriter = new PemWriter(stringWriter);
                pemWriter.WriteObject(encryptedObject);
                var pemContent = stringWriter.ToString();

                return pemContent;
            }
        }

        // Read public key file
        private void ReadPublicKeyFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Public Key (*.pub)|*.pub|All files (*.*)|*.*",
                Title = "Open Public Key"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                // Read public key
                try
                {
                    string keyContent = File.ReadAllText(filePath);
                    using (var reader = new StringReader(keyContent))
                    {
                        var pemReader = new PemReader(reader);
                        var publicKey = pemReader.ReadObject() as RsaKeyParameters;
                        if (publicKey != null)
                        {
                            _publicKey = publicKey;
                            pathFieldPubKey.Clear();
                            pathFieldPubKey.AppendText(filePath);
                        }
                        else
                        {
                            MessageBox.Show("Invalid public key file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading public key: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReadPrivateKeyFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "All files (*.*)|*.*",
                Title = "Open private Key"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    string keyContent = File.ReadAllText(filePath);
                    // Read passphrase
                    String passphrase;
                    PassphraseProviderForm passphraseProviderForm = new PassphraseProviderForm();
                    if (passphraseProviderForm.ShowDialog() == DialogResult.OK)
                    {
                        passphrase = passphraseProviderForm.passphrase;
                    }
                    else
                    {
                        return;
                    }

                    // Read private key
                    using (var reader = new StringReader(keyContent))
                    {
                        var pemReader = new PemReader(reader, new PasswordFinder(passphrase));
                        var keyPair = pemReader.ReadObject() as RsaKeyParameters;
                        if (keyPair != null)
                        {
                            _privateKey = keyPair;
                            pathFieldPriKey.Clear();
                            pathFieldPriKey.AppendText(filePath);
                        }
                        else
                        {
                            MessageBox.Show("Invalid private key file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading key file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Add this class to handle the passphrase
        public class PasswordFinder : IPasswordFinder
        {
            private readonly string _password;
            public PasswordFinder(string password)
            {
                _password = password;
            }
            public char[] GetPassword()
            {
                return _password.ToCharArray();
            }
        }

        private void Encrypt()
        {
            if (!IsKeyPairMatch())
            {
                MessageBox.Show("The selected key pair does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_publicKey == null)
            {
                MessageBox.Show("Public key is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_privateKey == null)
            {
                MessageBox.Show("Private key is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(inputField.Text))
            {
                MessageBox.Show("Input field is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get string from input field
                string inputText = inputField.Text;
                byte[] inputBytes = Encoding.UTF8.GetBytes(inputText);

                // Encrypt with public key
                var encryptEngine = new Pkcs1Encoding(new RsaEngine());
                encryptEngine.Init(true, _publicKey);
                byte[] encryptedBytes = encryptEngine.ProcessBlock(inputBytes, 0, inputBytes.Length);

                // Convert encrypted bytes to base64 string
                string encryptedText = Convert.ToBase64String(encryptedBytes);

                // Return result to output field
                outputField.Clear();
                outputField.Text = encryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Decrypt()
        {
            if (!IsKeyPairMatch())
            {
                MessageBox.Show("The selected key pair does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_publicKey == null)
            {
                MessageBox.Show("Public key is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_privateKey == null)
            {
                MessageBox.Show("Private key is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(inputField.Text))
            {
                MessageBox.Show("Input field is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get encrypted string from input field
                string encryptedText = inputField.Text;
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

                // Decrypt with private key
                var decryptEngine = new Pkcs1Encoding(new RsaEngine());
                decryptEngine.Init(false, _privateKey);
                byte[] decryptedBytes = decryptEngine.ProcessBlock(encryptedBytes, 0, encryptedBytes.Length);

                // Convert decrypted bytes to string
                string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                // Return result to output field
                outputField.Clear();
                outputField.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsKeyPairMatch()
        {
            if (_publicKey == null || _privateKey == null)
            {
                return false;
            }

            // Generate a test message
            byte[] testMessage = Encoding.UTF8.GetBytes("Test message");

            // Encrypt the message with the public key
            var encryptEngine = new Pkcs1Encoding(new RsaEngine());
            encryptEngine.Init(true, _publicKey);
            byte[] encryptedMessage = encryptEngine.ProcessBlock(testMessage, 0, testMessage.Length);

            // Decrypt the message with the private key
            var decryptEngine = new Pkcs1Encoding(new RsaEngine());
            decryptEngine.Init(false, _privateKey);
            byte[] decryptedMessage = decryptEngine.ProcessBlock(encryptedMessage, 0, encryptedMessage.Length);

            // Compare the original message with the decrypted message
            return testMessage.SequenceEqual(decryptedMessage);
        }
    }
}
