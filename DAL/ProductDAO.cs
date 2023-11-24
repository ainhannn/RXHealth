using System;
using System.Collections.Generic;
using DTO;

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
            string sql = string.Format("SELECT id FROM {0} WHERE barcode = '{1}' LIMIT 1", dbTableName, barcode);
            var rs = ExecuteScalar(sql);
            if (int.TryParse(rs.ToString(), out int id))
                return id;
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
        //            Saleprice = (double)row[4],
        //            Number = (int)row[5]
        //        };
        //        list.Add(p);
        //    }
        //    return list;
        //}

        

        
        

        
    }
}