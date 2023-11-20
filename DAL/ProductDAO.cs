using System;
using System.Collections.Generic;
using System.Xml.Linq;
using DTO;
using Google.Protobuf.WellKnownTypes;

namespace DAL
{
    public partial class ProductDAO : DBConnection
    {
        private static readonly string dbTableName = "product";
        private static readonly string dbViewName = "review_product";

        private static Product ConvertToDTO(List<object> row) //full properties
        {
            try
            {
                int productId = Convert.ToInt16(row[0]);
                Product obj = new Product(productId)
                {






                };
                return obj;
            } catch { return null; }
        }

        public static int GetProductId (string barcode)
        {
            return 0;
        }

        public static List<Product> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0}", dbViewName);
            var table = ExecuteReader(sql);
            var list = new List<Product>();
            foreach (var row in table) 
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        //public static List<ProductOnSale> SelectAll_Sale()
        //{
        //    string sql = string.Format("SELECT * FROM search_sale_product");
        //    var table = ExecuteReader(sql);
        //    var list = new List<ProductOnSale>();
        //    foreach (var row in table)
        //    {
        //        var p = new ProductOnSale()
        //        {
        //            Barcode = row[0].ToString(),
        //            Name = row[1].ToString(),
        //            Category = row[2].ToString(),
        //            Unit = row[3].ToString(),
        //            Saleprice = (float)row[4],
        //            Number = (int)row[5]
        //        };
        //        list.Add(p);
        //    }
        //    return list;
        //}

        public static Product Select(int productId)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1} LIMIT 1", dbTableName, productId);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[0]) : null;
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









            return false;
        }
        
        public static bool Delete(int productId)
        {
            string sql = string.Format(
                "UPDATE SET is_existing = false FROM {0} WHERE id = {1}; " +
                "INSERT INTO trash_tmp VALUE ({1});", dbTableName, productId);
            return ExecuteNonQuery(sql) != -1;
        }

        public static bool Recover(int productId)
        {
            string sql = string.Format(
                "UPDATE SET is_existing = true FROM {0} WHERE id = {1}; " +
                "DELETE FROM trash_tmp WHERE id = {1};", dbTableName, productId); 
            return ExecuteNonQuery(sql) != -1;
        }

        public static bool DeleteTrash(int productId)
        {
            string sql = string.Format("DELETE FROM trash_tmp WHERE id = {0};", productId);
            return ExecuteNonQuery(sql) != -1;
        }

        public static bool EmptyTrash()
        {
            string sql = string.Format("DELETE FROM trash_tmp");
            return ExecuteNonQuery(sql) != -1;
        }
    }
}