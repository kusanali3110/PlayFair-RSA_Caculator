namespace PlayFair_RSA_Caculator
{
    partial class RSA_ChildForm
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
            splitContainer2 = new SplitContainer();
            groupBox5 = new GroupBox();
            btnOpenFile = new FontAwesome.Sharp.IconButton();
            btnDecrypt = new FontAwesome.Sharp.IconButton();
            btnEncrypt = new FontAwesome.Sharp.IconButton();
            inputField = new RichTextBox();
            groupBox6 = new GroupBox();
            outputField = new RichTextBox();
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            btnOpenPriKey = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            pathFieldPriKey = new TextBox();
            groupBox3 = new GroupBox();
            btnOpenPubKey = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            pathFieldPubKey = new TextBox();
            groupBox1 = new GroupBox();
            btnSaveKeyPair = new FontAwesome.Sharp.IconButton();
            passphraseField = new TextBox();
            label1 = new Label();
            grpBoxBitLength = new GroupBox();
            radBtn2048 = new RadioButton();
            radBtn1024 = new RadioButton();
            radBtn512 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            grpBoxBitLength.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.White;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.FromArgb(23, 21, 59);
            splitContainer2.Panel1.Controls.Add(groupBox5);
            splitContainer2.Panel1MinSize = 150;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(23, 21, 59);
            splitContainer2.Panel2.Controls.Add(groupBox6);
            splitContainer2.Panel2MinSize = 150;
            splitContainer2.Size = new Size(488, 496);
            splitContainer2.SplitterDistance = 246;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox5.Controls.Add(btnOpenFile);
            groupBox5.Controls.Add(btnDecrypt);
            groupBox5.Controls.Add(btnEncrypt);
            groupBox5.Controls.Add(inputField);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.FromArgb(200, 172, 214);
            groupBox5.Location = new Point(12, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(464, 226);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Input data";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOpenFile.FlatStyle = FlatStyle.Flat;
            btnOpenFile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenFile.ForeColor = Color.FromArgb(200, 172, 214);
            btnOpenFile.IconChar = FontAwesome.Sharp.IconChar.File;
            btnOpenFile.IconColor = Color.FromArgb(200, 172, 214);
            btnOpenFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOpenFile.IconSize = 13;
            btnOpenFile.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFile.Location = new Point(6, 190);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(94, 30);
            btnOpenFile.TabIndex = 5;
            btnOpenFile.Text = "Open File...";
            btnOpenFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDecrypt.FlatStyle = FlatStyle.Flat;
            btnDecrypt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecrypt.ForeColor = Color.FromArgb(200, 172, 214);
            btnDecrypt.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            btnDecrypt.IconColor = Color.FromArgb(200, 172, 214);
            btnDecrypt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDecrypt.IconSize = 13;
            btnDecrypt.ImageAlign = ContentAlignment.MiddleLeft;
            btnDecrypt.Location = new Point(383, 190);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(75, 30);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEncrypt.FlatStyle = FlatStyle.Flat;
            btnEncrypt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncrypt.ForeColor = Color.FromArgb(200, 172, 214);
            btnEncrypt.IconChar = FontAwesome.Sharp.IconChar.Lock;
            btnEncrypt.IconColor = Color.FromArgb(200, 172, 214);
            btnEncrypt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEncrypt.IconSize = 13;
            btnEncrypt.ImageAlign = ContentAlignment.MiddleLeft;
            btnEncrypt.Location = new Point(302, 190);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(75, 30);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // inputField
            // 
            inputField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputField.BackColor = Color.FromArgb(67, 61, 139);
            inputField.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputField.ForeColor = Color.FromArgb(200, 172, 214);
            inputField.Location = new Point(6, 22);
            inputField.Name = "inputField";
            inputField.Size = new Size(452, 162);
            inputField.TabIndex = 0;
            inputField.Text = "";
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.Controls.Add(outputField);
            groupBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.ForeColor = Color.FromArgb(200, 172, 214);
            groupBox6.Location = new Point(12, 8);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(464, 226);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Output data";
            // 
            // outputField
            // 
            outputField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outputField.BackColor = Color.FromArgb(67, 61, 139);
            outputField.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputField.ForeColor = Color.FromArgb(200, 172, 214);
            outputField.Location = new Point(6, 22);
            outputField.Name = "outputField";
            outputField.Size = new Size(452, 198);
            outputField.TabIndex = 0;
            outputField.Text = "";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(23, 21, 59);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(23, 21, 59);
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2MinSize = 300;
            splitContainer1.Size = new Size(792, 496);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(200, 172, 214);
            groupBox2.Location = new Point(12, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 243);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Keypair select";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(btnOpenPriKey);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(pathFieldPriKey);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.FromArgb(200, 172, 214);
            groupBox4.Location = new Point(6, 132);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(268, 104);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Private key";
            // 
            // btnOpenPriKey
            // 
            btnOpenPriKey.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenPriKey.FlatStyle = FlatStyle.Flat;
            btnOpenPriKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenPriKey.ForeColor = Color.FromArgb(200, 172, 214);
            btnOpenPriKey.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnOpenPriKey.IconColor = Color.FromArgb(200, 172, 214);
            btnOpenPriKey.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOpenPriKey.IconSize = 13;
            btnOpenPriKey.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenPriKey.Location = new Point(187, 66);
            btnOpenPriKey.Name = "btnOpenPriKey";
            btnOpenPriKey.Size = new Size(75, 30);
            btnOpenPriKey.TabIndex = 4;
            btnOpenPriKey.Text = "Open...";
            btnOpenPriKey.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenPriKey.UseVisualStyleBackColor = true;
            btnOpenPriKey.Click += btnOpenPriKey_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 19);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "File path";
            // 
            // pathFieldPriKey
            // 
            pathFieldPriKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pathFieldPriKey.BackColor = Color.FromArgb(67, 61, 139);
            pathFieldPriKey.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pathFieldPriKey.ForeColor = Color.FromArgb(200, 172, 214);
            pathFieldPriKey.Location = new Point(10, 37);
            pathFieldPriKey.Name = "pathFieldPriKey";
            pathFieldPriKey.ReadOnly = true;
            pathFieldPriKey.Size = new Size(252, 23);
            pathFieldPriKey.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(btnOpenPubKey);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(pathFieldPubKey);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(200, 172, 214);
            groupBox3.Location = new Point(6, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(268, 104);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Public key";
            // 
            // btnOpenPubKey
            // 
            btnOpenPubKey.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenPubKey.FlatStyle = FlatStyle.Flat;
            btnOpenPubKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenPubKey.ForeColor = Color.FromArgb(200, 172, 214);
            btnOpenPubKey.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnOpenPubKey.IconColor = Color.FromArgb(200, 172, 214);
            btnOpenPubKey.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOpenPubKey.IconSize = 13;
            btnOpenPubKey.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenPubKey.Location = new Point(187, 68);
            btnOpenPubKey.Name = "btnOpenPubKey";
            btnOpenPubKey.Size = new Size(75, 30);
            btnOpenPubKey.TabIndex = 4;
            btnOpenPubKey.Text = "Open...";
            btnOpenPubKey.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenPubKey.UseVisualStyleBackColor = true;
            btnOpenPubKey.Click += btnOpenPubKey_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 21);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "File path";
            // 
            // pathFieldPubKey
            // 
            pathFieldPubKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pathFieldPubKey.BackColor = Color.FromArgb(67, 61, 139);
            pathFieldPubKey.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pathFieldPubKey.ForeColor = Color.FromArgb(200, 172, 214);
            pathFieldPubKey.Location = new Point(10, 39);
            pathFieldPubKey.Name = "pathFieldPubKey";
            pathFieldPubKey.ReadOnly = true;
            pathFieldPubKey.Size = new Size(252, 23);
            pathFieldPubKey.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnSaveKeyPair);
            groupBox1.Controls.Add(passphraseField);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(grpBoxBitLength);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(200, 172, 214);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Keypair generate";
            // 
            // btnSaveKeyPair
            // 
            btnSaveKeyPair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveKeyPair.FlatStyle = FlatStyle.Flat;
            btnSaveKeyPair.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveKeyPair.ForeColor = Color.FromArgb(200, 172, 214);
            btnSaveKeyPair.IconChar = FontAwesome.Sharp.IconChar.File;
            btnSaveKeyPair.IconColor = Color.FromArgb(200, 172, 214);
            btnSaveKeyPair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSaveKeyPair.IconSize = 13;
            btnSaveKeyPair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveKeyPair.Location = new Point(198, 124);
            btnSaveKeyPair.Name = "btnSaveKeyPair";
            btnSaveKeyPair.Size = new Size(75, 30);
            btnSaveKeyPair.TabIndex = 4;
            btnSaveKeyPair.Text = "Save";
            btnSaveKeyPair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveKeyPair.UseVisualStyleBackColor = true;
            btnSaveKeyPair.Click += btnSaveKeyPair_Click;
            // 
            // passphraseField
            // 
            passphraseField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passphraseField.BackColor = Color.FromArgb(67, 61, 139);
            passphraseField.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passphraseField.ForeColor = Color.FromArgb(200, 172, 214);
            passphraseField.Location = new Point(6, 95);
            passphraseField.Name = "passphraseField";
            passphraseField.Size = new Size(267, 23);
            passphraseField.TabIndex = 3;
            passphraseField.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "Passphrase";
            // 
            // grpBoxBitLength
            // 
            grpBoxBitLength.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxBitLength.Controls.Add(radBtn2048);
            grpBoxBitLength.Controls.Add(radBtn1024);
            grpBoxBitLength.Controls.Add(radBtn512);
            grpBoxBitLength.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxBitLength.ForeColor = Color.FromArgb(200, 172, 214);
            grpBoxBitLength.Location = new Point(6, 22);
            grpBoxBitLength.Name = "grpBoxBitLength";
            grpBoxBitLength.Size = new Size(268, 52);
            grpBoxBitLength.TabIndex = 1;
            grpBoxBitLength.TabStop = false;
            grpBoxBitLength.Text = "Bit length of RSA modulus";
            grpBoxBitLength.Resize += grpBoxBitLength_Resize;
            // 
            // radBtn2048
            // 
            radBtn2048.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radBtn2048.AutoSize = true;
            radBtn2048.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBtn2048.Location = new Point(214, 22);
            radBtn2048.Name = "radBtn2048";
            radBtn2048.Size = new Size(53, 19);
            radBtn2048.TabIndex = 0;
            radBtn2048.Text = "2048";
            radBtn2048.UseVisualStyleBackColor = true;
            // 
            // radBtn1024
            // 
            radBtn1024.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radBtn1024.AutoSize = true;
            radBtn1024.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBtn1024.Location = new Point(109, 22);
            radBtn1024.Name = "radBtn1024";
            radBtn1024.Size = new Size(51, 19);
            radBtn1024.TabIndex = 0;
            radBtn1024.Text = "1024";
            radBtn1024.UseVisualStyleBackColor = true;
            // 
            // radBtn512
            // 
            radBtn512.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radBtn512.AutoSize = true;
            radBtn512.Checked = true;
            radBtn512.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radBtn512.Location = new Point(6, 22);
            radBtn512.Name = "radBtn512";
            radBtn512.Size = new Size(44, 19);
            radBtn512.TabIndex = 0;
            radBtn512.TabStop = true;
            radBtn512.Text = "512";
            radBtn512.UseVisualStyleBackColor = true;
            // 
            // RSA_ChildForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 496);
            Controls.Add(splitContainer1);
            Name = "RSA_ChildForm";
            Text = "RSA";
            Load += RSA_ChildForm_Load;
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpBoxBitLength.ResumeLayout(false);
            grpBoxBitLength.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer2;
        private GroupBox groupBox5;
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btnOpenPriKey;
        private Label label3;
        private TextBox pathFieldPriKey;
        private GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnOpenPubKey;
        private Label label2;
        private TextBox pathFieldPubKey;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnSaveKeyPair;
        private TextBox passphraseField;
        private Label label1;
        private GroupBox grpBoxBitLength;
        private RadioButton radBtn2048;
        private RadioButton radBtn1024;
        private RadioButton radBtn512;
        private FontAwesome.Sharp.IconButton btnDecrypt;
        private FontAwesome.Sharp.IconButton btnEncrypt;
        private RichTextBox inputField;
        private GroupBox groupBox6;
        private RichTextBox outputField;
        private FontAwesome.Sharp.IconButton btnOpenFile;
    }
}