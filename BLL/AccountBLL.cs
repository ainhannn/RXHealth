﻿using DAL;
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
        public static bool updateAvatar(int id, string avatar)
        {
            try
            {
                bool rs = AccountDAO.UpdateAvatar(id, avatar);
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        public static bool updateUsername(int id, string username)
        {
            try
            {
                bool rs = AccountDAO.UpdateUsername(id, username);
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        public static string ChangePwd(int id, string oldPass, string newPass)
        {
            Account acc = AccountDAO.SelectAcc(id);
            if (acc != null)
            {
                Console.WriteLine(acc.Password);
                Console.WriteLine(oldPass);
                return acc.Password == oldPass ? (
                    AccountDAO.UpdatePassword(id, newPass) ? "Thay đổi mật khẩu thành công" : "Thay đổi mật khẩu thất bại"
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
        public static string getAvatarAccount(int id)
        {
            try
            {
                string avatar = AccountDAO.Select(id) == null ? "" : AccountDAO.Select(id).Avatar;
                return avatar != null ? avatar : "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "";
        }
    }
}
