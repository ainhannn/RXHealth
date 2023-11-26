using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public  partial class ImportDAO : DBConnection
    {
        private static string dbTableName = "import_invoice";
        private static string dbViewName = "review_import_invoice";


        private static ImportInvoice ConvertToDTO(List<object> row)
        {
            try 
            {
                Int16.TryParse(row[0].ToString(), out var id);
                var code = row[1].ToString();
                DateTime.TryParse(row[2].ToString(), out var dateInit);
                Int16.TryParse(row[3].ToString(), out var staffId);
                var staff = StaffDAO.Select(staffId);
                string staffNickname = staff != null ? staff.Nickname : "";
                Int16.TryParse(row[4].ToString(), out var supplierId);
                var supplier = SupplierDAO.Select(staffId);
                string supplierName = supplier != null ? supplier.Name : "";
                Double.TryParse(row[5].ToString(), out var totalAmount);

                return new ImportInvoice(id, code)
                {
                    DateInit = dateInit,
                    StaffId = staffId,
                    StaffNickName = staffNickname,
                    SupplierId = supplierId,
                    SupplierName = supplierName,
                    TotalAmount = totalAmount
                };
            }
            catch { return null; }
        }

        public static List<ImportInvoice> SelectAllForm()
        {
            string sql = string.Format("SELECT * FROM {0}", dbViewName);
            var table = ExecuteReader(sql);
            var list = new List<ImportInvoice>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static ImportInvoice SelectForm(string code)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE code = '{1}' LIMIT 1", dbViewName, code);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[0]) : null;
        }

        public static List<ImportDetail> SelectDetails(int formId)
        {
            string sql = string.Format(
                "SELECT barcode,name,mfg_date,exp_date,unit,number,import_price " +
                "FROM import_detail WHERE import_invoice_id={0}", formId);
            var table = ExecuteReader(sql);
            var list = new List<ImportDetail>();
            foreach (var row in table)
            {
                DateTime.TryParse(row[2].ToString(), out var mfg);
                DateTime.TryParse(row[3].ToString(), out var exp);
                ImportDetail detail = new ImportDetail()
                {
                    Barcode = row[0].ToString(),
                    Name = row[1].ToString(),
                    MFGDate = mfg,
                    EXPDate = exp,
                    Unit = row[4].ToString(),
                    Number = Convert.ToInt16(row[5]),
                    ImportPrice = (double)row[3]
                };

                list.Add(detail);
            }
            return list;
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
                        "INSERT INTO import_invoice(staff_id,supplier_id) " +
                        "VALUES (@staff_id,@supplier_id)";
                    cmd.Parameters.AddWithValue("@staff_id", e.StaffId);
                    cmd.Parameters.AddWithValue("@supplier_id", e.SupplierId);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText =
                        "SELECT auto_increment FROM information_schema.tables " +
                        "WHERE table_name='import_invoice'";
                    int id = (int)cmd.ExecuteScalar()-1;

                    foreach (var i in e.Details)
                    {
                        cmd.CommandText = 
                            "INSERT INTO import_detail " +
                            "VALUES (@import_invoice_id,@product_id,@barcode,@name,@mgf_date,@exp_date,@unit,@number,@import_price)";
                        cmd.Parameters.AddWithValue("@import_invoice_id", id);
                        cmd.Parameters.AddWithValue("@product_id", ProductDAO.GetProductId(i.Barcode));
                        cmd.Parameters.AddWithValue("@barcode", i.Barcode);
                        cmd.Parameters.AddWithValue("@name", i.Name);
                        cmd.Parameters.AddWithValue("@mfg_date", i.MFGDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@exp_date", i.EXPDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@unit", i.Unit);
                        cmd.Parameters.AddWithValue("@number", i.Number);
                        cmd.Parameters.AddWithValue("@import_price", i.ImportPrice);
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
