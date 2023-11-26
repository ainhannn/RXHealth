//using System;
//using System.Collections.Generic;
//using System.Management.Instrumentation;
//using DTO;

//namespace DAL
//{
//    public partial class ProductOldDAO : DBConnection
//    {
//        private static readonly string dbBatchTableName = "product_batch";


//        //private static ProductBatch Select(string localCode)
//        //{
//        //    string sql = string.Format("SELECT * FROM {0} WHERE local_code = '{1}'", dbTableName, localCode);
//        //    var table = ExecuteReader(sql);
//        //    return table.Count != 0 ? ConvertToBatchDTO(table[table.Count - 1]) : null;
//        //}
        

//        public static int GetBatchId(string localCode)
//        {
//            if (string.IsNullOrEmpty(localCode)) { return 0; }
//            string sql = string.Format("SELECT id FROM {0} WHERE local_code = '{1}'", dbBatchTableName, localCode);
//            return Convert.ToInt16(ExecuteScalar(sql));
//        }

//        public static int GetProductIdFromBatchId(int batchId)
//        {
//            string sql = string.Format("SELECT product_id FROM {0} WHERE id = {1}", dbBatchTableName, batchId);
//            return Convert.ToInt16(ExecuteScalar(sql));
//        }

//        public static int GetProductIdFromLocalCode(string localCode)
//        {
//            if (string.IsNullOrEmpty(localCode)) { return 0; }
//            string sql = string.Format("SELECT product_id FROM {0} WHERE local_code = '{1}'", dbBatchTableName, localCode);
//            return Convert.ToInt16(ExecuteScalar(sql));
//        }

//        private static bool Update(ProductBatch e)
//        {
//            string sql = string.Format("UPDATE {0} SET " +
//                "manufacture_date = '{2}' " +
//                "sale_unit_price = {3}, " +
//                "sale_subunit_price = {4} " +
//                " WHERE id = {1}", dbTableName, e.Id, 
//                e.ManufactureDate.ToString("yyyy-MM-dd"), 
//                e.SaleUnitPrice, 
//                e.SaleSubunitPrice);
//            return ExecuteNonQuery(sql) != -1;
//        }
//    }
//}