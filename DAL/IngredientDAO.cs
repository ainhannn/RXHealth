using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class IngredientDAO : DBConnection
    {
        private static string dbTableName = "active_ingredient";
        private static Ingredient ConvertToDTO(List<object> row)
        {
            try { return new Ingredient(Convert.ToInt16(row[0]), Convert.ToString(row[1])); }
            catch { return null; }
        }

        public static List<Ingredient> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<Ingredient>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }
        public static Ingredient Select(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1}", dbTableName, id);
            var table = ExecuteReader(sql);
            return ConvertToDTO(table[table.Count - 1]);
        }
        public static bool Insert(Ingredient e)
        {
            string sql = string.Format("INSER INTO {0}(name) VALUE ('{1}')", dbTableName, e.Name);
            return ExecuteNonQuery(sql) > 0;
        }

        public static bool Delete(int id)
        {
            string sql = string.Format("DELETE FROM {0} WHERE id = {1}", dbTableName, id);
            return ExecuteNonQuery(sql) > 0;
        }

        public static bool Update(Ingredient e)
        {
            string sql = string.Format("UPDATE {0} SET name = '{2}' WHERE id = {1}", dbTableName, e.Id, e.Name);
            return ExecuteNonQuery(sql) > 0;
        }
    }
}