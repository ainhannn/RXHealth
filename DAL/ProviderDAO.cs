using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class ProviderDAO : DBConnection
    {
        private static string dbTableName = "provider";

        private static Provider ConvertToDTO(List<object> row)
        {
            try
            {
                DateTimeCycle timeCycle = null;
                if (row[5] != null && row[6] != null) 
                { 
                    timeCycle.Current = Convert.ToDateTime(row[5]); 
                    timeCycle.Cycle = Convert.ToString(row[6]);
                }

                return new Provider(
                    Convert.ToInt16(row[0]),
                    Convert.ToString(row[1]),
                    Convert.ToString(row[2]),
                    Convert.ToString(row[3]),
                    Convert.ToDouble(row[4]),
                    timeCycle
                );
            }
            catch { return null; }
        }

        public static List<Provider> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<Provider>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static Provider Select(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1}", dbTableName, id);
            var table = ExecuteReader(sql);
            return ConvertToDTO(table[table.Count - 1]);
        }

        public static bool Insert(Provider e)
        {
            string sql = string.Format(
                "INSERT INTO {0}(name,subunit_id,number_each_unit) " +
                "VALUE ('{1}',{2},{3})", dbTableName, e.Name, e.Subunit.Id, e.Number);
            return ExecuteNonQuery(sql) > 0;
        }

        public static bool Delete(int id)
        {
            string sql = string.Format("DELETE FROM {0} WHERE id = {1}", dbTableName, id);
            return ExecuteNonQuery(sql) > 0;
        }

        public static bool Update(Provider e)
        {
            string sql = string.Format("UPDATE {0} SET " +
                "name = '{2}', " +
                "subunit_id = {3}, " +
                "number_each_unit = {4} " +
                "WHERE id = {1}", dbTableName, e.Id, e.Name, e.Subunit.Id, e.Number);
            return ExecuteNonQuery(sql) > 0;
        }
    }
}
