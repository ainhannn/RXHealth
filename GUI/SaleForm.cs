using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class SaleForm : Form
	{

		private const string defaultSearch = "Tìm sản phẩm";
		private const string defaultCustomer = "Tìm khách hàng";
		private const string defaultNote = "Ghi chú đơn hàng";
		public SaleForm()
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
			InitializeSearchBox();
			InitializeCustomerBox();
			InitializeNoteBox();
		}

		private void InitializeSearchBox()
		{
			TextBoxSearch.Text = defaultSearch;

			TextBoxSearch.GotFocus += TextBoxSearch_GotFocus;
			TextBoxSearch.LostFocus += TextBoxSearch_LostFocus;
			//TextBoxSearch.TextChanged += TextBoxSearch_TextChanged;
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

		private void TextBoxNote_LostFocus(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(TextBoxNote.Text))
			{
				TextBoxNote.Text = defaultNote;
			}
		}

		private void TextBoxSearch_TextChanged(object sender, EventArgs e)
		{
			//SearchLabel.Text = "Kết quả tìm kiếm cho: " + TextBoxSearch.Text;
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

		private void TextBoxSearch_TextChanged_1(object sender, EventArgs e)
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
	}
}
