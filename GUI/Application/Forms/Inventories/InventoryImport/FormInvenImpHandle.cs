using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormInvenImp : Form
    {
        private void ReloadForm()
        {
            inpDate.ResetText();
            inpProvi.ResetText();
            table.Rows.Clear();
        }

        private void FormInvenImp_Load(object sender, EventArgs e)
        {
            inpStaff.Text = StaffBLL.getNickName(LoginForm.Id);
        }

        private void table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // code here
        }

        private void upload_Click(object sender, EventArgs e)
        {
            // code here
        }

        private void save_Click(object sender, EventArgs e)
        {
            var invoice = new ImportInvoice()
            {
                StaffId = LoginForm.Id,
                SupplierId = 0
            };

            foreach (var row in table.Rows)
            {
                try
                {
                    var item = new ImportDetail();
                    // code here
                    invoice.AddDetail(item);
                } catch { continue; }
            }

            if (ImportBUS.Insert(invoice))
            {
                MessageBox.Show("Nhập thành công!");
                ReloadForm();
            }
            else
                MessageBox.Show("Có lỗi xảy ra! Vui lòng kiểm tra lại!");
        }
    }
}
