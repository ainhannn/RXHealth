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
            if (ShowPhoneLabel.Text.Contains("SDT"))
            {
				MessageBox.Show("Chưa chọn khách hàng");
			}
            else
            {
				var invoice = new SaleInvoice()
				{
					StaffId = LoginForm.Id,
					CustomerId = Convert.ToInt16(FindCustomerTable.CurrentRow.Cells["Id"].Value),
					Point = Convert.ToInt16(PointLabel.Text)
				};

				for (int i = 0; i < table.Rows.Count; i++)
				{
					string barcode = table.Rows[i].Cells["Barcode1"].Value.ToString();
					string name = table.Rows[i].Cells["Name1"].Value.ToString();
					string unit = table.Rows[i].Cells["Unit1"].Value.ToString();
					double unitPrice = (double)Convert.ToDecimal(table.Rows[i].Cells["SalePrice1"].Value.ToString());
					int number = Convert.ToInt16(table.Rows[i].Cells["Number1"].Value.ToString());

					invoice.AddDetail(new SaleDetail(barcode, name, unit, unitPrice, number));
				}

				// code here: gọi bus để insert(invoice)
				SaleBUS.InsertInvoice(invoice);
				MessageBox.Show("Thành công");
			}
            

		}
	}
}
