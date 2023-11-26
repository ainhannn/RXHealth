using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public partial class ProductDAO : DBConnection
    {
        private static StoProduct ConvertToStoProduct(List<object> row)
        {
            try
            {
                Int16.TryParse(row[0].ToString(), out var id);
                var barcode = row[2].ToString();
                var name = row[3].ToString();
                Int16.TryParse(row[4].ToString(), out var cateId);
                var cate = CategoryDAO.Select(cateId);
                var importNum = ImportDAO.SumByProduct(id);
                var unit = row[6].ToString();
                var currentNum = GetCurrentNumber(id);
                var retailUnit = row[8].ToString();
                Int16.TryParse(row[10].ToString(), out var retailNum);
                
                StoProduct obj = new StoProduct()
                {
                    Id = id,
                    Barcode = barcode,
                    Name = name,
                    Category = cate,
                    Unit = unit,
                    ImportNumber = importNum,
                    NumberSoldOut = importNum - currentNum,
                    TotalNumber = currentNum,
                    RetailUnit = retailUnit,
                    RetailNumber = retailNum,
                    Capacity = GetCapacity(id)
                };
                return obj;
            }
            catch { return null; }
        }

        public static List<StoProduct> SelectAllStoProduct()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<StoProduct>();
            foreach (var row in table) 
            {
                list.Add(ConvertToStoProduct(row));
            }
            return list;
        }

        public static List<StoProduct> SearchOnCategory(int cateId)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE category_id = {1}", dbTableName, cateId);
            var table = ExecuteReader(sql);
            var list = new List<StoProduct>();
            foreach (var row in table)
            {
                list.Add(ConvertToStoProduct(row));
            }
            return list;
        }

        public static int GetCapacity(int productId)
        {
            string sql = string.Format(
                "SELECT capacity FROM capacity_tmp " +
                "WHERE product_id = {0}", productId);

            try { return Convert.ToInt16(ExecuteScalar(sql)); }
            catch { return 0; }
        }

        public static int GetCurrentNumber(int productId) 
        {
            string sql = string.Format(
                "SELECT SUM(number) FROM {0}_batch " +
                "WHERE product_id = {1}", dbTableName, productId);
            return Convert.ToInt32(ExecuteScalar(sql));
        }   

        public static List<ProductBatch> SelectProductBatch(int productId, bool avaiOnly) 
        {
            string sql = string.Format(
                "SELECT * FROM {0}_batch " +
                "WHERE product_id = {1}", dbTableName, productId);

            if (avaiOnly) sql += " AND number > 0";

            var table = ExecuteReader(sql);
            var list = new List<ProductBatch>();
            foreach (var row in table)
            {
                try 
                {
                    DateTime.TryParse(row[2].ToString(), out var mfg);
                    DateTime.TryParse(row[3].ToString(), out var exp);
                    int.TryParse(row[4].ToString(), out int num);

                    list.Add(new ProductBatch()
                    {
                        LocalCode = row[0].ToString(),
                        MFGDate = mfg,
                        EXPDate = exp,
                        Number = num
                    });
                } catch { }
            }
            return list;
        }

        public static bool ExportForRetail(int id, int cap, int num)
        {
            string sql = string.Format(
                "CALL export_for_retail({0},{1},{2})", id, num, cap);
            return ExecuteNonQuery(sql) != -1;
        }
    }
}