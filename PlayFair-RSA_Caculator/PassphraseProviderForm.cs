using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayFair_RSA_Caculator
{
    public partial class PassphraseProviderForm : Form
    {
        public String passphrase;
        public PassphraseProviderForm()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            passphrase = passphraseTextBox.Text;
            if (passphrase.Length == 0)
            {
                MessageBox.Show("Passphrase must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK; // Gán trạng thái OK
            this.Close();
        }

        private void passphraseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Ngăn chặn xử lý mặc định
                e.SuppressKeyPress = true; // Ngăn không cho TextBox phát ra âm thanh
                confirmBtn_Click(sender, e);
            }
        }
    }
}
