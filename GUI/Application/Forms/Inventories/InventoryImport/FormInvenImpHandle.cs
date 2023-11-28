using BLL;
using DTO;
using iText.IO.Codec;
using System;
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
            // Cap nhat stt
            for (int i = 0; i < table.Rows.Count-1;)
                table.Rows[i].Cells["id"].Value = ++i;
            
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

        [Obsolete]
        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Select an Excel file to upload";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    Spire.Xls.Workbook workbook = new Spire.Xls.Workbook();
                    workbook.LoadFromFile(selectedFilePath);

                    var tb = Retreat.ReadFromSheet(workbook.Worksheets[0]);
                    if (tb.Count < 1 && tb[0].Count != 9)
                    {
                        MessageBox.Show("File không hợp lệ!");
                        return;
                    }
                    foreach (var row in tb)
                        table.Rows.Add(null, row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);

                    MessageBox.Show("Tải lên thành công " + tb.Count + " dòng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

                }
                catch { continue; }
            }

            var rs = ImportBUS.Insert(invoice);
            if (rs != null)
            {
                MessageBox.Show("Nhập thành công " + rs.Details.Count + " sản phẩm!");
                for (int i = 0; i < table.Rows.Count;)
                {
                    foreach (var item in rs.Details) 
                    { 
                        if (Convert.ToString(table.Rows[i].Cells["code"].Value).Contains(item.Barcode))
                            table.Rows.RemoveAt(i);
                    }
                    i++;
                }
                ReloadForm();
            }
            else
                MessageBox.Show("Có lỗi xảy ra! Vui lòng kiểm tra lại!");
        }
    }
}
