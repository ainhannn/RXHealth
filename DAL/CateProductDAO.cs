using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public partial class ProductDAO : DBConnection
    {
        private static readonly string dbTableName = "product";
        
        public static int Count
        {
            get
            {
                string sql = string.Format("SELECT COUNT(id) FROM {0}", dbTableName);
                var rs = ExecuteScalar(sql);
                return rs != null ? int.TryParse(rs.ToString(), out int c) ? c : 0 : 0;
            }
        }

        public static int GetProductId(string barcode)
        {
            string sql = string.Format("SELECT id FROM {0} WHERE barcode = '{1}' LIMIT 1", dbTableName, barcode);
            var rs = ExecuteScalar(sql);
            if (int.TryParse(rs.ToString(), out int id))
                return id;
            return -1;
        }

        private static CateProduct ConvertToCateProduct(List<object> row)
        {
            try
            {
                Int16.TryParse(row[0].ToString(), out var id);
                var stack = row[1].ToString();
                var barcode = row[2].ToString();
                var name = row[3].ToString();
                Int16.TryParse(row[4].ToString(), out var cateId);
                var cate = CategoryDAO.Select(cateId);
                Double.TryParse(row[5].ToString(), out var impPrice);
                var unit = row[6].ToString();
                Double.TryParse(row[7].ToString(), out var saleprice);
                var retailUnit = row[8].ToString();
                Double.TryParse(row[9].ToString(), out var retailPrice);
                var info = row[11].ToString();
                var image = row[12].ToString();
                Boolean.TryParse(row[13].ToString(), out var isOnSale);

                CateProduct obj = new CateProduct()
                {
                    Id = id,
                    Stack = stack,
                    Barcode = barcode,
                    Name = name,
                    Category = cate,
                    Unit = unit,
                    CurrentImportPrice = impPrice,
                    Saleprice = saleprice,
                    RetailUnit = retailUnit,
                    RetailSaleprice = retailPrice,
                    ExtraInformation = info,
                    Image = image,
                    IsOnSale = isOnSale
                };
                return obj;
            } catch { return null; }
        }
        
        public static List<CateProduct> SelectAllCateProduct()
        {
            string sql = string.Format("SELECT * FROM {0} WHERE is_existing = 1", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<CateProduct>();
            foreach (var row in table) 
            {
                list.Add(ConvertToCateProduct(row));
            }
            return list;
        }
        
        public static List<CateProduct> AdvancedSearch(Dictionary<string, string> conditions)
        {
            if (conditions == null || conditions.Count == 0) 
                return SelectAllCateProduct();

            string sql = string.Format("SELECT * FROM {0} WHERE is_existing = 1", dbTableName);

            if (conditions.TryGetValue("price_min", out string pMin))
            {
                sql += string.Format(" AND current_import_price >= {0} AND saleprice >= {0} AND retail_saleprice >= {0}", pMin);
                conditions.Remove("price_min");
            }

            if (conditions.TryGetValue("price_max", out string pMax))
            {
                sql += string.Format(" AND current_import_price <= {0} AND saleprice <= {0} AND retail_saleprice <= {0}", pMax);
                conditions.Remove("price_max");
            }

            if (conditions.TryGetValue("is_on_sale", out string isOnSale))
            {
                sql += string.Format(" AND is_on_sale = {0}", isOnSale);
                conditions.Remove("is_on_sale");
            }

            foreach (var condition in conditions)
                sql += string.Format(" AND {0} LIKE '%{1}%'", condition.Key, condition.Value);
            
            var table = ExecuteReader(sql);
            var list = new List<CateProduct>();
            foreach (var row in table)
            {
                list.Add(ConvertToCateProduct(row));
            }
            return list;
        }

        public static bool Update(CateProduct e)
        {
            if (e == null) return false;

            string sql = string.Format(
                "UPDATE {0} SET " +
                    "stack = '{2}', " +
                    "name = '{3}', " +
                    "category_id = {4}, " +
                    "unit = '{5}', " +
                    "saleprice = {6}, " +
                    "retail_unit = '{7}', " +
                    "retail_saleprice = {8}, " +
                    "extra_information = '{9}', " +
                    "image = '{10}', " +
                    "is_on_sale = {11} " +
                "WHERE id = {1}", dbTableName, e.Id, e.Stack, e.Name, e.Category.Id, e.Unit, e.Saleprice, e.RetailUnit, e.RetailSaleprice, e.ExtraInformation, e.Image, e.IsOnSale);

            return ExecuteNonQuery(sql) != -1;
        }

        public static bool Insert(CateProduct e)
        {
            if (e == null) return false;

            string sql = string.Format(
                "INSERT INTO `{0}`" +
                    "(`stack`, `barcode`, `name`, `category_id`, " +
                    "`current_import_price`, `unit`, `saleprice`, " +
                    "`retail_unit`, `retail_saleprice`, " +
                    "`extra_information`, `image`) " +
                "VALUES ('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", dbTableName, 
                    e.Stack, e.Barcode, e.Name, e.Category.Id, 
                    e.CurrentImportPrice, e.Unit, e.Saleprice, 
                    e.RetailUnit, e.RetailSaleprice, 
                    e.ExtraInformation, e.Image);

            return ExecuteNonQuery(sql) != -1;
        }

        public static bool Delete(int productId)
        {
            string sql = string.Format(
                "UPDATE {0} SET is_existing = false WHERE id = {1}; " +
                "INSERT INTO trash_tmp VALUE ({1});", dbTableName, productId);
            return ExecuteNonQuery(sql) != -1;
        }

        public static List<CateProduct> SelectAllTrash()
        {
            string sql = string.Format(
                "SELECT * FROM {0} " +
                "WHERE id IN " +
                "(SELECT product_id FROM trash_tmp)", dbTableName);
            
            var table = ExecuteReader(sql);
            var list = new List<CateProduct>();
            foreach (var row in table)
            {
                list.Add(ConvertToCateProduct(row));
            }
            return list;
        }
        
        public static bool Recover(int productId)
        {
            string sql = string.Format(
                "UPDATE {0} SET is_existing = true WHERE id = {1}; " +
                "DELETE FROM trash_tmp WHERE product_id = {1};", dbTableName, productId);
            return ExecuteNonQuery(sql) != -1;
        }

        public static bool DeleteTrash(int productId)
        {
            string sql = string.Format("DELETE FROM trash_tmp WHERE product_id = {0};", productId);
            return ExecuteNonQuery(sql) != -1;
        }

        public static bool EmptyTrash()
        {
            string sql = string.Format("DELETE FROM trash_tmp");
            return ExecuteNonQuery(sql) != -1;
        }
    }
}