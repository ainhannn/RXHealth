using BLL;
using DAL;
using DTO;
using iText.IO.Codec;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Data;
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

        private void download_Click(object sender, System.EventArgs e)
        {
            save("order-drug.xlsx");
            Xls.Download("order-drug.xlsx");
        }

        private void print_Click(object sender, System.EventArgs e)
        {
            save("order-drug.xlsx");
            Xls.Print("order-drug.xlsx");
        }

        private void save(string path)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã vạch");
            dt.Columns.Add("Tên");
            dt.Columns.Add("Ngành hàng");
            dt.Columns.Add("ĐV nhập");
            dt.Columns.Add("SL đặt");

            for (int i = 0; i < chosen.Rows.Count; i++)
            {
                dt.Rows.Add(
                    chosen.Rows[i].Cells[0].Value,
                    chosen.Rows[i].Cells[1].Value,
                    chosen.Rows[i].Cells[2].Value,
                    chosen.Rows[i].Cells[3].Value,
                    chosen.Rows[i].Cells[4].Value,
                    chosen.Rows[i].Cells[5].Value);
            }

            Workbook workbook = new Workbook();
            Worksheet sheet = workbook.Worksheets[0];

            sheet.InsertDataTable(dt, true, 1, 1);
            workbook.SaveToFile(@"..\..\..\documents\" + path, FileFormat.Version2016);
        }
    }
}
