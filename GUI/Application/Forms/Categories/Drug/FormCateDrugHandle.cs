using DTO;
using BLL;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GUI
{
    public partial class FormCateDrug : Form
    {
        private static List<CateProduct> list = new List<CateProduct>();
        private static Dictionary<string, string> conditions = new Dictionary<string, string>();


        private void ReloadTable()
        {
            list = ProductBUS.AdvancedSearch(conditions);

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
                    !item.IsOnSale,
                    false
                );
            }
            table.CurrentCell = null;
        }

        private void FormCateDrug_Load(object sender, EventArgs e)
        {
            ReloadTable();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
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

            ReloadTable();
        }

        private void table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Int16.TryParse(table.Rows[e.RowIndex].Cells["id"].Value.ToString(), out var listIndex);
            if (listIndex*list.Count != 0)
                new FormPDetails(list[listIndex-1]).ShowDialog();
            ReloadTable();
        }

        private void RecycleBin_Click(object sender, System.EventArgs e)
        {
            new FormPRecycleBin().ShowDialog();
        }
    }
}
