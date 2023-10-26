using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 8);
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text == "Tên đăng nhập")
            {
                if (password.Text == "Mật khẩu")
                    MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password.Text == "Mật khẩu")
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Thực hiện xác thực và đăng nhập
                // Nếu thành công, chuyển đến giao diện chính
                new MainForm().Show();
                this.Hide();
                // không thành công báo message lỗi
                // MessageBox.Show("Sai tài khoản hoặc mật khẩu. Bạn có muốn thử lại?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
                username.Text = "Tên đăng nhập";
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Tên đăng nhập")
                username.Text = "";
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Mật khẩu";
                password.PasswordChar = '\0';
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Mật khẩu")
            {
                password.Text = "";
                password.PasswordChar = '●';
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntoggle_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '●')
            {
                btntoggle.Image = Properties.Resources.hidden;
                password.PasswordChar = '\0';
            }
            else
            {
                btntoggle.Image = Properties.Resources.view;
                password.PasswordChar = '●';
            }
            password.Focus();
            Focus();
        }

        private void login_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 75;

            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle rect = button.ClientRectangle;

            buttonPath.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90);
            buttonPath.AddArc(rect.Right - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90);
            buttonPath.AddArc(rect.Right - borderRadius, rect.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
            buttonPath.AddArc(rect.X, rect.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
            buttonPath.CloseAllFigures();

            button.Region = new Region(buttonPath);
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