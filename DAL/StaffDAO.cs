using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class StaffDAO : DBConnection
    {
        private static string dbTableName = "staff";

        private static Staff ConvertToDTO(List<object> row)
        {
            try
            {
                Staff staff = new Staff(Convert.ToInt16(row[0]), Convert.ToString(row[1])) // id, nickname
                {
                    CitizenId = Convert.ToString(row[2]),
                    FullName = Convert.ToString(row[3]),
                    Birthday = Convert.ToDateTime(row[4]),
                    GenderIsMale = Convert.ToBoolean(row[5]),
                    Qualification = Convert.ToString(row[6]),
                    ContactNumber = Convert.ToString(row[7]),
                    Address = Convert.ToString(row[8]),
                    Account = row[9] != null ? AccountDAO.Select(Convert.ToInt16(row[9])) : null,
                    StartDate = Convert.ToDateTime(row[10]),
                    ResignationDate = row[11] != null ? Convert.ToDateTime(row[11]) : DateTime.MaxValue
                };
                return staff;
            }
            catch { return null; }
        }
        public static List<Staff> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<Staff>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }
        public static List<Staff> SelectAll(bool isWorking)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE resignation_date {1} NULL", dbTableName, isWorking ? "IS" : "IS NOT");
            var table = ExecuteReader(sql);
            var list = new List<Staff>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }
        public static Staff Select(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1}", dbTableName, id);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[table.Count - 1]) : null;
        }
        public static bool Insert(Staff e)
        {
            string sql = string.Format(
                "INSERT INTO {0}(nickname,citizen_id_number,fullname,birthday,gender,qualification,contact_number,address,start_date) " +
                "VALUE ('{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}')", 
                dbTableName, 
                e.Nickname, 
                e.CitizenId, 
                e.FullName, 
                e.Birthday.ToString("yyyy-MM-dd"), 
                e.GenderIsMale,
                e.Qualification,
                e.ContactNumber,
                e.Address,
                e.StartDate.ToString("yyyy-MM-dd"));
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool InsertAccount(int staffId)
        {
            string sql = string.Format("EXEC staff_insert_account @staff_id={0}", staffId);
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool Delete(int id)
        {
            RemoveAccount(id);
            string sql = string.Format("DELETE FROM {0} WHERE id = {1}", dbTableName, id);
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool UpdateInformation(Staff e)
        {
            string sql = string.Format("UPDATE {0} SET " +
                "citizen_id_number='{2}', " +
                "fullname='{3}', " +
                "birthday='{4}', " +
                "gender={5}, " +
                "qualification='{6}', " +
                "contact_number='{7}', " +
                "address='{8}' " +
                "WHERE id = {1}", dbTableName, e.CitizenId, e.FullName, e.Birthday.ToString("yyyy-MM-dd"), e.GenderIsMale, e.Qualification, e.ContactNumber, e.Address);
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool UpdateStatus(int id, DateTime resignationDate)
        {
            string sql = string.Format("UPDATE {0} SET " +
                "resignation_date='{2}'" +
                "WHERE id={1}", dbTableName, id, resignationDate.ToString("yyyy-MM-dd"));
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool RemoveAccount(int staffId) 
        {
            string sql = string.Format("SELECT (account_id) FROM {0} WHERE id = {1}", dbTableName, staffId);
            return AccountDAO.Delete(Convert.ToInt16(ExecuteScalar(sql)));
        }
    }
}