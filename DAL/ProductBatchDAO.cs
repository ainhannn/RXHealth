using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class ProductBatchDAO : DBConnection
    {
        private static string dbTableName = "product_batch";
        private static ProductBatch ConvertToDTO(List<object> row)
        {
            try
            {
                ProductInfo obj = new ProductInfo(Convert.ToInt16(row[0]), Convert.ToString(row[1]))
                {
                    Name = Convert.ToString(row[2]),
                    Category = CategoryDAO.Select(Convert.ToInt16(row[3])),
                    Manufacturer = ManufacturerDAO.Select(Convert.ToInt16(row[4])),
                    MadeIn = CountryDAO.Select(Convert.ToInt16(row[5])),
                    Expiry = Convert.ToByte(row[6]),
                    Unit = UnitDAO.Select(Convert.ToInt16(row[7])),
                    StorageCondition = Convert.ToString(row[8]),
                    Note = Convert.ToString(row[9]),
                    Image = Convert.ToString(row[10])
                };

                var table = ExecuteReader("SELECT * FROM product_extra_ingredient WHERE product_id = " + obj.Id);
                foreach (var r in table)
                {
                    obj.AddIngredient(IngredientDAO.Select(Convert.ToInt16(r[1])), (float)r[2]);
                }
                return obj;
            } catch { return null; }
        }

        public static List<ProductBatch> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<ProductBatch>();
            foreach (var row in table) 
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static List<ProductBatch> Select(int productId)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE product_id = {1}", dbTableName, productId);
            var table = ExecuteReader(sql);
            var list = new List<ProductBatch>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static ProductBatch Select(string localCode)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE localCode = '{1}'", dbTableName, localCode);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[table.Count - 1]) : null;
        }

        //public static List<ProductInfo> Search(string key)
        //{
        //    return new List<ProductInfo>();
        //}
        public static bool Update(ProductBatch e)
        {
            string sql = string.Format("UPDATE SET " +
                "manufacture_date = '{2}' " +
                "sale_unit_price = {3}, " +
                "sale_subunit_price = {4} " +
                "FROM {0} WHERE id = {1}", dbTableName, e.Id, 
                e.ManufactureDate.ToString("yyyy-MM-dd"), 
                e.SaleUnitPrice, 
                e.SaleSubunitPrice);
            return ExecuteNonQuery(sql) != -1;
        }
    }
}