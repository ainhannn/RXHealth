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
                    FindCustomerTable.Rows.Add(cus.ContactNumber + " - " + cus.Name);
                }
            }
            else
            {
                Find2Panel.Visible = true;
                FindCustomerTable.Visible = true;
                FindCustomerTable.Rows.Clear();
                foreach (Customer cus in CustomerBUS.SearchOnContactNumber(text))
                {
                    FindCustomerTable.Rows.Add(cus.ContactNumber + " - " + cus.Name);
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
                table.Rows.Clear();
                table.Rows.Add(newRow);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong dataGridView1.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FindCustomerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra nếu dòng được chọn hợp lệ
            if ((e.RowIndex >= 0 && e.RowIndex < FindCustomerTable.Rows.Count) || string.IsNullOrWhiteSpace(TextBoxCustomer.Text) == true)
            {
                Find2Panel.Visible = false;
                FindCustomerTable.Visible = false;
                // Lấy giá trị từ các ô trong dòng và gán vào Label
                string rowValues = "";
                for (int columnIndex = 0; columnIndex < FindCustomerTable.Columns.Count; columnIndex++)
                {
                    rowValues += FindCustomerTable.Rows[e.RowIndex].Cells[columnIndex].Value.ToString() + " ";
                }

                ShowPhoneLabel.Text = rowValues;
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
            //String cln = this.table.Columns[e.ColumnIndex].Name;
            int index = this.table.SelectedCells[e.RowIndex].RowIndex;
            int currentValue = Convert.ToInt32(table.Rows[index].Cells[5].Value);

            if (e.ColumnIndex == 6)
            {
                int newValue = currentValue + 1;
                table.Rows[index].Cells[5].Value = newValue;
            }
            else if (e.ColumnIndex == 7)
            {
                int newValue = currentValue - 1;
                if (newValue == 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0");
                }
                else
                table.Rows[index].Cells[5].Value = newValue;
            }
            else if (e.ColumnIndex == 8)
            {
                table.Rows.RemoveAt(index);
            }
        }

        

















        //private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    String cln = this.table.Columns[e.ColumnIndex].Name;
        //    int index = this.table.SelectedCells[0].RowIndex;
        //    ChiTietHoaDon cthd = (ChiTietHoaDon)this.listCTHD[index];
        //    ProductOnSale sp = proBUS.getFromCTSP(cthd.MaChiTietSanPham.ToString());
        //    int slt = ChiTietSanPhamBUS.getSoLuongTon(cthd.MaChiTietSanPham.ToString());
        //    if (cln == "Cong")
        //    {

        //        int sl = Convert.ToInt32(this.table.Rows[index].Cells["soLuongDonHang"].Value.ToString());
        //        if ((sl + 1) <= slt)
        //        {
        //            updateCTHD(1, index, sp, BanHangFrom.CongTru);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Số lượng "
        //                + sp.TenSanPham + " ở cửa hàng chỉ còn " + this.SoLuongTon + " cái!");
        //        }


        //    }
        //    else if (cln == "Tru")
        //    {

        //        updateCTHD(-1, index, sp, BanHangFrom.CongTru);


        //    }
        //    else if (cln == "Xoa")
        //    {
        //        this.dgvDonHang.Rows.RemoveAt(index);
        //        this.listCTHD.RemoveAt(index);
        //        this.listDonHang.RemoveAt(index);
        //        MessageBox.Show(this.listCTHD.Count + " " + this.listCTSP.Count);

        //    }

        //}







    }
}
