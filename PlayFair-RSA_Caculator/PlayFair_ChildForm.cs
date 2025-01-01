using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PlayFair_RSA_Caculator
{
    public partial class PlayFair_ChildForm : Form
    {
        private TextBox[,] matrixArray = new TextBox[6, 6];
        public PlayFair_ChildForm()
        {
            InitializeComponent();

            findAllMatrixElements();
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

        private void keyField_TextChanged(object sender, EventArgs e)
        {
            if (is5x5())
            {
                TextBox textBox = sender as TextBox;

                // Check and eliminate characters which are not letters
                string filteredText = new string(textBox.Text.Where(c => char.IsAsciiLetter(c)).ToArray());

                // If there is any change (invalid chars are eliminated), update KeyField content
                if (textBox.Text != filteredText)
                {
                    int cursorPosition = textBox.SelectionStart - (textBox.Text.Length - filteredText.Length);
                    textBox.Text = filteredText;
                    textBox.SelectionStart = Math.Max(cursorPosition, 0);
                }

                generate5x5Matrix(textBox.Text);

            }
            else if (is6x6())
            {
                TextBox textBox = sender as TextBox;

                // Check and eliminate characters which are not letters and numbers
                string filteredText = new string(textBox.Text.Where(c => char.IsAsciiLetterOrDigit(c)).ToArray());

                // If there is any change (invalid chars are eliminated), update KeyField content
                if (textBox.Text != filteredText)
                {
                    int cursorPosition = textBox.SelectionStart - (textBox.Text.Length - filteredText.Length);
                    textBox.Text = filteredText;
                    textBox.SelectionStart = Math.Max(cursorPosition, 0);
                }

                generate6x6Matrix(textBox.Text);
            }
        }

        private void radBtn5x5_CheckedChanged(object sender, EventArgs e)
        {
            clearMatrix6thRowAndColumn();
            string key = keyField.Text;
            generate5x5Matrix(key);
        }

        private void radBtn6x6_CheckedChanged(object sender, EventArgs e)
        {
            string key = keyField.Text;
            generate6x6Matrix(key);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            playfairEncrypt();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            playfairDecrypt();
        }

        // Methods
        private bool is5x5()
        {
            return radBtn5x5.Checked;
        }

        private bool is6x6()
        {
            return radBtn6x6.Checked;
        }

        private TextBox FindControlRecursive(Control parent, string controlName)
        {
            foreach (Control control in parent.Controls)
            {
                // Check if control name matches
                if (control.Name == controlName && control is TextBox)
                    return (TextBox)control;

                // Keep searching in child controls
                TextBox foundControl = FindControlRecursive(control, controlName);
                if (foundControl != null)
                    return foundControl;
            }
            return null; // Not found
        }


        private void findAllMatrixElements()
        {
            int index = 1;
            // Find all elements in matrix array and asign them to matrixArray
            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    string controlName = "A" + index.ToString();
                    matrixArray[i, j] = FindControlRecursive(splitContainer1.Panel1, controlName);
                    index++;
                }
            }
            return;
        }

        private void generate5x5Matrix(string key)
        {
            key = new string(key.ToUpper().Where(c => char.IsLetter(c)).Distinct().ToArray());
            key = key.Replace("J", "I");
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            key += new string(alphabet.Where(c => !key.Contains(c)).ToArray());
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrixArray[i, j].Text = key[index].ToString();
                    index++;
                }
            }
        }

        private void generate6x6Matrix(string key)
        {
            clearMatrix6thRowAndColumn();
            key = new string(key.ToUpper().Where(c => char.IsLetterOrDigit(c)).Distinct().ToArray());
            key = key.Replace("J", "I");
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            key += new string(alphabet.Where(c => !key.Contains(c)).ToArray());
            int index = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (index < key.Length)
                    {
                        matrixArray[i, j].Text = key[index].ToString();
                        index++;
                    }
                }
            }
        }

        private void clearMatrix6thRowAndColumn()
        {
            for (int i = 0; i < 6; i++)
            {
                matrixArray[i, 5].Clear();
                matrixArray[5, i].Clear();
            }
        }

        private void playfairEncrypt()
        {
            String inputText = inputField.Text;

            // Standardize inputText
            inputText = new string(inputText.Where(char.IsAsciiLetterOrDigit).ToArray());
            inputText = inputText.ToUpper();
            if (is5x5())
            {
                inputText = inputText.Replace("J", "I");
                inputText = new string(inputText.Where(char.IsAsciiLetter).ToArray());
            }
            inputText = new string(inputText.Where(c => inputText.Contains(c)).ToArray());
            int size = is6x6() ? 6 : 5;

            // Add padding
            StringBuilder normalizedText = new StringBuilder();
            for (int i = 0; i < inputText.Length; i += 2)
            {
                char a = inputText[i];
                char b = (i + 1 < inputText.Length) ? inputText[i + 1] : 'X';
                if (a == b)
                {
                    normalizedText.Append(a).Append('X');
                    i--;
                }
                else
                {
                    normalizedText.Append(a).Append(b);
                }
            }

            // Encrypt
            StringBuilder ciphertext = new StringBuilder();
            for (int i = 0; i < normalizedText.Length; i += 2)
            {
                (int x1, int y1) = FindPosition(normalizedText[i], size);
                (int x2, int y2) = FindPosition(normalizedText[i + 1], size);

                if (x1 == x2) // Same row
                {
                    ciphertext.Append(matrixArray[x1, (y1 + 1) % size].Text).Append(matrixArray[x2, (y2 + 1) % size].Text);
                }
                else if (y1 == y2) // Same column
                {
                    ciphertext.Append(matrixArray[(x1 + 1) % size, y1].Text).Append(matrixArray[(x2 + 1) % size, y2].Text);
                }
                else // Rectangle
                {
                    ciphertext.Append(matrixArray[x1, y2].Text).Append(matrixArray[x2, y1].Text);
                }
            }

            // Fill the outputField
            outputField.Clear();
            outputField.AppendText(ciphertext.ToString());
        }

        private (int, int) FindPosition(char c, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrixArray[i, j].Text.Equals(c.ToString()))
                        return (i, j);
                }
            }
            throw new ArgumentException("Character not found in matrix: " + c);
        }

        private void playfairDecrypt()
        {
            string inputText = inputField.Text;

            // Standardize inputText
            inputText = new string(inputText.Where(char.IsAsciiLetterOrDigit).ToArray());
            inputText = inputText.ToUpper();
            if (is5x5())
            {
                inputText = inputText.Replace("J", "I");
                inputText = new string(inputText.Where(char.IsAsciiLetter).ToArray());
            }
            int size = is6x6() ? 6 : 5;

            // Decrypt
            StringBuilder plaintext = new StringBuilder();
            for (int i = 0; i < inputText.Length; i += 2)
            {
                (int x1, int y1) = FindPosition(inputText[i], size);
                (int x2, int y2) = FindPosition(inputText[i + 1], size);

                if (x1 == x2) // Same row
                {
                    plaintext.Append(matrixArray[x1, (y1 - 1 + size) % size].Text).Append(matrixArray[x2, (y2 - 1 + size) % size].Text);
                }
                else if (y1 == y2) // Same column
                {
                    plaintext.Append(matrixArray[(x1 - 1 + size) % size, y1].Text).Append(matrixArray[(x2 - 1 + size) % size, y2].Text);
                }
                else // Rectangle
                {
                    plaintext.Append(matrixArray[x1, y2].Text).Append(matrixArray[x2, y1].Text);
                }
            }

            // Remove padding character 'X' if necessary
            if (plaintext.Length > 1)
            {
                for (int i = 1; i < plaintext.Length - 1; i++)
                {
                    if (plaintext[i] == 'X' && plaintext[i - 1] == plaintext[i + 1])
                    {
                        plaintext.Remove(i, 1);
                    }
                }
                if (plaintext[plaintext.Length - 1] == 'X') plaintext.Remove(plaintext.Length - 1, 1);
            }

            // Fill the outputField
            outputField.Clear();
            outputField.AppendText(plaintext.ToString());
        }

    }
}
