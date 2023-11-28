using BLL;
using DTO;
using iText.IO.Codec;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormBuy : Form
    {
        private void ReloadTable(List<OrderProduct> list)
        {
            table.Rows.Clear();
            int i = 1;
            foreach (var item in list)
            {
                table.Rows.Add(
                    i++,
                    item.Barcode,
                    item.Name,
                    item.Category,
                    item.Unit,
                    item.CurrentImportPrice,
                    item.Number
                );
            }
            table.CurrentCell = null;
        }

        private void FormBuy_Load(object sender, System.EventArgs e)
        {
            chosen.Rows.Clear();
            ReloadTable(ProductBUS.SearchOrderProducts(""));
        }

        private void inpSearch_TextChanged(object sender, System.EventArgs e)
        {
            ReloadTable(ProductBUS.SearchOrderProducts(inpSearch.Text));
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            for (int i = 0; i < chosen.Rows.Count; i++)
                if (chosen.Rows[i].Cells["cCode"].Value.ToString()
                    .Contains(table.Rows[e.RowIndex].Cells["code"].Value.ToString()))
                {
                    int.TryParse(chosen.Rows[i].Cells["number"].Value.ToString(), out int num);
                    chosen.Rows[i].Cells["number"].Value = num + 1;
                    return;
                }

            chosen.Rows.Add(
                chosen.Rows.Count + 1,
                table.Rows[e.RowIndex].Cells["code"].Value,
                table.Rows[e.RowIndex].Cells["name"].Value,
                table.Rows[e.RowIndex].Cells["category"].Value,
                table.Rows[e.RowIndex].Cells["unit"].Value,
                1, "x");
        }

        private void chosen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 
            if (e.ColumnIndex != 6) return;

            chosen.Rows.RemoveAt(e.RowIndex);
        }

        private void empty_Click(object sender, System.EventArgs e)
        {
            chosen.Rows.Clear();
            chosen.CurrentCell = null;
        }

        private void print_Click(object sender, System.EventArgs e)
        {
            // code here
        }

    }
}
