using BLL;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormChangePwd : Form
    {
        int id_user;
        public static string updatePass(int id, string oldPass, string newPass, string confirmPass)
        {
            if(oldPass == "" || newPass == "" || confirmPass == "")
            {
                return "Vui lòng nhập đầy đủ thông tin!";
            }
            else
            {
                if(newPass != confirmPass)
                {
                    return "Mật khẩu xác thực không đúng!";
                }
                return AccountBLL.ChangePwd( id, oldPass, newPass);
            }
        }
        private void submit_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có xác nhận thay đổi mật khẩu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
            MessageBox.Show(updatePass(id_user, inputPass.Text, inputPass1.Text, inputPass2.Text));
        }
    }
}
