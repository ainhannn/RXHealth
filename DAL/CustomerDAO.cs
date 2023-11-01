using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class CustomerDAO : DBConnection
    {
        private static readonly string dbTableName = "customer";

        private static Customer ConvertToDTO(List<object> row)
        {
            try
            {
                return new Customer(
                    Convert.ToInt16(row[0]),
                    Convert.ToString(row[1]),
                    Convert.ToString(row[2]),
                    Convert.ToInt16(row[3]) 
                );
            }
            catch { return null; }
        }

        public static List<Customer> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<Customer>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static Customer Select(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1}", dbTableName, id);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[table.Count - 1]) : null;
        }

        public static Customer Select(string contactNumber)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE contact_number = '{1}'", dbTableName, contactNumber);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[table.Count - 1]) : null;
        }

        public static bool Insert(Customer e)
        {
            string sql = string.Format(
                "INSERT INTO {0}(name,contact_number) " +
                "VALUE ('{1}','{2}'", dbTableName, e.Name, e.ContactNumber);
            return ExecuteNonQuery(sql) > 0;
        }

        public static bool Delete(int id)
        {
            string sql = string.Format("DELETE FROM {0} WHERE id = {1}", dbTableName, id);
            return ExecuteNonQuery(sql) > 0;
        }

        public static bool UpdateInformation(Customer e)
        {
            string sql = string.Format("UPDATE {0} SET " +
                "name = '{2}', " +
                "contact_number = '{3}' " +
                "WHERE id = {1}", dbTableName, e.Id, e.Name, e.ContactNumber, e.Address);
            return ExecuteNonQuery(sql) > 0;
        }
    }
}
