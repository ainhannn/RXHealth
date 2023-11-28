using BLL;
using DTO;
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
                ImportInvoice imp = ImportBUS.Select(impCode);
                // Check if details are found
                try
                {
                    MessageBox.Show("Thành công");
                    // Tạo một đối tượng của form SDetailsForm
                    IDetailsForm Idetails = new IDetailsForm(imp);

                    // Hiển thị form SDetailsForm
                    Idetails.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Details not found for the selected sale code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn hàng");
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
                SaleInvoice inv = SaleBUS.Select(sCode);
                // Check if details are found
                try 
                {
                    // Tạo một đối tượng của form SDetailsForm
                    SDetailsForm Sdetails = new SDetailsForm(inv);

                    // Hiển thị form SDetailsForm
                    Sdetails.Show();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Details not found for the selected sale code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn hàng");
            }
        }

    }
}
