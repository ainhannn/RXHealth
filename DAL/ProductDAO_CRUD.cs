using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml.Linq;
using DTO;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace DAL
{
    public partial class ProductDAO : DBConnection
    {
        

        public static List<ProductOnSale> Select_WholeSale2()
        {
            string sql = string.Format("SELECT * FROM search_sale_product");
            var table = ExecuteReader(sql);
            var list = new List<ProductOnSale>();
            foreach (var row in table)
            {
                var p1 = new ProductOnSale()
                {
                    Barcode = row[0].ToString(),
                    Name = row[1].ToString(),
                    Category = row[2].ToString(),
                    Unit = row[3].ToString(),
                    Saleprice = Convert.ToDouble(row[4]),
                    Number = Convert.ToInt16(row[5])
                };

                var p2 = new ProductOnSale()
                {
                    Barcode = p1.Barcode,
                    Name = p1.Name,
                    Category = p1.Category,
                    Unit = row[6].ToString(),
                    Saleprice = Convert.ToDouble(row[7]),
                    Number = Convert.ToInt16(row[8])
                };

                list.Add(p1);
                list.Add(p2);
            }
            return list;
        }

        public static List<ProductOnSale> Select_WholeSale1(string searchTerm)
        {
            // Sử dụng tham số trong truy vấn để tránh tình trạng SQL injection
            string sql = String.Format(
                "SELECT * FROM search_sale_product " +
                "WHERE name LIKE '%{0}%' OR cate LIKE '%{0}%'", searchTerm);

            // Thực hiện truy vấn với tham số
            var table = ExecuteReader(sql);
            var list = new List<ProductOnSale>();
            foreach (var row in table)
            {
                var p1 = new ProductOnSale()
                {
                    Barcode = row[0].ToString(),
                    Name = row[1].ToString(),
                    Category = row[2].ToString(),
                    Unit = row[3].ToString(),
                    Saleprice = Convert.ToDouble(row[4]),
                    Number = Convert.ToInt16(row[5])
                };

                var p2 = new ProductOnSale()
                {
                    Barcode = p1.Barcode,
                    Name = p1.Name,
                    Category = p1.Category,
                    Unit = row[6].ToString(),
                    Saleprice = Convert.ToDouble(row[7]),
                    Number = Convert.ToInt16(row[8])
                };

                list.Add(p1);
                list.Add(p2);
            }
            return list;
        }

        public int getSoLuongTonfromMa(String maCTSP)
        {
            int soLuongTon = 0;
            SqlCommand cmd;
            String sql = "SELECT number FROM DBO.ChiTietSanPham as ctsp" +
                    "\r\nwhere ctsp.MaChiTietSanPham= " + maCTSP;
            var table = ExecuteReader(sql);
            var list = new List<ProductOnSale>();
            foreach (var row in table)
            {
                var p = new ProductOnSale()
                {
                    Number = Convert.ToInt16(row[5])
                };

            }
            return soLuongTon;


        }

    }
}