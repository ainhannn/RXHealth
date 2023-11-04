using System;
using System.Collections.Generic;
using System.Management.Instrumentation;
using DTO;

namespace DAL
{
    public partial class ProductDAO : DBConnection
    {
        private static readonly string dbBatchTableName = "product_batch";
        private static ProductBatch ConvertToBatchDTO(List<object> row)
        { //0:id, 1:local_code, 2:import_invoice_id, 3:product_id, 4: manufacture_date, 5:number, 6:subunit_number, 7:sale_unit_price, 8:sale_subunit_price
            try
            {
                int impId = Convert.ToInt16(row[2]);
                int pid = Convert.ToInt16(row[3]);

                var impIV = ImportDAO.SelectForm(impId);
                var item = ImportDAO.SelectDetail(impId, pid);

                ProductBatch obj = new ProductBatch(Convert.ToInt16(row[0]), Convert.ToString(row[1]))
                {
                    ImportDate = impIV.DateInit,
                    ManufactureDate = Convert.ToDateTime(row[4]),
                    Number = Convert.ToInt16(row[5]),
                    NumberSubunit = Convert.ToInt16(row[6]),
                    ImportUnitPrice = item.UnitPrice,
                    SaleUnitPrice = (float)row[7],
                    SaleSubunitPrice = (float)row[8],
                    Provider = impIV.Provider
                };

                return obj;
            } catch { return null; }
        }

        //public static List<ProductBatch> SelectAll()
        //{
        //    string sql = string.Format("SELECT * FROM {0}", dbTableName);
        //    var table = ExecuteReader(sql);
        //    var list = new List<ProductBatch>();
        //    foreach (var row in table) 
        //    {
        //        list.Add(ConvertToDTO(row));
        //    }
        //    return list;
        //}

        private static List<ProductBatch> GetProductBatch(int productId)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE product_id = {1}", dbBatchTableName, productId);
            var table = ExecuteReader(sql);
            var list = new List<ProductBatch>();
            foreach (var row in table)
            {
                list.Add(ConvertToBatchDTO(row));
            }
            return list;
        }
        private static List<ProductBatch> GetAvailableProductBatch(int productId)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE product_id = {1} AND (number > 0 OR subunit_number > 0)", dbBatchTableName, productId);
            var table = ExecuteReader(sql);
            var list = new List<ProductBatch>();
            foreach (var row in table)
            {
                list.Add(ConvertToBatchDTO(row));
            }
            return list;
        }

        //private static ProductBatch Select(string localCode)
        //{
        //    string sql = string.Format("SELECT * FROM {0} WHERE local_code = '{1}'", dbTableName, localCode);
        //    var table = ExecuteReader(sql);
        //    return table.Count != 0 ? ConvertToBatchDTO(table[table.Count - 1]) : null;
        //}
        
        public static string GetLocalCode(int batchId)
        {
            string sql = string.Format("SELECT local_code FROM {0} WHERE id = {1}", dbBatchTableName, batchId);
            return Convert.ToString(ExecuteScalar(sql));
        }

        public static int GetBatchId(string localCode)
        {
            if (string.IsNullOrEmpty(localCode)) { return 0; }
            string sql = string.Format("SELECT id FROM {0} WHERE local_code = '{1}'", dbBatchTableName, localCode);
            return Convert.ToInt16(ExecuteScalar(sql));
        }

        public static int GetProductIdFromBatchId(int batchId)
        {
            string sql = string.Format("SELECT product_id FROM {0} WHERE id = {1}", dbBatchTableName, batchId);
            return Convert.ToInt16(ExecuteScalar(sql));
        }

        public static int GetProductIdFromLocalCode(string localCode)
        {
            if (string.IsNullOrEmpty(localCode)) { return 0; }
            string sql = string.Format("SELECT product_id FROM {0} WHERE local_code = '{1}'", dbBatchTableName, localCode);
            return Convert.ToInt16(ExecuteScalar(sql));
        }

        private static bool Update(ProductBatch e)
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