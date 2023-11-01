using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class ProductBatchDAO : DBConnection
    {
        private static readonly string dbTableName = "product_batch";
        private static ProductBatch ConvertToDTO(List<object> row)
        { //0:id, 1:local_code, 2:import_invoice_id, 3:product_id, 4: mamufacture_date, 5:number, 6:subunit_number, 7:sale_unit_price, 8:sale_subunit_price
            try
            {
                ProductBatch obj = new ProductBatch(Convert.ToInt16(row[0]), Convert.ToString(row[1]))
                {
                    ManufactureDate = Convert.ToDateTime(row[4]),
                    Number = Convert.ToInt16(row[5]),
                    NumberSubunit = Convert.ToInt16(row[6]),
                    SaleUnitPrice = (float)row[7],
                    SaleSubunitPrice = (float)row[8]
                };
                //var impIV = ImportInvoiceDAO.Select(Convert.ToInt16(row[2])),
                string barcode = ProductInfoDAO.Select(Convert.ToInt16(row[3])).Barcode;
                var impIV = new ImportInvoice();
                obj.ImportDate = impIV.DateInit;
                foreach (var item in impIV.Details) 
                {
                    if (item.Barcode.Equals(barcode))
                    {
                        obj.ImportUnitPrice = item.UnitPrice;
                        break;
                    }
                }
                obj.Provider = impIV.Provider;

                return obj;
            } catch { return null; }
        }

        public static List<ProductBatch> SelectAll()
        {
            string sql = string.Format("SELECT * FROM {0}", dbTableName);
            var table = ExecuteReader(sql);
            var list = new List<ProductBatch>();
            foreach (var row in table) 
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static List<ProductBatch> Select(int productId)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE product_id = {1}", dbTableName, productId);
            var table = ExecuteReader(sql);
            var list = new List<ProductBatch>();
            foreach (var row in table)
            {
                list.Add(ConvertToDTO(row));
            }
            return list;
        }

        public static ProductBatch Select(string localCode)
        {
            string sql = string.Format("SELECT * FROM {0} WHERE localCode = '{1}'", dbTableName, localCode);
            var table = ExecuteReader(sql);
            return table.Count != 0 ? ConvertToDTO(table[table.Count - 1]) : null;
        }

        public static bool Update(ProductBatch e)
        {
            string sql = string.Format("UPDATE SET " +
                "manufacture_date = '{2}' " +
                "sale_unit_price = {3}, " +
                "sale_subunit_price = {4} " +
                "FROM {0} WHERE id = {1}", dbTableName, e.Id, 
                e.ManufactureDate.ToString("yyyy-MM-dd"), 
                e.SaleUnitPrice, 
                e.SaleSubunitPrice);
            return ExecuteNonQuery(sql) != -1;
        }
    }
}