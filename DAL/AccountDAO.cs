﻿using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class AccountDAO : DBConnection
    {
        private static string dbTableName = "account";

        public static Account Login(Account e) //inp (username,pass) out (id,username,role)
        {
            string sql = string.Format("CALL {0}_login('{1}','{2}')", dbTableName, e.Username, e.Password);
            var table = ExecuteReader(sql);
            try
            {
                return new Account(Convert.ToInt16(table[0][0]), Convert.ToString(table[0][1]), Convert.ToInt16(table[0][2]), Convert.ToString(table[0][3]));
            } catch { return null; }
        }
        public static bool UpdatePassword(Account current, string newPassword) //inp (username,pass,newpass) out (status)
        {
            current = Login(current);
            if (current == null) { return false; }
            string sql = string.Format("UPDATE {0} SET " +
                "password = '{2}', " +
                "WHERE id = {1}", dbTableName, current.Id, newPassword);
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool ResetPassword(Staff e)
        {
            int id = e.Account.Id;
            String defaultPassword = GetDefaultPassword(e);
            string sql = string.Format("UPDATE {0} SET " +
                "password = '{2}', " +
                "WHERE id = {1}", dbTableName, id, defaultPassword);
            return ExecuteNonQuery(sql) > 0;
        }
        public static Account Select(int id)
        {
            string sql = string.Format("SELECT id,username,role FROM {0} WHERE id={1}", dbTableName, id);
            var table = ExecuteReader(sql);
            try
            {
                return new Account(Convert.ToInt16(table[0][0]), Convert.ToString(table[0][1]), Convert.ToInt16(table[0][2]), Convert.ToString(table[0][3]));
            }
            catch { return null; }
        }
        public static bool Delete(int id)
        {
            string sql = string.Format("DELETE FROM {0} WHERE id = {1}", dbTableName, id);
            return ExecuteNonQuery(sql) > 0;
        }
        private static string GetDefaultPassword(Staff e)
        {
            return e.Birthday.ToString("ddMMyyyy");
        }
    }
}
