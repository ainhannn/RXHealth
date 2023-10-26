using DotNetEnv;
using DTO;
using GLB;
using BLL;
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
            HandleGlobal.LoadEnv();
            InitializeComponent();
        }

        private string caseValidate(string username, string password)
        {
            if (username == "Tên đăng nhập" || password == "Mật khẩu" || username == "" || password == "")
            {
                return "Vui lòng nhập đầy đủ thông tin";
            }
            return HandleGlobal.checkIsEnglish(username) ?
                         (username.Length > Env.GetInt("minLenght_name") ?
                         (HandleGlobal.checkIsEnglish(password) ?
                         (password.Length > Env.GetInt("minLenght_pass") ?
                         ""
                         : "Mật khẩu tối thiểu chứa 8 ký tự")
                         : "Vui lòng kiểm tra lại Mật khẩu ( A-Z,a-z,0-9,_ )")
                         : "Tên đăng nhập tối thiểu 6 kí tự") :
                         "Vui lòng kiểm tra lại Tên đăng nhập ( A-Z,a-z,0-9,_ )";
        }

        // covert stringVN to stringEnglish
        private void input_Onchange(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            string plaholder = input.Name == "inputName" ? "Tên đăng nhập" : "Mật khẩu";
            if (input.Text != "" && (input.Text != plaholder))
            {
                input.Text = HandleGlobal.covertEnglish(input.Text);
            }
            input.SelectionStart = input.Text.Length;
            input.SelectionLength = 0;
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
            string username = inputName.Text;
            string password = inputPass.Text;
            string rs = caseValidate(username, password);
            // (1) != "" --> check input false | (2) == "" --> check input true and login
            if (rs != "")
            {
                MessageBox.Show(rs, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Account account = AccountBLL.Login(new Account(username, password));
                if(account == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xin chào " + account.Username, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new MainForm().Show();
                    this.Hide();
                }
                inputName.Text = "Tên đăng nhập";
                inputPass.Text = "Mật khẩu";
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (inputName.Text == "")
                inputName.Text = "Tên đăng nhập";
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (inputName.Text == "Tên đăng nhập")
                inputName.Text = "";
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (inputPass.Text == "")
            {
                inputPass.Text = "Mật khẩu";
                inputPass.PasswordChar = '\0';
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (inputPass.Text == "Mật khẩu")
            {
                inputPass.Text = "";
                inputPass.PasswordChar = '●';
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntoggle_Click(object sender, EventArgs e)
        {
            if (inputPass.PasswordChar == '●')
            {
                btntoggle.Image = Properties.Resources.hidden;
                inputPass.PasswordChar = '\0';
            }
            else
            {
                btntoggle.Image = Properties.Resources.view;
                inputPass.PasswordChar = '●';
            }
            inputPass.Focus();
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