using System;
using System.Collections.Generic;
using DTO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace DAL
{
    public partial class SaleDAO : DBConnection
    {
        private static readonly string dbTableName = "sale_invoice";
        private static readonly string dbViewName = "review_sale_invoice";

        private static SaleInvoice ConvertToDTO(List<object> row)
        {
            try
            {
                Int16.TryParse(row[0].ToString(), out var id);
                var code = row[1].ToString();
                DateTime.TryParse(row[2].ToString(), out var dateInit);
                Int16.TryParse(row[3].ToString(), out var staffId);
                var staff = StaffDAO.Select(staffId);
                string staffNickname = staff != null ? staff.Nickname : "";
                Int16.TryParse(row[4].ToString(), out var customerId);
                var customer = CustomerDAO.Select(customerId);
                string customerName = customer != null ? customer.Name : "";
                Double.TryParse(row[5].ToString(), out var totalAmount);
                Int16.TryParse(row[6].ToString(), out var point);

                return new SaleInvoice(id, code)
                {
                    DateInit = dateInit,
                    StaffId = staffId,
                    StaffNickName = staffNickname,
                    CustomerId = customerId,
                    CustomerName = customerName,
                    TotalAmount = totalAmount,
                    Point = point
                };
            }
            catch { return null; }
        }

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