using DAL;
using DTO;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace BLL
{
    public partial class ProductBUS
    {
        public static int Count { get => ProductDAO.Count; }

        public static int GetId(string barcode)
            => ProductDAO.GetProductId(barcode);

        public static List<CateProduct> SelectAllCateProduct()
            => ProductDAO.SelectAllCateProduct();

        public static List<CateProduct> Search(string condition)
        {
            var rs = new List<CateProduct>();
            foreach (var item in SelectAllCateProduct())
            {
                if (item.ToString().Contains(condition))
                    rs.Add(item);
            }
            return rs;
        }

        public static List<CateProduct> AdvancedSearch(Dictionary<string, string> conditions)
            => ProductDAO.AdvancedSearch(conditions);

        public static int Update(CateProduct product)
        {
            if (GetId(product.Barcode) < 0)
                return 0;
            return ProductDAO.Update(product) ? 1 : -1;
        }

        public static int Insert(CateProduct product)
        {
            if (GetId(product.Barcode) > -1)
                return 0;
            if (product.Category.Id == 0)
                product.Category.Id = CategoryDAO.GetId(product.Category.Name);
            return ProductDAO.Insert(product) ? 1 : -1;
        }

        [Obsolete]
        public static List<CateProduct> InsertFromObjectTable(List<List<object>> tb)
        {
            try
            {
                var newList = new List<CateProduct>();
                foreach (var row in tb)
                {
                    try
                    {
                        var item = new CateProduct()
                        {
                            Stack = Convert.ToString(row[1]),
                            Barcode = Convert.ToString(row[2]),
                            Name = Convert.ToString(row[3]),
                            Category = new Category() { Name = Convert.ToString(row[4]) },
                            Unit = Convert.ToString(row[5]),
                            RetailUnit = Convert.ToString(row[8]),
                            ExtraInformation = Convert.ToString(row[10])
                        };

                        try { item.CurrentImportPrice = Convert.ToDouble(row[6]); } catch { }
                        try { item.Saleprice = Convert.ToDouble(row[7]); } catch { }
                        try { item.RetailSaleprice = Convert.ToDouble(row[9]); } catch { }

                        if (ProductBUS.Insert(item) == 1)
                            newList.Add(item);
                    }
                    catch { }
                }
                return newList;
            }    
            catch { return new List<CateProduct>(); }
        }

        public static int Delete(int productId)
            => ProductDAO.Delete(productId) ? 1 : -1;

        public static List<CateProduct> GetTrash()
            => ProductDAO.SelectAllTrash();

        public static bool Recover(int productId)
            => ProductDAO.Recover(productId);

        public static bool DeleteTrash(int productId)
            => ProductDAO.DeleteTrash(productId);

        public static bool EmptyTrash()
            => ProductDAO.EmptyTrash();

        public static void Save(string filename)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Ngăn chứa");
            dt.Columns.Add("Mã vạch");
            dt.Columns.Add("Tên");
            dt.Columns.Add("Ngành hàng");
            dt.Columns.Add("ĐV nhập");
            dt.Columns.Add("Giá nhập");
            dt.Columns.Add("Giá bán");
            dt.Columns.Add("ĐV lẻ");
            dt.Columns.Add("Giá bán lẻ");
            dt.Columns.Add("Mô tả");

            int i = 0;
            var list = ProductDAO.SelectAllCateProduct();
            foreach (var item in list)
            {
                dt.Rows.Add(++i, item.Stack, item.Barcode, item.Name, item.Category.Name, item.Unit, item.CurrentImportPrice, item.Saleprice, item.RetailUnit, item.RetailSaleprice, item.ExtraInformation);
            }

            Workbook workbook = new Workbook();
            Worksheet sheet = workbook.Worksheets[0];

            sheet.InsertDataTable(dt, true, 1, 1);
            workbook.SaveToFile(@"..\..\..\documents\" + filename, FileFormat.Version2016);
        }
    }
}
