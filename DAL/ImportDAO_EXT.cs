using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public  partial class ImportDAO : DBConnection
    {
        public static Dictionary<int, double> Expense()
        {
            string sql = String.Format(
                "SELECT SQL_NO_CACHE DATE_FORMAT(time_init,'%d'), SUM(total_amount) " +
                "FROM {0} " +
                "WHERE EXTRACT(YEAR_MONTH FROM time_init) = EXTRACT(YEAR_MONTH FROM CURRENT_DATE) " +
                "GROUP BY DATE(time_init) " +
                "ORDER BY DATE(time_init)", dbViewName);

            var rs = new Dictionary<int, double>();
            foreach (var row in ExecuteReader(sql))
                rs.Add(int.Parse(row[0].ToString()), double.Parse(row[1].ToString()));

            return rs;
        }

        public static int SumByProduct(int proId)
        {
            string sql = String.Format(
                "SELECT SUM(number) FROM import_detail " +
                "WHERE product_id = {1}", dbTableName, proId);
            return Convert.ToInt16(ExecuteScalar(sql));
        }

        public static int CountBySupplier(int supId)
        {
            string sql = String.Format(
               "SELECT COUNT(id) FROM {0} " +
               "WHERE supplier_id = {1}", dbTableName, supId);
            return Convert.ToInt16(ExecuteScalar(sql));
        }

        public static List<ImportInvoice> SelectOnSupplier(int supId)
        {
            string sql = string.Format(
                "SELECT * FROM {0} " +
                "WHERE supplier_id = {1}", dbViewName,supId);
            var table = ExecuteReader(sql);
            var list = new List<ImportInvoice>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }
    
    }
}
