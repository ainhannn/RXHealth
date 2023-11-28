using System;
using System.Collections.Generic;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public  class ExportDAO : DBConnection
    {
        private static string dbTableName = "export_invoice";

        private static ExportInvoice ConvertToFormDTO(List<object> row)
        {
            try 
            {
                ExportInvoice result = new ExportInvoice(Convert.ToInt16(row[0]), Convert.ToString(row[1]))
                {
                    DateInit = Convert.ToDateTime(row[2]),
                    StaffId = Convert.ToInt16(row[3]),
                    StaffNickName = StaffDAO.Select(Convert.ToInt16(row[3])).Nickname
                };
                return result;
            }
            catch { return null; }
        }
        
        public static List<ExportInvoice> SelectAllForm()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<ExportInvoice>();
            foreach (var row in table)
            {
                list.Add(ConvertToFormDTO(row));
            }
            return list;
        }

        public static ExportInvoice SelectForm(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1}", dbTableName, id);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToFormDTO(table[table.Count - 1]) : null;
        }

        public static List<ExportDetail> SelectDetails(int formId)
        {
            string sql = string.Format(
                "SELECT product_batch_id,number,reason " +
                "FROM export_detail WHERE export_invoice_id={0}", formId);
            var table = ExecuteReader(sql);
            var list = new List<ExportDetail>();
            foreach (var row in table)
            {
                int batchId = Convert.ToInt16(row[0]);
                var p = ProductDAO.GetInformation(ProductDAO.GetProductIdFromBatchId(batchId));
                ExportDetail detail = new ExportDetail()
                {
                    LocalCode = ProductDAO.GetLocalCode(batchId),
                    Name = p.Name,
                    Unit = p.Unit,
                    Number = Convert.ToInt16(row[1]),
                    Reason = Convert.ToString(row[2])
                };
                list.Add(detail);
            }
            return list;
        }
        public static bool Insert(ExportInvoice e)
        {
            if (Open())
            {
                var trans = conn.BeginTransaction();
                var cmd = conn.CreateCommand();
                cmd.Transaction = trans;

                try
                {
                    cmd.CommandText =
                        "INSERT INTO export_invoice(date_time,staff_id) " +
                        "VALUES (@date_time,@staff_id)";
                    cmd.Parameters.AddWithValue("@date_time", e.DateInit);
                    cmd.Parameters.AddWithValue("@staff_id", e.StaffId);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText =
                        "SELECT auto_increment FROM information_schema.tables WHERE table_name='export_invoice'";
                    int id = (int)cmd.ExecuteScalar()-1;

                    foreach (var i in e.Details)
                    {
                        cmd.CommandText = 
                            "INSERT INTO export_detail " +
                            "VALUES (@export_invoice_id,@product_batch_id,@number,@reason)";
                        cmd.Parameters.AddWithValue("@export_invoice_id", id);
                        cmd.Parameters.AddWithValue("@product_batch_id", ProductDAO.GetBatchId(i.LocalCode));
                        cmd.Parameters.AddWithValue("@number", i.Number);
                        cmd.Parameters.AddWithValue("@reason", i.Reason);
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
