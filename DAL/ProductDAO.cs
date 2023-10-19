using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class ProductInfoDAO : DBConnection
    {
        private static string dbTableName = "product_info";
        private static ProductInfo ConvertToDTO(List<object> row)
        {
            try
            {
                ProductInfo obj = new ProductInfo(Convert.ToInt16(row[0]), Convert.ToString(row[1]));
                obj.Name = Convert.ToString(row[2]);
                obj.Category = CategoryDAO.Select(Convert.ToInt16(row[3]));
                obj.Manufacturer = ManufacturerDAO.Select(Convert.ToInt16(row[4]));
                obj.MadeIn = CountryDAO.Select(Convert.ToInt16(row[5]));
                obj.Expiry = Convert.ToByte(row[6]);
                obj.Unit = UnitDAO.Select(Convert.ToInt16(row[7]));
                obj.StorageCondition = Convert.ToString(row[8]);
                obj.Note = Convert.ToString(row[9]);
                obj.Image = Convert.ToString(row[10]);

                var table = ExecuteReader("SELECT * FROM product_extra_ingredient WHERE product_id = " + obj.Id);
                foreach (var r in table)
                {
                    obj.AddIngredient(IngredientDAO.Select(Convert.ToInt16(r[1])), (float)r[2]);
                }
                return obj;
            } catch { return null; }
        }

        public static List<ProductInfo> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0} WHERE is_existing = 'true'", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<ProductInfo>();
            foreach (var row in table) 
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static ProductInfo Select(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1} AND is_existing = 'true'", dbTableName, id);
            var table = ExecuteReader(sql);
            return ConvertToDTO(table[table.Count - 1]);
        }

        //public static List<ProductInfo> Search(string key)
        //{
        //    return new List<ProductInfo>();
        //}

        public static bool Insert(ProductInfo e)
        {
            // viet lai ham transaction tren db goi len
            string sql = string.Format(
                "INSER INTO {0}(name,category_id,manufacturer_id,made_in,expiry,unit_id,storage_condition,note,image) " +
                "VALUE ('{1}',{2},{3},{4},{5},{6},'{7}','{8}','{9}')", dbTableName, e.Name, e.Category.Id, e.Manufacturer.Id, e.MadeIn.Id, e.Expiry, e.Unit.Id, e.StorageCondition, e.Note, e.Image);
            return ExecuteNonQuery(sql) > 0;
        }
        
        public static bool Delete(int id)
        {
            string sql = string.Format("DELETE FROM product_extra_ingredient WHERE id = {1}; " +
                "DELETE FROM {0} WHERE id = {1}", dbTableName, id);
            return ExecuteNonQuery(sql) != -1;
        }

        public static bool Update(ProductInfo e)
        {
            string sql = string.Format(""); // code here
            return ExecuteNonQuery(sql) > 0;
        }
    }
}