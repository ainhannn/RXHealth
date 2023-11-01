using System;
using System.Collections.Generic;
using DTO;
using Google.Protobuf.WellKnownTypes;

namespace DAL
{
    public class ProductDAO : DBConnection
    {
        private static string dbTableName = "product";
        private static Product ConvertToDTO(List<object> row)
        {
            try
            {
                Product obj = new Product()
                {
                    Information = ProductInfoDAO.Select(Convert.ToInt16(row[0])),
                    Stack = Convert.ToString(row[1]),
                    NumberSoldOut = Convert.ToInt16(row[2]),
                    Number = Convert.ToInt16(row[3]),
                    NumberSubunit = Convert.ToInt16(row[4]),
                    NumberAboutToExpire = Convert.ToInt16(row[5]),
                    Rate = Convert.ToInt16(row[6]),
                    IsOnSale = Convert.ToBoolean(row[7])
                };
                var list = ProductBatchDAO.Select(obj.Information.Id);
                foreach (var e in list)
                {
                    obj.AddProductBatch(e);
                }
                return obj;
            } catch { return null; }
        }

        public static List<Product> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0} WHERE is_existing = 'true'", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<Product>();
            foreach (var row in table) 
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }
        public static List<Product> SelectAllSale()
        {
            string sql = string.Format("SELECT * FROM {0} WHERE is_existing = 'true' AND is_on_sale = 'true'", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<Product>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static Product Select(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1} AND is_existing = 'true'", dbTableName, id);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[table.Count - 1]) : null;
        }

        public static Product Select(string barCode)
        {
            if (string.IsNullOrEmpty(barCode)) { return null; }
            var info = ProductInfoDAO.Select(barCode);
            return info != null ? Select(info.Id) : null;
        }

        public static List<Product> AdvancedSearch(Dictionary<string, string> conditions)
        {
            var list = new List<Product>();
            //foreach (var condition in conditions) 
            //{
            //    string value = "";
            //    if (conditions.TryGetValue(condition.Key,out value ))
            //    {
            //        Console.WriteLine("For key = \"tif\", value = {0}.", value);
            //    }

            //}
            return list;
        }
        public static bool Insert(Product e)
        {
            if (ProductInfoDAO.Insert(e.Information)) 
            {
                e.Information = ProductInfoDAO.Select(e.Information.Barcode);
                string sql = string.Format(
                    "UPDATE SET stack = '{2}', rate = {3}, is_on_sale = '{4}' " +
                    "FROM {0} WHERE id = {1}", dbTableName, e.Information.Id, e.Stack, e.Rate, e.IsOnSale);
                return ExecuteNonQuery(sql) > 0;
            }
            return false;
        }
        
        public static bool Delete(int id)
        {
            string sql = string.Format(
                "UPDATE SET is_existing = 'false' FROM {0} WHERE id = {1}; " +
                "INSERT INTO trash_tmp VALUE ({1});", dbTableName, id);
            return ExecuteNonQuery(sql) != -1;
        }

        public static bool Recover(int id)
        {
            string sql = string.Format(
                "UPDATE SET is_existing = 'true' FROM {0} WHERE id = {1}; " +
                "DELETE FROM trash_tmp WHERE id = {1};", dbTableName, id); 
            return ExecuteNonQuery(sql) != -1;
        }

        public static bool DeleteTrash(int id)
        {
            string sql = string.Format("DELETE FROM trash_tmp WHERE id = {0};", id);
            return ExecuteNonQuery(sql) != -1;
        }

        public static bool EmptyTrash()
        {
            string sql = string.Format("DELETE FROM trash_tmp");
            return ExecuteNonQuery(sql) != -1;
        }

        public static bool Update(Product e)
        {
            string sql = string.Format("UPDATE SET " +
                "stack = '{2}', " +
                "rate = {3}, " +
                "is_on_sale = '{4}' " +
                "FROM {0} WHERE id = {1}", dbTableName, e.Information.Id, e.Stack, e.Rate, e.IsOnSale);
            return ExecuteNonQuery(sql) != -1 && ProductInfoDAO.Update(e.Information);
        }
        
        public static bool UpdateBatch(ProductBatch e) => ProductBatchDAO.Update(e);
        
    }
}