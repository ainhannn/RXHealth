using System;
using System.Collections.Generic;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public  class ImportDAO : DBConnection
    {
        private static string dbTableName = "import_invoice";

        private static ImportInvoice ConvertToFormDTO(List<object> row)
        {
            try 
            {
                ImportInvoice result = new ImportInvoice(Convert.ToInt16(row[0]), Convert.ToString(row[1]))
                {
                    DateInit = Convert.ToDateTime(row[2]),
                    StaffId = Convert.ToInt16(row[3]),
                    StaffNickName = StaffDAO.Select(Convert.ToInt16(row[3])).Nickname,
                    Provider = ProviderDAO.Select(Convert.ToInt16(row[4]))
                };
                return result;
            }
            catch { return null; }
        }
        
        public static List<ImportInvoice> SelectAllForm()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<ImportInvoice>();
            foreach (var row in table)
            {
                list.Add(ConvertToFormDTO(row));
            }
            return list;
        }

        public static ImportInvoice SelectForm(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1}", dbTableName, id);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToFormDTO(table[table.Count - 1]) : null;
        }

        public static List<ImportDetail> SelectDetails(int formId)
        {
            string sql = string.Format(
                "SELECT product_id,order_number,actual_number,import_unit_price " +
                "FROM import_detail WHERE import_invoice_id={0}", formId);
            var table = ExecuteReader(sql);
            var list = new List<ImportDetail>();
            foreach (var row in table)
            {
                ProductInfo p = ProductDAO.GetInformation(Convert.ToInt16(row[0]));
                ImportDetail detail = new ImportDetail()
                {
                    Barcode = p.Barcode,
                    Name = p.Name,
                    Unit = p.Unit,
                    NumberOrder = Convert.ToInt16(row[1]),
                    NumberActual = Convert.ToInt16(row[2]),
                    UnitPrice = (float)row[3]
                };
                list.Add(detail);
            }
            return list;
        }

        public static ImportDetail SelectDetail(int formId, int productId)
        {
            string sql = string.Format(
                "SELECT order_number,actual_number,import_unit_price " +
                "FROM import_detail WHERE import_invoice_id={0} AND product_id={1} LIMIT 1", formId, productId);
            var row = ExecuteReader(sql)[0];
            ProductInfo p = ProductDAO.GetInformation(productId);
            ImportDetail detail = new ImportDetail()
            {
                Barcode = p.Barcode,
                Name = p.Name,
                Unit = p.Unit,
                NumberOrder = Convert.ToInt16(row[0]),
                NumberActual = Convert.ToInt16(row[1]),
                UnitPrice = (float)row[2]
            };
            return detail;
        }
        public static bool Insert(ImportInvoice e)
        {
            if (Open())
            {
                var trans = conn.BeginTransaction();
                var cmd = conn.CreateCommand();
                cmd.Transaction = trans;

                try
                {
                    cmd.CommandText =
                        "INSERT INTO import_invoice(date_time,staff_id,provider_id) " +
                        "VALUES (@date_time,@staff_id,@provider_id)";
                    cmd.Parameters.AddWithValue("@date_time", e.DateInit);
                    cmd.Parameters.AddWithValue("@staff_id", e.StaffId);
                    cmd.Parameters.AddWithValue("@provider_id", e.Provider.Id);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText =
                        "SELECT auto_increment FROM information_schema.tables WHERE table_name='import_invoice'";
                    int id = (int)cmd.ExecuteScalar()-1;

                    foreach (var i in e.Details)
                    {
                        cmd.CommandText = 
                            "INSERT INTO import_detail " +
                            "VALUES (@import_invoice_id,@product_id,@order_number,@actual_number,@import_unit_price)";
                        cmd.Parameters.AddWithValue("@order_id", id);
                        cmd.Parameters.AddWithValue("@product_id", ProductDAO.GetProductId(i.Barcode));
                        cmd.Parameters.AddWithValue("@order_number", i.NumberOrder);
                        cmd.Parameters.AddWithValue("@actual_number", i.NumberActual);
                        cmd.Parameters.AddWithValue("@import_unit_price", i.UnitPrice);
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
