using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class AccountDAO : DBConnection
    {
        private static string dbTableName = "account";

        public static Account Login(Account e) //inp (username,pass) out (id,username,role)
        {
            string sql = string.Format("CALL login('{0}','{1}')", e.Username, e.Password);
            var table = ExecuteReader(sql);
            try
            {
                return new Account(Convert.ToInt16(table[0][0]), Convert.ToString(table[0][1]), Convert.ToInt16(table[0][2]), Convert.ToString(table[0][3]));
            } catch { return null; }
        }

        public static bool Insert(int id, int role)
        {
            string sql = string.Format(
                "INSERT INTO {0} (id,role) " + "VALUES ({1},{2})", dbTableName, id, role);
            Console.WriteLine(sql);
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool UpdateAccount(int id, string newPassword, string newUsername) //inp (username,pass,newpass) out (status)
        {
            string sql = string.Format("UPDATE {0} SET " +
                "password = '{3}', username = '{2}' WHERE id = {1}", dbTableName, id, newUsername, newPassword);
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool UpdatePassword(int id, string newPassword) //inp (username,pass,newpass) out (status)
        {
            string sql = string.Format("UPDATE {0} SET " +
                "password = '{2}' " +
                "WHERE id = {1}", dbTableName, id, newPassword);
            Console.WriteLine(sql);
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool UpdateRole(int id, int role) 
        {
            if(Select(id) == null)
            {
                return false;
            }
            string sql = string.Format("UPDATE {0} SET " +
                "role = {2} " +
                "WHERE id = {1}", dbTableName, id, role);
            Console.WriteLine(sql); 
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool UpdateAvatar(int id, string path) 
        {
            string sql = string.Format(
                "UPDATE {0} SET avatar = '{2}' WHERE id = {1}", dbTableName, id, path);
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool UpdateUsername(int id, string username)
        {
            string sql = string.Format(
                "UPDATE {0} SET username = '{2}' WHERE id = {1}", dbTableName, id, username);
            return ExecuteNonQuery(sql) > 0;
        }
        public static Account Select(int id)
        {
            string sql = string.Format("SELECT id,username,role,avatar FROM {0} WHERE id={1} LIMIT 1", dbTableName, id);
            var table = ExecuteReader(sql);
            try
            {
                return new Account(Convert.ToInt16(table[0][0]), Convert.ToString(table[0][1]), Convert.ToInt16(table[0][2]), Convert.ToString(table[0][3]));
            }
            catch { return null; }
        }

        public static Account SelectAcc(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id={1} LIMIT 1", dbTableName, id);
            Console.WriteLine(sql);
            var table = ExecuteReader(sql);
            try
            {
                return new Account(Convert.ToInt16(table[0][0]), Convert.ToString(table[0][1]), Convert.ToString(table[0][2]), Convert.ToInt16(table[0][3]),  Convert.ToString(table[0][4]));
            }
            catch { return null; }
        }

        public static bool Delete(int id)
        {
            string sql = string.Format("DELETE FROM {0} WHERE id = {1}", dbTableName, id);
            return ExecuteNonQuery(sql) > 0;
        }
        public static List<int> getIdOnRequest(string request)
        {
            string sql = string.Format("SELECT id FROM {0} WHERE username LIKE '%{1}%'", dbTableName, request);
            var table = ExecuteReader(sql);
            List<int> ids = new List<int>();    
            try
            {
                foreach(var row in table)
                {
                    ids.Add(Convert.ToInt16(row[0]));
                }
                return ids;
            }
            catch { return null; }
        }
        private static string GetDefaultPassword(Staff e)
        {
            return e.Birthday.ToString("ddMMyyyy");
        }
    }
}
