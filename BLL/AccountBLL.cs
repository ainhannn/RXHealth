using DAL;
using DotNetEnv;
using DTO;
using GLB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBLL
    {
        private static bool Validation(Account e)
        {
            bool rsName = HandleGlobal.checkIsEnglish(e.Username) && e.Username.Length > Env.GetInt("minLength_name");
            bool rsPass = HandleGlobal.checkIsEnglish(e.Password) && e.Password.Length > Env.GetInt("minLength_pass");
            return rsName && rsPass;
        }
        public static Account Login(Account e)
        {
            return Validation(e) ? AccountDAO.Login(e) : null;
        }
        public static bool createDefautAccount(int id, string phone, string citizenId)
        {
            try
            {
                AccountDAO.UpdateAccount(id, phone, citizenId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }

        public static string ChangePwd(int id, string oldPass, string newPass)
        {
            Account acc = AccountDAO.Select(id);
            if (acc != null)
            {
                return acc.Password == oldPass ? (
                    AccountDAO.UpdatePassword(acc, newPass) ? "Thay đổi mật khẩu thành công" : "Thay đổi mật khẩu thất bại"
                    ) : "Mật khẩu hiện tại không chính xác!";
            }
            return "Tài khoản không tồn tại";
        }
        
        public static string getUsernameAccount(int id)
        {
            try
            {
                string username = AccountDAO.Select(id) == null ? "" : AccountDAO.Select(id).Username;
                return username;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }
    }
}
