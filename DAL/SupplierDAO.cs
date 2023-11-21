using System;
using System.Collections.Generic;
using DTO;
using Org.BouncyCastle.Utilities;

namespace DAL
{
    public class SupplierDAO : DBConnection
    {
        private static readonly string dbTableName = "supplier";

        private static Supplier ConvertToDTO(List<object> row)
        {
            try
            {
                var rs = new Supplier(Convert.ToInt16(row[0]))
                {
                    Name = Convert.ToString(row[1]),
                    ContactNumber = Convert.ToString(row[2]),
                    Address = Convert.ToString(row[3])
                };
                rs.Times = ImportDAO.CountBySupplier(rs.Id);
                return rs;
            }
            catch { return null; }
        }

        public static List<Supplier> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<Supplier>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static Supplier Select(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1} LIMIT 1", dbTableName, id);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[0]) : null;
        }

        public static List<Supplier> SearchOnName(string name)
        {
            string sql = string.Format(
                "SELECT * FROM {0} " +
                "WHERE name LIKE '%{1}%'", dbTableName, name);
            var table = ExecuteReader(sql);
            var list = new List<Supplier>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static bool Insert(Supplier e)
        {
            string sql = string.Format(
                "INSERT INTO {0}(name,contact_number,address) " +
                "VALUE ('{1}','{2}','{3}')", dbTableName, 
                    e.Name, 
                    e.ContactNumber, 
                    e.Address);
            return ExecuteNonQuery(sql) > 0;
        }

        public static bool Delete(int id)
        {
            string sql = string.Format("DELETE FROM {0} WHERE id = {1}", dbTableName, id);
            return ExecuteNonQuery(sql) > 0;
        }

        public static bool UpdateInformation(Supplier e)
        {
            string sql = string.Format("UPDATE {0} SET " +
                "name = '{2}', " +
                "contact_number = '{3}', " +
                "address = '{4}' " +
                "WHERE id = {1}", dbTableName, e.Id, e.Name, e.ContactNumber, e.Address);
            return ExecuteNonQuery(sql) > 0;
        }
    }
}
