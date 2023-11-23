using System.Web.UI.WebControls;
using System;
using System.Windows.Forms;
using BLL;
using System.Collections;
using System.Xml;
using System.Collections.Generic;
using iText.Layout.Element;
using static Google.Protobuf.WellKnownTypes.Field.Types;
using DTO;
using DAL;
using OfficeOpenXml.LoadFunctions.Params;

namespace GUI
{
    public partial class FormSell : Form
    {
        ProductBUS proBUS = new ProductBUS();
        private const string defaultSearch = "Tìm sản phẩm";
        private const string defaultCustomer = "Tìm khách hàng";
        private const string defaultNote = "Ghi chú đơn hàng";
		public FormSell()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeSearchBox();
            InitializeCustomerBox();
            InitializeNoteBox();
			//LoadDataTable();
		}

        //private void LoadDataTable()
        //{
        //    FindGoodsTable.RowCount = 1;
        //    foreach (ProductOnSale cus in proBUS.getAllWSale())
        //    {
                

        //            FindGoodsTable.Rows.Add(cus.Barcode, cus.Name, cus.Category, cus.Unit, cus.Saleprice, cus.Number);
                

        //    }
        //}

        private void InitializeSearchBox()
        {
            TextBoxSearch.Text = defaultSearch;

            TextBoxSearch.GotFocus += TextBoxSearch_GotFocus;
            TextBoxSearch.LostFocus += TextBoxSearch_LostFocus;
            //TextBoxSearch.TextChanged += TextBoxSearch_TextChanged_2;
            TextBoxSearch.KeyDown += TextBoxSearch_KeyDown;
        }

