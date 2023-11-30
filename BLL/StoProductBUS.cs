using ClosedXML.Excel;
using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public partial class ProductBUS
    {
        public static List<StoProduct> SelectAllStoProduct()
            => ProductDAO.SelectAllStoProduct();

        public static List<StoProduct> SearchOnCategory(int cateId)
            => ProductDAO.SearchOnCategory(cateId);

        public static List<StoProduct> Search(List<StoProduct> list, string condition)
        {
            var rs = new List<StoProduct>();
            foreach (var item in list)
            {
                if (item.ToString().Contains(condition))
                    rs.Add(item);
            }
            return rs;
        }

        public static List<ProductBatch> GetBatches(int productId, bool avaiOnly)
            => ProductDAO.SelectProductBatch(productId, avaiOnly);

        public static bool ExportForRetail(int id, int cap, int num)
        {
            if (num > ProductDAO.GetCurrentNumber(id))
                return false;
            return ProductDAO.ExportForRetail(id, cap, num);
        }

        public static void ExportExcel(string path)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã vạch");
            dt.Columns.Add("Tên");
            dt.Columns.Add("Ngành hàng");
            dt.Columns.Add("ĐV nhập");
            dt.Columns.Add("ĐVT");
            dt.Columns.Add("SL nhập");
            dt.Columns.Add("SL xuất");
            dt.Columns.Add("Tồn kho");

            int i = 0;
            var list = ProductDAO.SelectAllStoProduct();
            foreach (var item in list)
            {
                dt.Rows.Add(++i, item.Barcode, item.Name, item.Category.Name, item.Unit, item.ImportNumber, item.NumberSoldOut, item.TotalNumber);
            }

            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dt, "ImportFail");
            wb.SaveAs(@"..\..\..\documents\" + path);
        }
    }
}