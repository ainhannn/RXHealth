using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
                var d = DateTime.Now;
                int i = 0;
                try
                {
                    i = Convert.ToInt16(row[9]);
                }
                catch { i = 0; }
                int id = Convert.ToInt16(row[0]);
                string name = Convert.ToString(row[1]);
                string CitizenId = Convert.ToString(row[2]);
                string FullName = Convert.ToString(row[3]);
                DateTime Birthday = DateTime.TryParse(row[4].ToString(), out d) ? d : DateTime.MinValue;
                bool gender = Convert.ToInt16(row[5]) == 1;
                string Qualification = Convert.ToString(row[6]);
                string ContactNumber = Convert.ToString(row[7]);
                string Address = Convert.ToString(row[8]);
                DateTime StartDate = Convert.ToDateTime(row[9]);
                DateTime ResignationDate = DateTime.TryParse(row[10].ToString(), out d) ? d : new DateTime(9998, 12, 31);

                return new Staff(id, name, CitizenId, FullName, Birthday, gender, Qualification, ContactNumber, Address, StartDate, ResignationDate);
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
        public static List<Staff> SelectOnRequest(string request, int filter, int gender)
        {
            string sql = string.Format("SELECT * FROM {0} JOIN account ON staff.id = account.id WHERE (staff.id LIKE '%{1}%' OR staff.nickname LIKE '%{1}%' OR " +
        "staff.citizen_id_number LIKE '%{1}%' OR staff.fullname LIKE '%{1}%' OR staff.birthday LIKE '%{1}%' OR " +
        "qualification LIKE '%{1}%' OR contact_number LIKE '%{1}%' OR " +
        "address LIKE '%{1}%' OR staff.start_date LIKE '%{1}%' OR staff.resignation_date LIKE '%{1}%') ",
        dbTableName, request);

            if (filter != 3)
            {
                sql += string.Format(" AND account.role = {0}", filter);
            }

            if (gender != 2)
            {
                sql += string.Format(" AND staff.gender = {0}", gender);
            }

            Console.WriteLine(sql);

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
        public static int SelectId(string CitizenId)
        {
            string sql = string.Format("SELECT id FROM {0} WHERE citizen_id_number = {1} LIMIT 1", dbTableName, CitizenId);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? Convert.ToInt16(table[0][0]) : -1;
        }
        public static bool Insert(Staff e)
        {
            string sql = string.Format(
                "INSERT INTO {0} (nickname,citizen_id_number,fullname,birthday,gender,qualification,contact_number,address,start_date) " +
                "VALUE ('{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}')",
                dbTableName,
                e.Nickname,
                e.CitizenId,
                e.FullName,
                e.Birthday.ToString("yyyy-MM-dd"),
                e.GenderIsMale == true ? 1 : 0,
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
                "address='{8}', " +
                "nickname='{9}', " +
                "resignation_date='{10}' " +
                "WHERE id = {1}", dbTableName, e.Id, e.CitizenId, e.FullName, e.Birthday.ToString("yyyy-MM-dd"), e.GenderIsMale, e.Qualification, e.ContactNumber, e.Address, e.Nickname, e.ResignationDate.ToString("yyyy-MM-dd"));
            Console.WriteLine(sql);
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool UpdateNickname(int id, string nickname)
        {
            string sql = string.Format("UPDATE {0} SET nickname='{2}' WHERE id={1}", dbTableName, id, nickname);
            Console.WriteLine(sql);
            return ExecuteNonQuery(sql) > 0;
        }
        public static bool UpdateStatus(int id, DateTime resignationDate)
        {
            string sql = string.Format("UPDATE {0} SET " +
                "resignation_date='{2}'" +
                "WHERE id={1}", dbTableName, id, resignationDate.ToString("yyyy-MM-dd"));
            return ExecuteNonQuery(sql) > 0;
        }

    }
}
