using System;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class FormSell : Form
    {
        public FormSell()
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
            TextBoxSearch.KeyDown += TextBoxSearch_KeyDown;
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
        
        private void InitializeCustomerBox()
        {
            TextBoxCustomer.Text = defaultCustomer;
            TextBoxCustomer.KeyDown += TextBoxCustomer_KeyDown;
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
        
        private void InitializeNoteBox()
        {
            TextBoxNote.Text = defaultNote;
            TextBoxNote.KeyDown += TextBoxNote_KeyDown;
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
    }
}