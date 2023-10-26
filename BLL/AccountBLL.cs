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
            bool rsName = HandleGlobal.checkIsEnglish(e.Username) && e.Username.Length > Env.GetInt("minLength_name") ? true : false;
            bool rsPass = HandleGlobal.checkIsEnglish(e.Password) && e.Password.Length > Env.GetInt("minLength_pass") ? true : false;
            return rsName && rsPass ? true : false;
        }
        public static Account Login(Account e)
        {
            return Validation(e) ? AccountDAO.Login(e) : null;
        }
    }
}
