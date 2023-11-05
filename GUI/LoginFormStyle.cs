using System.Windows.Forms;
using System;
using GUI.Handle;

namespace GUI
{
    public partial class LoginForm : Form
    {
        private void login_Paint(object sender, PaintEventArgs e)
        {
            HandleGUI.PaintButton(sender);
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
            HandleGUI.ChangeBtnToggle(inputPass, btntoggle, this);
        }
    }
}
