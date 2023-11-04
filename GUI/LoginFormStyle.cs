using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace GUI
{
    public partial class LoginForm : Form
    {
        private void login_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 75;

            Button button = (Button)sender;
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle rect = button.ClientRectangle;

            buttonPath.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90);
            buttonPath.AddArc(rect.Right - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90);
            buttonPath.AddArc(rect.Right - borderRadius, rect.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
            buttonPath.AddArc(rect.X, rect.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
            buttonPath.CloseAllFigures();

            button.Region = new Region(buttonPath);
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
    }
}
