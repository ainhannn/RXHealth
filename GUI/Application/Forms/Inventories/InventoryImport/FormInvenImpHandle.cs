using BLL;
using DAL;
using DTO;
using Google.Protobuf;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormInvenImp : Form
    {
        private void RefreshTotal()
        {
            double rs = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                double.TryParse(table.Rows[i].Cells["amount"].Value.ToString(), out double prc);
                rs += prc;
            }
            inpTotal.Text = rs.ToString();
        }

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
            if (e.RowIndex < 0 || e.ColumnIndex < 5) { return; }
            
            int.TryParse(table.Rows[e.RowIndex].Cells["number"].Value.ToString(), out int num);
            double.TryParse(table.Rows[e.RowIndex].Cells["price"].Value.ToString(), out double prc);
            var amt = num * prc;

            table.Rows[e.RowIndex].Cells["amount"].Value = amt.ToString();
            RefreshTotal();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            // code here
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0) {  return; }

            var invoice = new ImportInvoice()
            {
                StaffId = LoginForm.Id,
                SupplierId = 0
            };

            for (int i = 0; i < table.Rows.Count; i++)
            {
                try
                {
                    if
                    (
                        !int.TryParse(table.Rows[i].Cells["number"].Value.ToString(), out int num) ||
                        !double.TryParse(table.Rows[i].Cells["price"].Value.ToString(), out double prc) ||
                        !DateTime.TryParse(table.Rows[i].Cells["mfg_date"].Value.ToString(), out var mfg) ||
                        !DateTime.TryParse(table.Rows[i].Cells["exp_date"].Value.ToString(), out var exp)
                    )
                        continue; // ignore which row has wrong format

                    invoice.AddDetail(new ImportDetail
                    {
                        Barcode = table.Rows[i].Cells["code"].Value.ToString(),
                        Name = table.Rows[i].Cells["name"].Value.ToString(),
                        Unit = table.Rows[i].Cells["unit"].Value.ToString(),
                        Number = num,
                        ImportPrice = prc,
                        MFGDate = mfg,
                        EXPDate = exp
                    });
                } catch { continue; }
            }

            if (ImportBUS.Insert(invoice))
            {
                int i = 0;
                foreach (var item in invoice.Details)
                {
                    while (!item.Barcode.Contains(table.Rows[i].Cells["code"].Value.ToString()))
                        i++;
                    if (item.Barcode.Contains(table.Rows[i].Cells["code"].Value.ToString()))
                        table.Rows.RemoveAt(i++);
                }

                MessageBox.Show("Nhập thành công!");
                ReloadForm();
            }
            else
                MessageBox.Show("Có lỗi xảy ra! Vui lòng kiểm tra lại!");
        }
    }
}
