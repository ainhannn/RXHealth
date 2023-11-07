using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class StaffDAO : DBConnection
    {
        private static readonly string dbTableName = "staff";

        private static Staff ConvertToDTO(List<object> row)
        {
            try
            {
                DateTime d = DateTime.Now;
                bool b = true;
                int i =  0;
                Staff staff = new Staff(Convert.ToInt16(row[0]), Convert.ToString(row[1])) // id, nickname
                {
                    CitizenId = Convert.ToString(row[2]),
                    FullName = Convert.ToString(row[3]),
                    Birthday = DateTime.TryParse(row[4].ToString(), out d) ? d : DateTime.MinValue,
                    GenderIsMale = Boolean.TryParse(row[5].ToString(), out b) ? d : true,
                    Qualification = Convert.ToString(row[6]),
                    ContactNumber = Convert.ToString(row[7]),
                    Address = Convert.ToString(row[8]),
                    Account = Int16.TryParse(row[9].ToString(), out i) ? AccountDAO.Select(i) : null,
                    StartDate = DateTime.TryParse(row[10].ToString(), out d) ? d : DateTime.Now,
                    ResignationDate = DateTime.TryParse(row[11].ToString(), out d) ? d : DateTime.MaxValue
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
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1} LIMIT 1", dbTableName, id);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[0]) : null;
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
        public static bool InsertAccount(int staffId, int role)
        {
            string sql = string.Format("CALL insert_account({0},{1})", staffId, role);
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
