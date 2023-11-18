using BLL;
using DAL;
using DotNetEnv;
using DTO;
using GLB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public static string username;
        public static int role;

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
<<<<<<< HEAD
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
                    if(account.Role == Env.GetInt("admin"))
                    {
                        new MainForm(account.Id).Show();
=======
            //string username = inputName.Text;
            //string password = inputPass.Text;
            //string rs = caseValidate(username, password);
            //// (1) != "" --> check input false | (2) == "" --> check input true and login
            //if (rs != "")
            //{
            //    MessageBox.Show(rs, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    Account account = AccountBLL.Login(new Account(username, password));
            //    if (account == null)
            //    {
            //        MessageBox.Show("Tài khoản không tồn tại ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        if(account.Role == Env.GetInt("admin"))
            //        {
                        new MainForm().Show();
>>>>>>> 1d424a06ecc3ed27a38f79de1507bc59ea61e832
                        Hide();
            //        }
            //    }
            //    inputName.Text = "Tên đăng nhập";
            //    inputPass.Text = "Mật khẩu";
            //}
        }
    }
}
