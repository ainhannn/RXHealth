using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "Tên đăng nhập")
                if (password.Text == "Mật khẩu")
                    MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (password.Text == "Mật khẩu")
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Thực hiện xác thực và đăng nhập
                // Nếu thành công, chuyển đến giao diện chính
                // Ví dụ: MainForm mainForm = new MainForm();
                // mainForm.Show();
                // this.Close();
                // không thành công báo message lỗi
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. Bạn có muốn thử lại?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alphaBlendTextBox1_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
                username.Text = "Tên đăng nhập";
        }

        private void alphaBlendTextBox1_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Tên đăng nhập")
                username.Text = "";
        }

        private void alphaBlendTextBox2_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Mật khẩu";
                password.PasswordChar = '\0';
            }
        }

        private void alphaBlendTextBox2_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Mật khẩu")
            {
                password.Text = "";
                password.PasswordChar = '●';
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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
            this.Focus();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            AcceptButton = login;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                login.PerformClick();
            }
        }
    }
}
