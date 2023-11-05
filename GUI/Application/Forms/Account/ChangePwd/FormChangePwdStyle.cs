using GUI.Handle;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormChangePwd : Form
    {
        private void login_Paint(object sender, PaintEventArgs e)
        {
            HandleGUI.PaintButton(sender);
        }

        private void inputPass_Enter(object sender, System.EventArgs e)
        {
            if (inputPass.Text == "Mật khẩu hiện tại")
            {
                inputPass.Text = "";
                inputPass.PasswordChar = '●';
            }
        }

        private void inputPass_Leave(object sender, System.EventArgs e)
        {
            if (inputPass.Text == "")
            {
                inputPass.Text = "Mật khẩu hiện tại";
                inputPass.PasswordChar = '\0';
            }
        }

        private void inputPass1_Enter(object sender, System.EventArgs e)
        {
            if (inputPass1.Text == "Mật khẩu mới")
            {
                inputPass1.Text = "";
                inputPass1.PasswordChar = '●';
            }
        }

        private void inputPass1_Leave(object sender, System.EventArgs e)
        {
            if (inputPass1.Text == "")
            {
                inputPass1.Text = "Mật khẩu mới";
                inputPass1.PasswordChar = '\0';
            }
        }

        private void inputPass2_Enter(object sender, System.EventArgs e)
        {
            if (inputPass2.Text == "Nhập lại mật khẩu mới")
            {
                inputPass2.Text = "";
                inputPass2.PasswordChar = '●';
            }
        }

        private void inputPass2_Leave(object sender, System.EventArgs e)
        {
            if (inputPass2.Text == "")
            {
                inputPass2.Text = "Nhập lại mật khẩu mới";
                inputPass2.PasswordChar = '\0';
            }
        }

        private void btntoggle_Click(object sender, System.EventArgs e)
        {
            HandleGUI.ChangeBtnToggle(inputPass, btntoggle, this);
        }

        private void btntoggle1_Click(object sender, System.EventArgs e)
        {
            HandleGUI.ChangeBtnToggle(inputPass1, btntoggle1, this);
        }

        private void btntoggle2_Click(object sender, System.EventArgs e)
        {
            HandleGUI.ChangeBtnToggle(inputPass2, btntoggle2, this);
        }
    }
}
