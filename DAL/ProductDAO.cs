using System;
using System.Collections.Generic;
using DTO;
using Google.Protobuf.WellKnownTypes;

namespace DAL
{
    public partial class ProductDAO : DBConnection
    {
        private static readonly string dbTableName = "product";
        private static Product ConvertToDTO_FullBatch(List<object> row) //full properties
        {
            try
            {
                int productId = Convert.ToInt16(row[0]);
                Product obj = new Product()
                {
                    Information = GetInformation(productId), //InfoDAO
                    Batches = GetProductBatch(productId), //BatchDAO
                    Stack = Convert.ToString(row[1]),
                    NumberSoldOut = Convert.ToInt16(row[2]),
                    Number = Convert.ToInt16(row[3]),
                    NumberSubunit = Convert.ToInt16(row[4]),
                    NumberAboutToExpire = Convert.ToInt16(row[5]),
                    Rate = Convert.ToInt16(row[6]),
                    IsOnSale = Convert.ToBoolean(row[7])
                };
                return obj;
            } catch { return null; }
        }
        private static Product ConvertToDTO_AvailableBatch(List<object> row)
        {
            try
            {
                int productId = Convert.ToInt16(row[0]);
                Product obj = new Product()
                {
                    Information = GetInformation(productId), //InfoDAO
                    Batches = GetAvailableProductBatch(productId), //BatchDAO
                    Stack = Convert.ToString(row[1]),
                    NumberSoldOut = Convert.ToInt16(row[2]),
                    Number = Convert.ToInt16(row[3]),
                    NumberSubunit = Convert.ToInt16(row[4]),
                    NumberAboutToExpire = Convert.ToInt16(row[5]),
                    Rate = Convert.ToInt16(row[6]),
                    IsOnSale = Convert.ToBoolean(row[7])
                };
                return obj;
            }
            catch { return null; }
        }

        public static List<Product> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0} WHERE is_existing = true", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<Product>();
            foreach (var row in table) 
            {
                list.Add(ConvertToDTO_FullBatch(row));
            }
            return list;
        }
        public static List<Product> SelectAll_Sale()
        {
            string sql = string.Format("SELECT * FROM {0} WHERE is_existing = true AND is_on_sale = true", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<Product>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO_AvailableBatch(row));
            }
            return list;
        }

        public static Product Select(int productId)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1} AND is_existing = true", dbTableName, productId);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO_FullBatch(table[table.Count - 1]) : null;
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
            if (Insert(e.Information)) 
            {
                int id = GetProductId(e.Information.Barcode);
                string sql = string.Format(
                    "UPDATE SET stack = '{2}', rate = {3}, is_on_sale = '{4}' " +
                    "FROM {0} WHERE id = {1}", dbTableName, id, e.Stack, e.Rate, e.IsOnSale);
                return ExecuteNonQuery(sql) > 0;
            }
            return false;
        }
        
        public static bool Delete(int id)
        {
            string sql = string.Format(
                "UPDATE SET is_existing = false FROM {0} WHERE id = {1}; " +
                "INSERT INTO trash_tmp VALUE ({1});", dbTableName, id);
            return ExecuteNonQuery(sql) != -1;
        }

        public static bool Recover(int id)
        {
            string sql = string.Format(
                "UPDATE SET is_existing = true FROM {0} WHERE id = {1}; " +
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
            string sql = string.Format(
                "UPDATE SET stack = '{2}', rate = {3}, is_on_sale = {4} " +
                "FROM {0} WHERE id = {1}", dbTableName, e.Id, e.Stack, e.Rate, e.IsOnSale);
            return ExecuteNonQuery(sql) != -1 && Update(e.Information);
        }

        public static bool UpdateBatch(ProductBatch e) => Update(e);
    }
}