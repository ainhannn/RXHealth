using System;
using System.Collections.Generic;
using DTO;

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

        //public static List<ProductInfo> Search(string key)
        //{
        //    return new List<ProductInfo>();
        //}

        public static bool Insert(Product e)
        {
            ProductInfoDAO.Insert(e.Information);
            string sql = string.Format("CALL {0}_insert('{1}',{2},{3},{4},{5},{6},'{7}','{8}','{9}')", dbTableName, e.Name, e.Category.Id, e.Manufacturer.Id, e.MadeIn.Id, e.Expiry, e.Unit.Id, e.StorageCondition, e.Note, e.Image);
            return ExecuteNonQuery(sql) > 0;
        }
        
        public static bool Delete(int id)
        {
            string sql = string.Format("UPDATE SET is_existing = 'false' FROM {0} WHERE id = {1}", dbTableName, id);
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