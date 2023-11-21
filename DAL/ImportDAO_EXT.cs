using System;
using System.Collections.Generic;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public  partial class ImportDAO : DBConnection
    {
        public static int CountBySupplier(int supId)
        {
            string sql = String.Format(
               "SELECT COUNT(id) FROM {0} " +
               "WHERE supplier_id = {1}", dbTableName, supId);
            return Convert.ToInt16(ExecuteScalar(sql));
        }

        public static List<ImportInvoice> GetOnSupplier(int supId)
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
