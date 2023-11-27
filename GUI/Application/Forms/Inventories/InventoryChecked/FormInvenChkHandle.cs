using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormInvenChk : Form
    {
        public static List<StoProduct> list = new List<StoProduct>();
        private static int cateId = 0;
        private void ReloadTable()
        {
            table.Rows.Clear();
            int i = 1;
            foreach (var item in list)
            {
                table.Rows.Add(
                    i++,
                    item.Barcode,
                    item.Name,
                    item.Category.Name,
                    item.Unit,
                    item.ImportNumber,
                    item.NumberSoldOut,
                    item.TotalNumber
                );
            }
            table.CurrentCell = null;
        }

        private void FormInvenChk_Load(object sender, EventArgs e)
        {
            list = ProductBUS.SelectAllStoProduct();
            ReloadTable();
        }

        private void table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Int16.TryParse(table.Rows[e.RowIndex].Cells["id"].Value.ToString(), out var listIndex); // lay gia tri STT
            if (listIndex * list.Count != 0) // ca 2 != 0
            {
                new FormDetails(list[listIndex - 1]).ShowDialog();
            }

            ReloadTable();
        }

        private void comboBoxFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            cateId = comboBoxFilter.SelectedIndex;
            list = cateId != 0 ? ProductBUS.SearchOnCategory(cateId) : ProductBUS.SelectAllStoProduct();
            ReloadTable();
        }

        private void inpSearch_TextChanged(object sender, EventArgs e)
        {
            list = ProductBUS.Search(cateId != 0 ? ProductBUS.SearchOnCategory(cateId) : ProductBUS.SelectAllStoProduct(), inpSearch.Text);
            ReloadTable();
        }

        private void download_Click(object sender, EventArgs e)
        {
            // code here
        }
    }
}
