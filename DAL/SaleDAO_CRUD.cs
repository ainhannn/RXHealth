using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public  partial class SaleDAO : DBConnection
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

        public static List<SaleInvoice> SelectAllForm()
        {
            string sql = string.Format("SELECT * FROM {0}", dbViewName);
            var table = ExecuteReader(sql);
            var list = new List<SaleInvoice>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static SaleInvoice SelectForm(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1} LIMIT 1", dbViewName, id);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[0]) : null;
        }

        public static List<SaleDetail> SelectDetails(int formId)
        {
            string sql = string.Format(
                "SELECT name, unit, unit_price, number " +
                "FROM sale_detail WHERE sale_invoice_id={0}", formId);

            var table = ExecuteReader(sql);
            var list = new List<SaleDetail>();
            foreach (var row in table)
            {
                SaleDetail detail = new SaleDetail()
                {
                    Name = row[0].ToString(),
                    Unit = row[1].ToString(),
                    UnitPrice = (double)row[2],
                    Number = Convert.ToInt16(row[3])
                };

                list.Add(detail);
            }
            return list;
        }

        public static bool Insert(SaleInvoice e)
        {
            if (Open())
            {
                var trans = conn.BeginTransaction();
                var cmd = conn.CreateCommand();
                cmd.Transaction = trans;

                try
                {
                    cmd.CommandText =
                        "INSERT INTO sale_invoice(staff_id,customer_id,point) " +
                        "VALUES (@staff_id,@customer_id,@point)";
                    cmd.Parameters.AddWithValue("@staff_id", e.StaffId);
                    cmd.Parameters.AddWithValue("@customer_id", e.CustomerId);
                    cmd.Parameters.AddWithValue("@point", e.Point);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText =
                        "SELECT auto_increment FROM information_schema.tables " +
                        "WHERE table_name='sale_invoice'";
                    int id = Convert.ToInt16(cmd.ExecuteScalar().ToString())-1;

                    foreach (var i in e.Details)
                    {
                        cmd.CommandText = 
                            "INSERT INTO sale_detail " +
                            "VALUES (@sale_invoice_id,@product_id,@name,@unit,@unit_price,@number)";
                        cmd.Parameters.AddWithValue("@sale_invoice_id", id);
                        cmd.Parameters.AddWithValue("@product_id", ProductDAO.GetProductId(i.Barcode));
                        cmd.Parameters.AddWithValue("@name", i.Name);
                        cmd.Parameters.AddWithValue("@unit", i.Unit);
                        cmd.Parameters.AddWithValue("@unit_price", i.UnitPrice);
                        cmd.Parameters.AddWithValue("@number", i.Number);
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
                finally { Close(); }
            }
            return false;
        }
    }
}
