using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSell : Form
    {
        private void SellBtn_Click(object sender, EventArgs e)
        {
            var invoice = new SaleInvoice()
            {
                StaffId = LoginForm.Id,
                CustomerId = Convert.ToInt16(FindCustomerTable.CurrentRow.Cells["Id"].Value)
            };

            for (var i = 0; i < table.Rows.Count; i++)
            {
                var barcode = table.Rows[i].Cells["Barcode1"].Value.ToString();
                var name = table.Rows[i].Cells["Name1"].Value.ToString();
                var unit = table.Rows[i].Cells["Unit1"].Value.ToString();
                var unitPrice = (float)Convert.ToDecimal(table.Rows[i].Cells["SalePrice1"].Value.ToString());
                var number = Convert.ToInt16(table.Rows[i].Cells["Number1"].Value.ToString());

                invoice.AddDetail(new SaleDetail(barcode, name, unit, unitPrice, number));
            }

            // code here: gọi bus để insert(invoice)
            SaleBUS.InsertInvoice(invoice);
            MessageBox.Show("Thành công");

        }
    }
}