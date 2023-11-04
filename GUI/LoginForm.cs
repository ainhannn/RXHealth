using GLB;
using System;
using System.Windows.Forms;
using GUI.Handle;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            HandleGlobal.LoadEnv();
            InitializeComponent();
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            HandleGUI.ReleaseCapture();
            HandleGUI.SendMessage(this.Handle, 0x112, 0xf012, 8);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
            }
            else if (e.KeyCode == Keys.Enter)
                login.PerformClick();
        }
    }
}