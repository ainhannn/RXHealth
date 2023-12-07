using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSell : Form
    {
        private const string defaultSearch = "Tìm sản phẩm";
        private const string defaultCustomer = "Tìm khách hàng";
        private const string defaultNote = "Ghi chú đơn hàng";
        private readonly double VAT = Convert.ToDouble(Retreat.GetSetting("vat"));
        private readonly double normPrice = Convert.ToDouble(Retreat.GetSetting("price"));
        private readonly int normPoint = Convert.ToInt16(Retreat.GetSetting("point"));

        private void Reload()
        {
            table.Rows.Clear();
            TextBoxSearch.Text = defaultSearch;
            TextBoxCustomer.Text = defaultCustomer;
            TextBoxNote.Text = defaultNote;
            txtCus.Text = "Guest";
            txtPoint.Text = "0";
            TotalLabel.Text = "0";
            SaleCombobox.Text = "";
            TextBoxReceive.Text = "";
            RottenLabel.Text = "0";
        }

        private void FormSell_Load(object sender, EventArgs e)
        {
            Find1Panel.Visible = false;
            FindGoodsTable.Visible = false;

            Find2Panel.Visible = false;
            FindCustomerTable.Visible = false;

            Reload();
        }


        // Tìm sản phẩm
        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            // Bật khung tìm kiếm
            if (TextBoxSearch.Text == defaultSearch)
                TextBoxSearch.Text = ""; 
            Find1Panel.Visible = true;
            FindGoodsTable.Visible = true;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FindGoodsTable.Rows.Clear();
            if (TextBoxSearch.Text == defaultSearch) return;
            
            foreach (var item in ProductBUS.SearchForSale(TextBoxSearch.Text))
                FindGoodsTable.Rows.Add(item.Barcode, item.Name, item.Category, item.Unit, item.Saleprice, item.Number);
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (!FindGoodsTable.Focused)
            {
                Find1Panel.Visible = false;
                FindGoodsTable.Visible = false;
                if (string.IsNullOrEmpty(TextBoxSearch.Text))
                    TextBoxSearch.Text = defaultSearch;
            }
        }

        private void FindGoodsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || 
                FindGoodsTable.Rows[e.RowIndex] == null ||
                FindGoodsTable.Rows[e.RowIndex].Cells["Barcode2"].Value == null) 
                return;

            // Duyệt từng ô trong danh sách sản phẩm đã chọn
            for (int i = 0; i < table.Rows.Count; i++)
            {
                // Nếu danh sách đã chọn trống, bỏ qua vòng lặp
                if (table.Rows[i].Cells["PName"].Value == null) break;

                // Nếu sp mới chọn đã được chọn trước đó
                if (table.Rows[i].Cells["Barcode"].Value.ToString() == FindGoodsTable.Rows[e.RowIndex].Cells["Barcode2"].Value.ToString())
                {
                    // Khác đơn vị -> thông báo lỗi
                    if (table.Rows[i].Cells["Unit"].Value.ToString() != FindGoodsTable.Rows[e.RowIndex].Cells["Unit2"].Value.ToString())
                    {
                        MessageBox.Show("Không thể chọn sản phẩm khác đơn vị tính. Bạn có thể xóa chọn lại!");
                        return;
                    }

                    // Cùng đơn vị -> tăng số lượng thêm 1
                    int.TryParse(table.Rows[i].Cells["Number"].Value.ToString(), out var num);
                    table.Rows[i].Cells["Number"].Value = num + 1;

                    // Tắt khung tìm kiếm
                    Find1Panel.Visible = false;
                    FindGoodsTable.Visible = false;
                    TextBoxSearch.Text = defaultSearch;
                    return;
                }
            }

            // Thêm sp danh sách chọn
            table.Rows.Add(
                table.Rows.Count,
                FindGoodsTable.Rows[e.RowIndex].Cells["Barcode2"].Value,
                FindGoodsTable.Rows[e.RowIndex].Cells["Name2"].Value,
                FindGoodsTable.Rows[e.RowIndex].Cells["Cate2"].Value,
                FindGoodsTable.Rows[e.RowIndex].Cells["Unit2"].Value,
                FindGoodsTable.Rows[e.RowIndex].Cells["Saleprice2"].Value,
                "-",
                1,
                "+",
                FindGoodsTable.Rows[e.RowIndex].Cells["Saleprice2"].Value,
                "x");

            // Tắt khung tìm kiếm
            Find1Panel.Visible = false;
            FindGoodsTable.Visible = false;
            TextBoxSearch.Text = defaultSearch;
        }

        private void FindGoodsTable_Leave(object sender, EventArgs e)
        {
            if (!TextBoxSearch.Focused)
            {
                Find1Panel.Visible = false;
                FindGoodsTable.Visible = false;
                if (string.IsNullOrEmpty(TextBoxSearch.Text))
                    TextBoxSearch.Text = defaultSearch;
            }
        }


        // + - Xóa sản phẩm
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table.Rows.Count <= 1) return;

            switch (e.ColumnIndex)
            {
                case 10: // Xóa
                    double.TryParse(table.Rows[e.RowIndex].Cells["Amount"].Value.ToString(), out double amount);
                    double.TryParse(TotalLabel.Text, out double total);
                    TotalLabel.Text = (total - amount).ToString();
                    
                    table.Rows.RemoveAt(e.RowIndex);
                    break;

                case 8: // +
                    int.TryParse(table.Rows[e.RowIndex].Cells["Number"].Value.ToString(), out int num);
                    table.Rows[e.RowIndex].Cells["Number"].Value = num + 1;
                    break;

                case 6: // -
                    int.TryParse(table.Rows[e.RowIndex].Cells["Number"].Value.ToString(), out int n);
                    if (n > 1) table.Rows[e.RowIndex].Cells["Number"].Value = n - 1; 
                    break;
            }
        }

        private void table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (table.Rows.Count <= 1) return;

            double.TryParse(table.Rows[e.RowIndex].Cells["Amount"].Value.ToString(), out double amount);
            double.TryParse(TotalLabel.Text, out double total);
            TotalLabel.Text = (total + amount).ToString();
        }

        private void table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (table.Rows.Count <= 1) return; 
            if (e.ColumnIndex != 7) return;

            double.TryParse(table.Rows[e.RowIndex].Cells["SalePrice"].Value.ToString(), out double price);
            int.TryParse(table.Rows[e.RowIndex].Cells["Number"].Value.ToString(), out int num);
            table.Rows[e.RowIndex].Cells["Amount"].Value = price * num;

            double total = 0;
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                double.TryParse(table.Rows[i].Cells["Amount"].Value.ToString(), out double amount);
                total += amount;
            }
            TotalLabel.Text = total.ToString();
        }

        // Cập nhật số tiền phải trả
        private void TotalLabel_TextChanged(object sender, EventArgs e)
        {
            int dis = 0;
            double take = 0;

            double.TryParse(TotalLabel.Text, out take);
            if (SaleCombobox.SelectedValue != null)
                int.TryParse(SaleCombobox.SelectedValue.ToString(), out dis);

            PayLabel.Text = Convert.ToString(take * (1 - dis / 100) * (1 + VAT));
        }


        // Tìm khách hàng
        private void TextBoxCustomer_Click(object sender, EventArgs e)
        {
            if (TextBoxCustomer.Text == defaultCustomer)
                TextBoxCustomer.Text = "";
            Find2Panel.Visible = true;
            FindCustomerTable.Visible = true;
        }

        private void TextBoxCustomer_TextChanged(object sender, EventArgs e)
        {
            FindCustomerTable.Rows.Clear();
            if (TextBoxCustomer.Text == defaultCustomer) return;

            foreach (var item in CustomerBUS.SearchOnContactNumber(TextBoxCustomer.Text))
            {
                FindCustomerTable.Rows.Add(item.Id, item.ContactNumber, item.Name, item.TotalPoint);
            }
        }

        private void TextBoxCustomer_Leave(object sender, EventArgs e)
        {
            if (!FindCustomerTable.Focused)
            {
                Find2Panel.Visible = false;
                FindCustomerTable.Visible = false;
                if (string.IsNullOrEmpty(TextBoxCustomer.Text))
                    TextBoxCustomer.Text = defaultCustomer;
            }
        }

        private void FindCustomerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                FindCustomerTable.Rows[e.RowIndex] == null ||
                FindCustomerTable.Rows[e.RowIndex].Cells["Id"].Value == null)
                return;

            if (FindCustomerTable.Rows[e.RowIndex].Cells["Id"].Value.ToString() == "1")
            {
                // Khách vãng lai
                txtCus.Text = "Guest";
                txtPoint.Text = "0";
            }
            else
            {
                // Lấy thông tin khách hàng
                txtCus.Text = FindCustomerTable.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                txtPoint.Text = FindCustomerTable.Rows[e.RowIndex].Cells["point"].Value.ToString();

                // Lấy giá trị discount
                int.TryParse(txtPoint.Text, out int pointValue);
                SaleCombobox.Items.Clear();
                for (int i = 0; i <= pointValue / 2; i += 5)
                    SaleCombobox.Items.Add(i);
            }

            // Tắt khung tìm kiếm
            Find2Panel.Visible = false;
            FindCustomerTable.Visible = false;
        }

        private void FindCustomerTable_Leave(object sender, EventArgs e)
        {
            if (!TextBoxCustomer.Focused)
            {
                Find2Panel.Visible = false;
                FindCustomerTable.Visible = false;
                if (string.IsNullOrEmpty(TextBoxCustomer.Text))
                    TextBoxCustomer.Text = defaultCustomer;
            }
        }

        private void NewCustomer_Click(object sender, EventArgs e)
        {
            CustomerMini mini = new CustomerMini();
            mini.Show();
        }


        // Chọn đổi điểm giảm giá
        private void SaleCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            double.TryParse(TotalLabel.Text, out var take);
            int.TryParse(SaleCombobox.Text, out var dis);
            PayLabel.Text = Convert.ToString(take * (1 - (dis*1.0/100)) * (1 + VAT));
        }

        // Nhập số tiền thu
        private void TextBoxReceive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double.TryParse(TextBoxReceive.Text, out var receive);
                double.TryParse(PayLabel.Text, out var pay);
                if (receive >= pay)
                    RottenLabel.Text = Convert.ToString(receive - pay);
                else
                    MessageBox.Show("Khách chưa đưa đủ tiền");
            }
        }

        // Hoàn tất đơn hàng
        private void SellBtn_Click(object sender, EventArgs e)
        {
            // Check null bỏ qua
            if (table.Rows.Count <= 1)
            {
                MessageBox.Show("Không có sản phẩm được chọn!");
                return;
            }
            if (string.IsNullOrEmpty(TextBoxReceive.Text))
            {
                MessageBox.Show("Chưa nhập thông tin thanh toán!");
                return;
            }
			double.TryParse(TextBoxReceive.Text, out var receive);
			double.TryParse(PayLabel.Text, out var pay);
			if (receive >= pay)
				RottenLabel.Text = Convert.ToString(receive - pay);
			else
			{
				MessageBox.Show("Khách chưa đưa đủ tiền");
				return;
			}

			// Tạo hóa đơn
			var invoice = new SaleInvoice()
            {
                StaffId = LoginForm.Id,
                CustomerId = txtCus.Text != "Guest" ? CustomerBUS.GetId(txtCus.Text) : 1,
                Point = (int) (Convert.ToDouble(TotalLabel.Text) / normPrice) * normPoint
            };
            for (var i = 0; i < table.Rows.Count - 1; i++)
            {
                var barcode = table.Rows[i].Cells["Barcode"].Value.ToString();
                var name = table.Rows[i].Cells["PName"].Value.ToString();
                var unit = table.Rows[i].Cells["Unit"].Value.ToString();
                float.TryParse(table.Rows[i].Cells["SalePrice"].Value.ToString(), out var unitPrice);
                int.TryParse(table.Rows[i].Cells["Number"].Value.ToString(), out var number);

                invoice.AddDetail(new SaleDetail(barcode, name, unit, unitPrice, number));
            }

            // Lưu xuống db
            if (SaleBUS.Insert(invoice))
            {
                // Trừ điểm đã đổi discount
                int.TryParse(SaleCombobox.Text, out var dis);
                if (CustomerBUS.ReducePoint(invoice.CustomerId, 2 * dis))
                    MessageBox.Show("Giao dịch hoàn tất! Khách hàng có thêm " + invoice.Point + " điểm!");
                Reload();
            }
            else
                MessageBox.Show("Đã có lỗi xảy ra! Vui lòng thử lại");
        }
    }
}