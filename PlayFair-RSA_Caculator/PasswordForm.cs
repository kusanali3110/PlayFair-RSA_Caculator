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
    public partial class PasswordForm : Form
    {
        private TextBox passwordBox ;
        private Button okButton;
        private Button cancelButton;
        public string password => passwordBox.Text;
        public PasswordForm()
        {
            InitializeComponent();

            passwordBox = textBox1;
            okButton = button1;
            cancelButton = button2;
            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }
    }
}
