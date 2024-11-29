namespace PlayFair_RSA_Caculator
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            panelMenu = new Panel();
            btnRSA = new FontAwesome.Sharp.IconButton();
            btnPlayFair = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelActionBar = new Panel();
            btnResize = new FontAwesome.Sharp.IconButton();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            panelChildFormContainer = new Panel();
            panelShadowTop = new Panel();
            panelShadowLeft = new Panel();
            panelShadowBottom = new Panel();
            panelShadowRight = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelActionBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(23, 21, 59);
            panelMenu.Controls.Add(btnRSA);
            panelMenu.Controls.Add(btnPlayFair);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 537);
            panelMenu.TabIndex = 0;
            // 
            // btnRSA
            // 
            btnRSA.Dock = DockStyle.Top;
            btnRSA.FlatAppearance.BorderColor = Color.FromArgb(67, 61, 139);
            btnRSA.FlatAppearance.BorderSize = 0;
            btnRSA.FlatStyle = FlatStyle.Flat;
            btnRSA.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRSA.ForeColor = Color.FromArgb(200, 172, 214);
            btnRSA.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnRSA.IconColor = Color.FromArgb(200, 172, 214);
            btnRSA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRSA.ImageAlign = ContentAlignment.MiddleLeft;
            btnRSA.Location = new Point(0, 230);
            btnRSA.Name = "btnRSA";
            btnRSA.Padding = new Padding(10, 0, 10, 0);
            btnRSA.Size = new Size(200, 80);
            btnRSA.TabIndex = 2;
            btnRSA.Text = "RSA";
            btnRSA.TextAlign = ContentAlignment.MiddleLeft;
            btnRSA.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRSA.UseVisualStyleBackColor = true;
            btnRSA.Click += btnRSA_Click;
            // 
            // btnPlayFair
            // 
            btnPlayFair.Dock = DockStyle.Top;
            btnPlayFair.FlatAppearance.BorderColor = Color.FromArgb(67, 61, 139);
            btnPlayFair.FlatAppearance.BorderSize = 0;
            btnPlayFair.FlatStyle = FlatStyle.Flat;
            btnPlayFair.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPlayFair.ForeColor = Color.FromArgb(200, 172, 214);
            btnPlayFair.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnPlayFair.IconColor = Color.FromArgb(200, 172, 214);
            btnPlayFair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPlayFair.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlayFair.Location = new Point(0, 150);
            btnPlayFair.Name = "btnPlayFair";
            btnPlayFair.Padding = new Padding(10, 0, 10, 0);
            btnPlayFair.Size = new Size(200, 80);
            btnPlayFair.TabIndex = 1;
            btnPlayFair.Text = "PlayFair";
            btnPlayFair.TextAlign = ContentAlignment.MiddleLeft;
            btnPlayFair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPlayFair.UseVisualStyleBackColor = true;
            btnPlayFair.Click += btnPlayFair_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(label2);
            panelLogo.Controls.Add(label1);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 150);
            panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(200, 172, 214);
            label2.Location = new Point(10, 98);
            label2.Name = "label2";
            label2.Size = new Size(174, 21);
            label2.TabIndex = 2;
            label2.Text = "Quốc Hưng - 22520101";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(200, 172, 214);
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(171, 21);
            label1.TabIndex = 1;
            label1.Text = "Minh Hiếu - 22520438";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoUIT;
            pictureBox1.Location = new Point(69, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelActionBar
            // 
            panelActionBar.BackColor = Color.FromArgb(23, 21, 59);
            panelActionBar.Controls.Add(btnResize);
            panelActionBar.Controls.Add(btnMinimize);
            panelActionBar.Controls.Add(btnClose);
            panelActionBar.Dock = DockStyle.Top;
            panelActionBar.Location = new Point(200, 0);
            panelActionBar.Name = "panelActionBar";
            panelActionBar.Size = new Size(808, 30);
            panelActionBar.TabIndex = 1;
            panelActionBar.MouseDown += panelTitle_MouseDown;
            // 
            // btnResize
            // 
            btnResize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResize.FlatAppearance.BorderSize = 0;
            btnResize.FlatStyle = FlatStyle.Flat;
            btnResize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnResize.IconColor = Color.White;
            btnResize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResize.IconSize = 25;
            btnResize.Location = new Point(749, 2);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(25, 25);
            btnResize.TabIndex = 6;
            btnResize.UseVisualStyleBackColor = true;
            btnResize.Click += btnResize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.White;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnMinimize.IconSize = 25;
            btnMinimize.Location = new Point(718, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
            btnMinimize.TabIndex = 5;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnHide_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnClose.IconColor = Color.Red;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnClose.IconSize = 25;
            btnClose.Location = new Point(780, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panelChildFormContainer
            // 
            panelChildFormContainer.Dock = DockStyle.Fill;
            panelChildFormContainer.Location = new Point(200, 30);
            panelChildFormContainer.Name = "panelChildFormContainer";
            panelChildFormContainer.Size = new Size(808, 507);
            panelChildFormContainer.TabIndex = 2;
            // 
            // panelShadowTop
            // 
            panelShadowTop.BackColor = Color.FromArgb(27, 26, 85);
            panelShadowTop.Dock = DockStyle.Top;
            panelShadowTop.Location = new Point(200, 30);
            panelShadowTop.Name = "panelShadowTop";
            panelShadowTop.Size = new Size(808, 5);
            panelShadowTop.TabIndex = 3;
            // 
            // panelShadowLeft
            // 
            panelShadowLeft.BackColor = Color.FromArgb(27, 26, 85);
            panelShadowLeft.Dock = DockStyle.Left;
            panelShadowLeft.Location = new Point(200, 35);
            panelShadowLeft.Name = "panelShadowLeft";
            panelShadowLeft.Size = new Size(5, 502);
            panelShadowLeft.TabIndex = 4;
            // 
            // panelShadowBottom
            // 
            panelShadowBottom.BackColor = Color.FromArgb(27, 26, 85);
            panelShadowBottom.Dock = DockStyle.Bottom;
            panelShadowBottom.Location = new Point(205, 532);
            panelShadowBottom.Name = "panelShadowBottom";
            panelShadowBottom.Size = new Size(803, 5);
            panelShadowBottom.TabIndex = 5;
            // 
            // panelShadowRight
            // 
            panelShadowRight.BackColor = Color.FromArgb(27, 26, 85);
            panelShadowRight.Dock = DockStyle.Right;
            panelShadowRight.Location = new Point(1003, 35);
            panelShadowRight.Name = "panelShadowRight";
            panelShadowRight.Size = new Size(5, 497);
            panelShadowRight.TabIndex = 6;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 537);
            Controls.Add(panelShadowRight);
            Controls.Add(panelShadowBottom);
            Controls.Add(panelShadowLeft);
            Controls.Add(panelShadowTop);
            Controls.Add(panelChildFormContainer);
            Controls.Add(panelActionBar);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlayFair/RSA Caculator";
            Load += MainScreen_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelActionBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnRSA;
        private FontAwesome.Sharp.IconButton btnPlayFair;
        private Panel panelActionBar;
        private FontAwesome.Sharp.IconButton iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnResize;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panelChildFormContainer;
        private Panel panelShadowTop;
        private Panel panelShadowLeft;
        private Panel panelShadowBottom;
        private Panel panelShadowRight;
    }
}
