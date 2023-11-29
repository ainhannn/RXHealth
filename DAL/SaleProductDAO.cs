using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public partial class ProductDAO : DBConnection
    {
        public static Dictionary<string, int> CountSalesByCate()
        {
            string sql = String.Format(
                "SELECT cate, SUM(times) " +
                "FROM best_seller_product " +
                "GROUP BY cate");
            var rd = ExecuteReader(sql);
            var list = new Dictionary<string, int>();
            if (rd != null)
            {
                foreach (var row in rd) list.Add(row[0].ToString(), Convert.ToInt16(row[1]));
                return list;
            }
            return null;
        }

        public static int CountSalesByCate(string cate)
        {
            string sql = String.Format(
                "SELECT SUM(times) " +
                "FROM best_seller_product " +
                "WHERE cate LIKE '%{0}%'", cate);
            return Convert.ToInt16(ExecuteScalar(sql));
        }

        public static Dictionary<string, int> GetBestSellingByCate(string cate, int limit)
        {
            string sql = String.Format(
                "SELECT name, times " +
                "FROM best_seller_product " +
                "WHERE cate LIKE '%{0}%' " +
                "ORDER BY times DESC LIMIT {1}", cate, limit);

            var rs = new Dictionary<string, int>();
            foreach (var row in ExecuteReader(sql))
            {
                rs.Add(row[0].ToString(), Convert.ToInt16(row[1]));
            }
            return rs;
        }

        public static Dictionary<string, int> GetBestSelling(int limit)
        {
            string sql = String.Format(
                "SELECT name, times " +
                "FROM best_seller_product " +
                "ORDER BY times DESC LIMIT {0}", limit);

            var rs = new Dictionary<string, int>();
            foreach (var row in ExecuteReader(sql))
            {
                rs.Add(row[0].ToString(), Convert.ToInt16(row[1]));
            }
            return rs;
        }

        public static List<ProductOnSale> SelectAllSaleProduct()
        {
            string sql = string.Format("SELECT * FROM search_sale_product");
            var table = ExecuteReader(sql);
            var list = new List<ProductOnSale>();
            foreach (var row in table)
            {
                if (Convert.ToDouble(row[4]) > 0 && Convert.ToInt16(row[5]) > 0)
                {
                    list.Add(new ProductOnSale()
                    {
                        Barcode = row[0].ToString(),
                        Name = row[1].ToString(),
                        Category = row[2].ToString(),
                        Unit = row[3].ToString(),
                        Saleprice = Convert.ToDouble(row[4]),
                        Number = Convert.ToInt16(row[5])
                    });
                }
                if (Convert.ToDouble(row[7]) > 0 && Convert.ToInt16(row[8]) > 0)
                {
                    list.Add(new ProductOnSale()
                    {
                        Barcode = row[0].ToString(),
                        Name = row[1].ToString(),
                        Category = row[2].ToString(),
                        Unit = row[6].ToString(),
                        Saleprice = Convert.ToDouble(row[7]),
                        Number = Convert.ToInt16(row[8])
                    });
                }
            }
            return list;
        }
    }
}