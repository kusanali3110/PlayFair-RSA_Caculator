namespace PlayFair_RSA_Caculator
{
    partial class PassphraseProviderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            passphraseTextBox = new TextBox();
            confirmBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter your passpharse";
            // 
            // passphraseTextBox
            // 
            passphraseTextBox.Location = new Point(12, 27);
            passphraseTextBox.Name = "passphraseTextBox";
            passphraseTextBox.Size = new Size(210, 23);
            passphraseTextBox.TabIndex = 1;
            passphraseTextBox.UseSystemPasswordChar = true;
            passphraseTextBox.KeyDown += passphraseTextBox_KeyDown;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(12, 56);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(210, 23);
            confirmBtn.TabIndex = 2;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // PassphraseProviderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 87);
            Controls.Add(confirmBtn);
            Controls.Add(passphraseTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PassphraseProviderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passphrase Provider";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox passphraseTextBox;
        private Button confirmBtn;
    }
}