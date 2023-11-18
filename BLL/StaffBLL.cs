using DAL;
using DotNetEnv;
using DTO;
using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StaffBLL
    {
        public static List<Staff> getAllStaff()
        {
            return StaffDAO.SelectAll() != null ? StaffDAO.SelectAll() : null;
        } 
        public static Staff getStaff(int id)
        {
            try
            {
                Staff staff = StaffDAO.Select(id);
                return staff != null ? staff : null;
            }catch(Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public static string getNickName(int id)
        {
            try
            {
                Staff staff = StaffDAO.Select(id);
                return staff.Nickname;
            }catch (Exception ex)
            {
                Console.WriteLine("No nickname"+ex.Message);
            }
            return "";
        }
        public static List<Staff> getStaffsOnRequest(string request, int filter, int gender)
        {
            try
            {
                return StaffDAO.SelectOnRequest(request, filter, gender);
            }catch(Exception ex)
            {   
                Console.WriteLine(ex.ToString());
            }
            return null;
        }
        
        public static bool insertStaff(Staff e, int role, string CitizenId)
        {
            try
            {
                StaffDAO.Insert(e);
                int id = StaffDAO.SelectId(CitizenId);
                try
                {
                    AccountDAO.Insert(id, role);
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }
        public static bool updateStaff(Staff e, int role)
        {
            try
            {
                StaffDAO.UpdateInformation(e);
                AccountDAO.UpdateRole(e.Id, role);
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }

        public static bool deleteStaff(int id)
        {
            return StaffDAO.Delete(id) == true;
        }

        public static string getRole(int id)
        {
            if(StaffDAO.Select(id) == null)
            {
                return "";
            }
            int role = AccountDAO.Select(id).Role;
            if (Env.GetInt("admin") == role) return "Quản lý";
            return (Env.GetInt("warehouse_manager") == role ? "Quản kho" : "Bán hàng");
        }
        public static string ChangeNickname(int id, string nickname)
        {
            Account acc = AccountDAO.Select(id);
            if (acc != null)
            {
                try
                {
                    if (StaffDAO.UpdateNickname(id, nickname))
                    {
                        return "Chỉnh sửa thành công";
                    }
                }catch(Exception ex) {
                    Console.WriteLine(ex);
                }
            }
            return "Chỉnh sửa thất bại";
        }
    }
}
