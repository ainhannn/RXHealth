using BLL;
using DAL;
using DTO;
using Google.Protobuf;
using iText.IO.Codec;
using System;
using System.Collections.Generic;
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
                try { rs += Convert.ToDouble(table.Rows[i].Cells["amount"].Value); }
                catch { }
            }
            inpTotal.Text = rs.ToString();
        }

        private void RefreshAmount(int i)
        {
            try
            {
                table.Rows[i].Cells["amount"].Value =
                    Convert.ToInt16(table.Rows[i].Cells["number"].Value) *
                    Convert.ToDouble(table.Rows[i].Cells["price"].Value);
            }
            catch { table.Rows[i].Cells["amount"].Value = "######"; }

            RefreshTotal();
        }

        private void ReloadForm()
        {
            inpDate.ResetText();
            inpProvi.ResetText();
        }


        private void FormInvenImp_Load(object sender, EventArgs e)
        {
            inpStaff.Text = StaffBLL.getNickName(LoginForm.Id);
            inpProvi.Items.Clear();
            foreach (var sup in SupplierBUS.SelectAll())
                inpProvi.Items.Add(sup.Name);
        }


        // Table handle
        private void table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 6)
                RefreshAmount(e.RowIndex);
        }

        private void table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Cap nhat stt
            table.Rows[e.RowIndex-1].Cells["id"].Value = table.Rows.Count-1;
            
            if (table.Rows[e.RowIndex].Cells["number"].Value != null && table.Rows[e.RowIndex].Cells["price"].Value != null)
                RefreshAmount(e.RowIndex);
        }

        private void table_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RefreshTotal();

            for (int i = 0; i < table.Rows.Count - 1;)
                table.Rows[i].Cells["id"].Value = ++i;
        }


        // Button handle
        private void download_Click(object sender, EventArgs e)
        {
            // code here
        }

        private void upload_Click(object sender, EventArgs e)
        {
            // code here

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (inpProvi.SelectedIndex < 0) 
            {
                MessageBox.Show("Chưa chọn nhà cung cấp!");
                return; 
            }

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách sản phẩm trống!");
                return;
            }

            var invoice = new ImportInvoice()
            {
                StaffId = LoginForm.Id,
                SupplierId = SupplierBUS.GetId(inpProvi.Text)
            };

            for (int i = 0; i < table.Rows.Count; i++)
            {
                try
                {
                    if (table.Rows[i].Cells["code"].Value == null ||
                        table.Rows[i].Cells["name"].Value == null ||
                        table.Rows[i].Cells["unit"].Value == null ||
                        table.Rows[i].Cells["number"].Value == null ||
                        table.Rows[i].Cells["price"].Value == null)
                        continue;
                    

                    var item = new ImportDetail
                    {
                        Barcode = table.Rows[i].Cells["code"].Value.ToString(),
                        Name = table.Rows[i].Cells["name"].Value.ToString(),
                        Unit = table.Rows[i].Cells["unit"].Value.ToString(),
                        Number = Convert.ToInt16(table.Rows[i].Cells["number"].Value),
                        ImportPrice = Convert.ToDouble(table.Rows[i].Cells["price"].Value)
                    };
                    
                    if (table.Rows[i].Cells["mfg_date"].Value != null && !string.IsNullOrEmpty(table.Rows[i].Cells["mfg_date"].Value.ToString()))
                    {
                        if (Retreat.IsDateTime(table.Rows[i].Cells["mfg_date"].Value.ToString()))
                            item.MFGDate = Retreat.DateTime(table.Rows[i].Cells["mfg_date"].Value.ToString());
                        else
                            continue;
                    }
                    if (table.Rows[i].Cells["exp_date"].Value != null && !string.IsNullOrEmpty(table.Rows[i].Cells["exp_date"].Value.ToString()))
                    {
                        if (Retreat.IsDateTime(table.Rows[i].Cells["exp_date"].Value.ToString()))
                            item.EXPDate = Retreat.DateTime(table.Rows[i].Cells["exp_date"].Value.ToString());
                        else
                            continue;
                    }

                    invoice.AddDetail(item);
                } catch { continue; }
            }

            var rs = ImportBUS.Insert(invoice);
            if (rs != null)
            {
                MessageBox.Show("Nhập thành công " + rs.Details.Count + " sản phẩm!");
                int i = 0;
                foreach (var item in rs.Details)
                {
                    while (!item.Barcode.Contains(table.Rows[i].Cells["code"].Value.ToString()))
                        i++;
                    if (item.Barcode.Contains(table.Rows[i].Cells["code"].Value.ToString()))
                        table.Rows.RemoveAt(i++);
                }
                ReloadForm();
            }
            else
                MessageBox.Show("Có lỗi xảy ra! Vui lòng kiểm tra lại!");
        }
    }
}
