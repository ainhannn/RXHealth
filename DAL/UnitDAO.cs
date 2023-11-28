using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class UnitDAO : DBConnection
    {
        private static string dbTableName = "unit";

        private static Unit ConvertToDTO(List<object> row)
        {
            try
            {
                Unit subunit = null;
                if (row[2] != null) { subunit = Select(Convert.ToInt16(row[2])); }
                return new Unit(
                    Convert.ToInt16(row[0]),
                    Convert.ToString(row[1]),
                    subunit,
                    Convert.ToInt16(row[3])
                );
            } catch { return null; }
        }

        public static List<Unit> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<Unit>();
            foreach (var row in table) 
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static Unit Select(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1}", dbTableName, id);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[table.Count - 1]) : null;
        }

        public static bool Insert(Unit e)
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

        public static bool Update(Unit e)
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
