using BLL;
using GLB;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormChangePwdHandle : Form
    {
        public static string updatePass(int id, string oldPass, string newPass, string confirmPass)
        {
            if(oldPass == "" || newPass == "" || confirmPass == "")
            {
                return "Vui lòng nhập đầy đủ thông tin!";
            }
            if(HandleGlobal.checkIsEnglish(oldPass) == false|| HandleGlobal.checkIsEnglish(oldPass) == false)
            {
                return "Vui lòng kiểm tra lại Mật khẩu ( A-Z,a-z,0-9,_ )";
            }
            if(oldPass.Length < 8 || newPass.Length < 8)
            {
                return "Mật khẩu tối thiểu chứa 8 ký tự";
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
            {
                MessageBox.Show(updatePass(idUser, inputPass.Text, inputPass1.Text, inputPass2.Text));

            }
            Close();
        }
    }
}
