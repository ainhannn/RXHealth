using System;
using System.Collections.Generic;
using DTO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace DAL
{
    public partial class SaleDAO : DBConnection
    {
        public static int CountByCustomer(int cusId)
        {
            string sql = String.Format(
               "SELECT COUNT(id) FROM {0} " +
               "WHERE customer_id = {1}", dbViewName,cusId);
            return Convert.ToInt16(ExecuteScalar(sql));
        }

        public static List<SaleInvoice> GetOnCustomer(int cusId)
        {
            string sql = string.Format(
                "SELECT * FROM {0} " +
                "WHERE customer_id = {1}", dbViewName,cusId);
            var table = ExecuteReader(sql);
            var list = new List<SaleInvoice>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }
    }
}