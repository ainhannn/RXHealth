using BLL;
using DAL;
using DTO;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCateDrug : Form
    {
        public static List<CateProduct> list = new List<CateProduct>();
        private static Dictionary<string, string> conditions = new Dictionary<string, string>();

        private void ReloadTable()
        {
            table.Rows.Clear();
            int i = 1;
            foreach (var item in list) 
            {
                table.Rows.Add(
                    i++,
                    item.Stack,
                    item.Barcode,
                    item.Name,
                    item.Category.Name,
                    item.Unit,
                    item.CurrentImportPrice,
                    item.Saleprice,
                    item.RetailUnit,
                    item.RetailSaleprice,
                    item.IsOnSale ? "" : "x",
                    false
                );
            }
            table.CurrentCell = null;
        }

        private void FormCateDrug_Load(object sender, EventArgs e)
        {
            list = ProductBUS.SelectAllCateProduct();
            ReloadTable();
        }

        private void inpSearch_TextChanged(object sender, EventArgs e)
        {
            list = ProductBUS.Search(inpSearch.Text);
            ReloadTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conditions.Clear();
            if (!string.IsNullOrEmpty(inpName.Text))
                conditions.Add("name",inpName.Text);
            if (!string.IsNullOrEmpty(inpUnit.Text))
                conditions.Add("unit", inpUnit.Text);
            switch (inpCate.Text)
            {
                case "Thuốc kê đơn":
                    conditions.Add("category_id", "1");
                    break;
                case "Thuốc không kê đơn":
                    conditions.Add("category_id", "2");
                    break;
                case "Thực phẩm chức năng":
                    conditions.Add("category_id", "3");
                    break;
                case "Chăm sóc cá nhân":
                    conditions.Add("category_id", "4");
                    break;
                case "Dụng cụ y tế":
                    conditions.Add("category_id", "5");
                    break;
                case "Thiết bị y tế":
                    conditions.Add("category_id", "6");
                    break;
                default: 
                    break;
            }
            if (!string.IsNullOrEmpty(inpRUnit.Text))
                conditions.Add("retail_unit", inpRUnit.Text);
            if (!string.IsNullOrEmpty(inpPriceMin.Text))
                conditions.Add("price_min", inpPriceMin.Text);
            if (!string.IsNullOrEmpty(inpPriceMax.Text))
                conditions.Add("price_max", inpPriceMax.Text);
            if (isStopped.Checked)
                conditions.Add("is_on_sale", "0");

            list = ProductBUS.AdvancedSearch(conditions);
            ReloadTable();
        }

        private void table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Int16.TryParse(table.Rows[e.RowIndex].Cells["id"].Value.ToString(), out var listIndex); // lay gia tri STT
            if (listIndex*list.Count != 0) // ca 2 != 0
                new FormPDetails(list[listIndex-1]).ShowDialog();

            ReloadTable();
        }

        private void RecycleBin_Click(object sender, System.EventArgs e)
        {
            new FormPRecycleBin().ShowDialog();
            ReloadTable();
        }

        private void refresh_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (Convert.ToBoolean(table.Rows[i].Cells["selectDelete"].Value))
                {
                    Int16.TryParse(table.Rows[i].Cells["id"].Value.ToString(), out var listIndex); // lay gia tri STT
                    ProductBUS.Delete(list[listIndex - 1].Id);
                    list.RemoveAt(listIndex-1);
                }
            }
            ReloadTable();
        }

        private void insert_Click(object sender, System.EventArgs e)
        {
            new FormPDetails(null).ShowDialog();
            ReloadTable();
        }

        private void download_Click(object sender, System.EventArgs e)
        {
            ProductBUS.Save("cate-drug.xlsx");
            Xls.Download("cate-drug.xlsx");
        }

        [Obsolete]
        private void upload_Click(object sender, System.EventArgs e)
        {
            var sheet = Xls.Upload(); // get sheet[0] from file user selected 
            if (sheet == null)
            {
                MessageBox.Show("Đã xảy ra lỗi!");
                return;
            }
             
            var tb = Retreat.ReadFromSheet(sheet); // get List<List<object>> (matrix object) from sheet
            if (tb.Count < 1 || tb[0].Count != 11)
            {
                MessageBox.Show("File không hợp lệ!");
                return;
            }

            tb.RemoveAt(0); // remove title row

            var newList = ProductBUS.InsertFromObjectTable(tb); // insert to database
            if (newList.Count <= 0)
            {
                MessageBox.Show("Không có sản phẩm hợp lệ!");
                return;
            }
            
            MessageBox.Show("Tải lên thành công " + newList.Count + " sản phẩm!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list.AddRange(newList);
            ReloadTable();
        }
    }
}
