using BLL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormInvoice : Form
    {
        private void FormInvoice_Load(object sender, EventArgs e)
        {
            LoadIntoImportTable();
            LoadIntoSaleTable();
        }

        private void LoadIntoImportTable()
        {
            tableImp.Rows.Clear();
            int i = 1;
            foreach (var item in ImportBUS.SelectAll())
            {
                tableImp.Rows.Add(i++, item.Code, item.DateInit, item.StaffNickName, item.SupplierName, item.TotalAmount);
            }
        }

        private void tableImp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string impCode = tableImp.Rows[e.RowIndex].Cells["code"].Value.ToString();
                ImportBUS.Select(impCode);
                // code here hiện detail nếu có
            }
        }

        private void LoadIntoSaleTable()
        {
            tableSale.Rows.Clear();
            int i = 1;
            foreach (var item in SaleBUS.SelectAll())
            {
                tableSale.Rows.Add(i++, item.Code, item.DateInit, item.StaffNickName, item.CustomerName, item.TotalAmount);
            }
        }

        private void tableSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string sCode = tableSale.Rows[e.RowIndex].Cells["saleCode"].Value.ToString();
                ImportBUS.Select(sCode);
                // code here hiện detail nếu có
            }
        }
    }
}
