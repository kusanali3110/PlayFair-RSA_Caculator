using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace PlayFair_RSA_Caculator
{
    public partial class MainScreen : Form
    {
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        // Constructor
        public MainScreen()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 80);
            panelMenu.Controls.Add(leftBorderBtn);

            // Remove title bar
            this.ControlBox = false;
            this.Text = null;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Actions when opening the form
        private void MainScreen_Load(object sender, EventArgs e)
        {
            btnPlayFair.PerformClick();
        }

        // Methods
        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.FlatAppearance.BorderSize = 1;
                currentBtn.ForeColor = Color.FromArgb(67, 61, 139);
                currentBtn.IconColor = Color.FromArgb(67, 61, 139);

                // Left border button
                leftBorderBtn.BackColor = Color.FromArgb(67, 61, 139);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.FlatAppearance.BorderSize = 0;
                currentBtn.ForeColor = Color.FromArgb(200, 172, 214);
                currentBtn.IconColor = Color.FromArgb(200, 172, 214);
            }
        }

        private void btnPlayFair_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new PlayFair_ChildForm());
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new RSA_ChildForm());
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            // Child Form settings
            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;

            // Add to panel
            panelChildFormContainer.Controls.Add(childForm);
            panelChildFormContainer.Tag = childForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }

        #region FormUtilities
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        // Minimize
        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Maximize/Resize
        private bool isMaximized = false;
        private Rectangle previousBounds;
        private void btnResize_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                // Save previous sate of window
                previousBounds = this.Bounds;

                // Maximize window
                this.WindowState = FormWindowState.Maximized;

                // Change to resize icon
                btnResize.IconChar = IconChar.WindowRestore;

                isMaximized = true;
            }
            else
            {
                // Return to previous size
                this.WindowState = FormWindowState.Normal;
                this.Bounds = previousBounds;

                // Change to maximize icon
                btnResize.IconChar = IconChar.WindowMaximize;

                isMaximized = false;
            }
        }
        #endregion

        
    }


}
