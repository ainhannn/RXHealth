using System;
using System.Collections.Generic;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public  class OrderDAO : DBConnection
    {
        private static string dbTableName = "order_form";

        private static OrderForm ConvertToFormDTO(List<object> row)
        {
            try 
            {
                OrderForm result = new OrderForm(Convert.ToInt16(row[0]), Convert.ToString(row[1]))
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
        
        public static List<OrderForm> SelectAllForm()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<OrderForm>();
            foreach (var row in table)
            {
                list.Add(ConvertToFormDTO(row));
            }
            return list;
        }

        public static OrderForm SelectForm(int id)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE id = {1}", dbTableName, id);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToFormDTO(table[table.Count - 1]) : null;
        }
        public static List<OrderDetail> SelectDetails(int formId)
        {
            string sql = string.Format("SELECT product_id,number FROM order_detail WHERE order_id={0}", formId);
            var table = ExecuteReader(sql);
            var list = new List<OrderDetail>();
            foreach (var row in table)
            {
                Product p = ProductDAO.GetInformation(Convert.ToInt16(row[0]));
                OrderDetail detail = new OrderDetail()
                {
                    Barcode = p.Barcode,
                    Name = p.Name,
                    Unit = p.Unit,
                    Number = Convert.ToInt16(row[1])
                };
                list.Add(detail);
            }
            return list;
        }
        public static bool Insert(OrderForm e)
        {
            if (Open())
            {
                var trans = conn.BeginTransaction();
                var cmd = conn.CreateCommand();
                cmd.Transaction = trans;

                try
                {
                    cmd.CommandText =
                        "INSERT INTO order_form(date_time,staff_id,provider_id) " +
                        "VALUES (@date_time,@staff_id,@provider_id)";
                    cmd.Parameters.AddWithValue("@date_time", e.DateInit);
                    cmd.Parameters.AddWithValue("@staff_id", e.StaffId);
                    cmd.Parameters.AddWithValue("@provider_id", e.Provider.Id);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText =
                        "SELECT auto_increment FROM information_schema.tables WHERE table_name='order_form'";
                    int id = (int)cmd.ExecuteScalar()-1;

                    foreach (var i in e.Details)
                    {
                        cmd.CommandText = "INSERT INTO order_detail VALUES (@order_id,@product_id,@number)";
                        cmd.Parameters.AddWithValue("@order_id", id);
                        cmd.Parameters.AddWithValue("@product_id", ProductDAO.GetProductId(i.Barcode));
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
