using BLL;
using DAL;
using DotNetEnv;
using DTO;
using GLB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
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
        //private void input_Onchange(object sender, EventArgs e)
        //{
        //    TextBox input = (TextBox)sender;
        //    string plaholder = input.Name == "inputName" ? "Tên đăng nhập" : "Mật khẩu";
        //    if (input.Text != "" && (input.Text != plaholder))
        //    {
        //        input.Text = HandleGlobal.covertEnglish(input.Text);
        //    }
        //    input.SelectionStart = input.Text.Length;
        //    input.SelectionLength = 0;
        //}

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
                if (account == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    new MainForm(account.Id, account.Role).Show();
                    Hide();
                }
            }
            inputName.Text = username;
            inputPass.Text = "Mật khẩu";
        }

        private void forgot_Click(object sender, EventArgs e)
        {
            string username = inputName.Text;
            int idAcc = AccountBLL.checkUsernameExist(username);
            if (username == "" || username == " ")
            {
                MessageBox.Show("Vui lòng điền tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(idAcc == -1){
                MessageBox.Show("Tên đăng nhập không tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (MessageBox.Show("Yêu cầu cấp lại mật khẩu mặc định?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(AccountBLL.request_reset_pass(idAcc), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