        private void TextBoxSearch_GotFocus(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == defaultSearch)
            {
                TextBoxSearch.Text = "";
            }

        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem có phải phím Enter không (mã ASCII là 13)
            if (e.KeyCode == Keys.Enter)
            {
                // Xử lý khi phím Enter được nhấn
                TextBoxSearch.Text = "";
            }
        }

        private void TextBoxSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxSearch.Text))
            {
                TextBoxSearch.Text = defaultSearch;
            }
        }

        private void InitializeCustomerBox()
        {
            TextBoxCustomer.Text = defaultCustomer;

            TextBoxCustomer.GotFocus += TextBoxCustomer_GotFocus;
            TextBoxCustomer.LostFocus += TextBoxCustomer_LostFocus;
            //TextBoxSearch.TextChanged += TextBoxCustomer_TextChanged;
            TextBoxCustomer.KeyDown += TextBoxCustomer_KeyDown;
        }

        private void TextBoxCustomer_GotFocus(object sender, EventArgs e)
        {
            if (TextBoxCustomer.Text == defaultCustomer)
            {
                TextBoxCustomer.Text = "";
            }

        }

        private void TextBoxCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem có phải phím Enter không (mã ASCII là 13)
            if (e.KeyCode == Keys.Enter)
            {
                // Xử lý khi phím Enter được nhấn
                TextBoxCustomer.Text = "";
            }
        }

        private void TextBoxCustomer_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxCustomer.Text))
            {
                TextBoxCustomer.Text = defaultCustomer;
            }
        }

        private void InitializeNoteBox()
        {
            TextBoxNote.Text = defaultNote;

            TextBoxNote.GotFocus += TextBoxNote_GotFocus;
            TextBoxNote.LostFocus += TextBoxNote_LostFocus;
            //TextBoxSearch.TextChanged += TextBoxNote_TextChanged;
            TextBoxNote.KeyDown += TextBoxNote_KeyDown;
        }

        private void TextBoxNote_GotFocus(object sender, EventArgs e)
        {
            if (TextBoxNote.Text == defaultNote)
            {
                TextBoxNote.Text = "";
            }

        }

        private void TextBoxNote_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem có phải phím Enter không (mã ASCII là 13)
            if (e.KeyCode == Keys.Enter)
            {
                // Xử lý khi phím Enter được nhấn
                TextBoxNote.Text = "";
            }
        }
		private void GoodsClear_Click(object sender, EventArgs e)
		{
			TextBoxSearch.Text = "";
		}

		private void CustomerClear_Click(object sender, EventArgs e)
		{
			TextBoxCustomer.Text = "";
		}

		private void TextBoxNote_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxNote.Text))
            {
                TextBoxNote.Text = defaultNote;
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = TextBoxSearch.Text;
            FindGoodsTable.RowCount = 1;
            if (TextBoxSearch.Text == defaultSearch)
            {
                Find1Panel.Visible = false;
                FindGoodsTable.Visible = false;
                FindGoodsTable.Rows.Clear();
            }
            else if (string.IsNullOrWhiteSpace(text))
            {
                //FindGoodsTable.RowCount = 1;
                Find1Panel.Visible = true;
                FindGoodsTable.Visible = true;
                FindGoodsTable.Rows.Clear();
                foreach (ProductOnSale cus in proBUS.getAllWSale())
                {
                        FindGoodsTable.Rows.Add(cus.Barcode, cus.Name, cus.Category, cus.Unit, cus.Saleprice, cus.Number);
                }
            }
            else
            {
                Find1Panel.Visible = true;
                FindGoodsTable.Visible = true;
                FindGoodsTable.Rows.Clear();
                foreach (ProductOnSale cus in proBUS.getAllWholelSale(text))
                {
                        FindGoodsTable.Rows.Add(cus.Barcode, cus.Name, cus.Category, cus.Unit, cus.Saleprice, cus.Number);
                }
            }
        }

        private void TextBoxCustomer_TextChanged(object sender, EventArgs e)
        {
            string text = TextBoxCustomer.Text;
            FindGoodsTable.RowCount = 1;
            if (TextBoxCustomer.Text == defaultCustomer)
            {
                Find2Panel.Visible = false;
                FindCustomerTable.Visible = false;
                FindCustomerTable.Rows.Clear();
            }
            else if (string.IsNullOrWhiteSpace(text))
            {
                //FindGoodsTable.RowCount = 1;
                Find2Panel.Visible = true;
                FindCustomerTable.Visible = true;
                FindCustomerTable.Rows.Clear();
                foreach (Customer cus in CustomerBUS.SelectAll())
                {
                    FindCustomerTable.Rows.Add(cus.ContactNumber);
                }
            }
            else
            {
                Find2Panel.Visible = true;
                FindCustomerTable.Visible = true;
                FindCustomerTable.Rows.Clear();
                foreach (Customer cus in CustomerBUS.SearchOnContactNumber(text))
                {
                    FindCustomerTable.Rows.Add(cus.ContactNumber);
                }
            }
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem bảng có rỗng không
            bool isTableEmpty = table.Rows.Count == 0;

            // Đặt trạng thái của nút dựa trên kết quả kiểm tra
            SellBtn.Enabled = !isTableEmpty;
            MessageBox.Show("Button clicked!");
        }

        private void FindGoodsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0 && e.RowIndex < FindGoodsTable.Rows.Count) || string.IsNullOrWhiteSpace(TextBoxSearch.Text) == false)
            {
                //MessageBox.Show("Thành công");
                Find1Panel.Visible = false;
                FindGoodsTable.Visible = false;
                // Lấy hàng đầu tiên được chọn trong FindGoodsTable
                DataGridViewRow selectedRow = FindGoodsTable.Rows[e.RowIndex];

                // Tạo một hàng mới và sao chép dữ liệu từ hàng đã chọn
                DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();

                // Lặp qua các ô trong hàng đã chọn và sao chép dữ liệu
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = selectedRow.Cells[i].Value;
                    newRow.Cells[5].Value = 1;

                }

                // Thêm hàng mới vào table
                table.Rows.Add(newRow);
                double total = 0;
                // Lặp qua từng dòng trong DataGridView
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    // Kiểm tra xem dòng có đủ cột không
                    if (table.Rows[i].Cells.Count >= 8)
                    {
                        // Lấy giá trị từ ô cột 4 và cột 5, nhân chúng và cộng vào tổng
                        double valueInColumn4 = Convert.ToInt32(table.Rows[i].Cells[4].Value);
                        double valueInColumn5 = Convert.ToInt32(table.Rows[i].Cells[5].Value);

                        total += valueInColumn4 * valueInColumn5;
                    }
                }

                // Hiển thị tổng trong Label
                TotalLabel.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong dataGridView1.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

		private void FindCustomerTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			// Kiểm tra nếu dòng được chọn hợp lệ
			if ((e.RowIndex >= 0 && e.RowIndex < FindCustomerTable.Rows.Count) || string.IsNullOrWhiteSpace(TextBoxCustomer.Text) == false)
			{
				Find2Panel.Visible = false;
				FindCustomerTable.Visible = false;
				// Lấy giá trị từ các ô trong dòng và gán vào Label
				string rowValues = "";
                for (int columnIndex = 0; columnIndex < FindCustomerTable.Columns.Count; columnIndex++)
                {
                    rowValues += FindCustomerTable.Rows[e.RowIndex].Cells[columnIndex].Value;
                }

                ShowPhoneLabel.Text = rowValues.ToString();
                //            int customerId = Convert.ToInt32(FindCustomerTable.CurrentRow.Cells["Id"].Value);
                //MessageBox.Show("Tổng:" + customerId);
                //List<SaleInvoice> t = SaleBUS.OnCustomer(customerId);
                //            MessageBox.Show("Tổng:" + t);
                
            }
		}

		private void TextBoxSearch_Click(object sender, EventArgs e)
		{
			if (TextBoxSearch.SelectionStart == 0)
			{
				//MessageBox.Show("TextBox có con trỏ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Find1Panel.Visible = false;
				FindGoodsTable.Visible = false;
			}
            else
            {
				Find1Panel.Visible = true;
				FindGoodsTable.Visible = true;
			}
		}

		private void TextBoxCustomer_Click(object sender, EventArgs e)
		{
			if (TextBoxCustomer.SelectionStart == 0)
			{
				//MessageBox.Show("TextBox có con trỏ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Find2Panel.Visible = false;
				FindCustomerTable.Visible = false;
			}
		}

		private void NewCustomerLabel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void table_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (table.SelectedCells.Count > 0)
			{
				// Duyệt qua tất cả các ô đã chọn
				foreach (DataGridViewCell cell in table.SelectedCells)
				{
					int rowIndex = cell.RowIndex;
					int currentValue = Convert.ToInt32(table.Rows[rowIndex].Cells[5].Value);

					// Xác định cột được click
					switch (e.ColumnIndex)
					{
						case 6:
							// Tăng giá trị
							int newValue = currentValue + 1;
							table.Rows[rowIndex].Cells[5].Value = newValue;
							break;

						case 7:
							// Giảm giá trị, đảm bảo giá trị không âm
							int decreasedValue = Math.Max(0, currentValue - 1);
							if (decreasedValue == 0)
							{
								MessageBox.Show("Số lượng phải lớn hơn 0");
							}
							else
								table.Rows[rowIndex].Cells[5].Value = decreasedValue;
							break;

						case 8:
							// Xóa hàng
							table.Rows.RemoveAt(rowIndex);
							break;
					}
				}
			}

			double total = 0;
			// Lặp qua từng dòng trong DataGridView
			for (int i = 0; i < table.Rows.Count; i++)
			{
				// Kiểm tra xem dòng có đủ cột không
				if (table.Rows[i].Cells.Count >= 8)
				{
					// Lấy giá trị từ ô cột 4 và cột 5, nhân chúng và cộng vào tổng
					double valueInColumn4 = Convert.ToInt32(table.Rows[i].Cells[4].Value);
					double valueInColumn5 = Convert.ToInt32(table.Rows[i].Cells[5].Value);

					total += valueInColumn4 * valueInColumn5;
				}
			}

			// Hiển thị tổng trong Label
			TotalLabel.Text = total.ToString();

		}

		private void SaleCombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Create an instance of your DAO class
			//int count = SaleBUS.getCountByCustomer(FindCustomerTable.RowCount);
			// Call the GetOnCustomer method to get a list of SaleInvoice objects
			//List<SaleInvoice> saleInvoices = getdiem.OnCustomer(ShowPhoneLabel.);

			// Iterate through the list of SaleInvoice objects and retrieve the Point value
			//List<SaleInvoice> invoices = getdiem.OnCustomer(Convert.ToInt32(FindCustomerTable.CurrentRow.Cells["Id"].Value));
			//foreach (SaleInvoice invoice in invoices)
			//{
			int customerId = Convert.ToInt32(FindCustomerTable.CurrentRow.Cells["Id"].Value);

			// Gọi hàm GetPointOnCustomer để lấy giá trị Point
			int pointValue = SaleBUS.GetPointOnCustomer2(ShowPhoneLabel.Text);
			MessageBox.Show("Tổng:" + pointValue);
			//SaleCombobox.Items.Clear();
			if (SaleCombobox.SelectedIndex == 5)
				{
                pointValue = pointValue - 10;
				}
				else if (SaleCombobox.SelectedIndex == 10)
				{
				pointValue = pointValue - 20;
			}
				else if (SaleCombobox.SelectedIndex == 15)
				{
				pointValue = pointValue - 30;
			}
				else if (SaleCombobox.SelectedIndex == 20)
				{
				pointValue = pointValue - 40;
			}
				else if (SaleCombobox.SelectedIndex == 30)
				{
				pointValue = pointValue - 50;
			}
                else if(SaleCombobox.SelectedIndex == 0)
                {
				pointValue = pointValue;
			}
			//}
            double take = Convert.ToInt32(TotalLabel.Text);
            double pay = 0;
				if (SaleCombobox.SelectedIndex == 0)
				{
					pay = take * 1;
				}
				else
				{
					pay = take - ((take * Convert.ToInt32(SaleCombobox.SelectedIndex)) / 100);
				}
				PayLabel.Text = pay.ToString();
		}

		private void SaleCombobox_Click(object sender, EventArgs e)
		{
			int pointValue = SaleBUS.GetPointOnCustomer2(ShowPhoneLabel.Text);
			//SaleCombobox.Items.Clear();
			SaleCombobox.Items.Clear();
			SaleCombobox.Items.Add("0");
			if (pointValue >= 10)
			{
				SaleCombobox.Items.Add("5");
			}
		    if (pointValue >= 20)
			{
				SaleCombobox.Items.Add("10");
			}
			if (pointValue >= 30)
			{
				SaleCombobox.Items.Add("15");
			}
			if (pointValue >= 40)
			{
				SaleCombobox.Items.Add("20");
			}
			if (pointValue >= 50)
			{
				SaleCombobox.Items.Add("30");
			}
		}

		private void TextBoxReceive_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (Convert.ToInt32(TextBoxReceive.Text) >= Convert.ToInt32(PayLabel.Text))
				{
					int cal = (Convert.ToInt32(TextBoxReceive.Text) - Convert.ToInt32(PayLabel.Text));
					RottenLabel.Text = cal.ToString();

				}
				else
				{
					MessageBox.Show("Khách chưa đưa đủ tiền");
				}
			}
		}

		//private void TextBoxReceive_KeyPress(object sender, KeyPressEventArgs e)
		//{
		//	if (Convert.ToInt32(TextBoxReceive.Text) >= Convert.ToInt32(PayLabel.Text))
		//	{
		//		int cal = (Convert.ToInt32(TextBoxReceive.Text) - Convert.ToInt32(PayLabel.Text));
		//		RottenLabel.Text = cal.ToString();

		//	}
		//	else
		//	{
		//		MessageBox.Show("Khách chưa đưa đủ tiền");
		//	}
		//}

	}
}
