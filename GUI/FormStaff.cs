using Spire.Xls;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace GUI
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        private void FormStaff_Activated(object sender, System.EventArgs e)
        {
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
                textBox.Enabled = false;
            }
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = false;
            foreach (RadioButton genderBox in form.Controls.OfType<RadioButton>())
                genderBox.Enabled = false;
            GetTable();
        }

        private void FormStaff_Resize(object sender, System.EventArgs e)
        {
            if (Width > 1150)
            {
                foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                    textBox.Width = 200;
                foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                    dateBox.Width = 200;
                if (Height > 950)
                {
                    table.Height = 500;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else if (Height > 730)
                {
                    table.Height = 250;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else
                {
                    form.Visible = false;
                    table.Dock = DockStyle.Fill;
                }
            }
            else if (Width > 930)
            {
                foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                    textBox.Width = 100;
                foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                    dateBox.Width = 100;
                if (Height > 950)
                {
                    table.Height = 500;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else if (Height > 730)
                {
                    table.Height = 250;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else
                {
                    form.Visible = false;
                    table.Dock = DockStyle.Fill;
                }
            }
            else
            {
                form.Visible = false;
                table.Dock = DockStyle.Fill;
            }
        }

        private void create_Click(object sender, System.EventArgs e)
        {
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
            {
                textBox.Enabled = true;
                textBox.Text = "";
            }
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = true;
            foreach (RadioButton genderBox in form.Controls.OfType<RadioButton>())
                genderBox.Enabled = true;
        }

        private void update_Click(object sender, System.EventArgs e)
        {
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                textBox.Enabled = true;
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = true;
            foreach (RadioButton genderBox in form.Controls.OfType<RadioButton>())
                genderBox.Enabled = true;
        }

        private void delete_Click(object sender, System.EventArgs e)
        {
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
                textBox.Enabled = false;
            }
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = false;
            foreach (RadioButton genderBox in form.Controls.OfType<RadioButton>())
                genderBox.Enabled = false;
        }

        private void save_Click(object sender, System.EventArgs e)
        {
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                textBox.Enabled = false;
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = false;
            foreach (RadioButton genderBox in form.Controls.OfType<RadioButton>())
                genderBox.Enabled = false;
        }

        //Thao tác lấy dữ liệu với từng dòng, t đặt tên các textbox là (inp + tên) á hoặc m cứ xài theo foreach load index
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                inpAccount.Text = selectedRow.Cells["Account"].Value != null ? selectedRow.Cells["Account"].Value.ToString() : "";
                btnAccount.Text = inpAccount.Text == "" ? "Cấp tài khoản" : "Khôi phục mật khẩu";
            }
        }

        //Lấy dữ liệu ở đây nha hoặc m tự đóng gói cục khác cũng được, t tạo mẫu test th :>
        private void GetTable()
        {
            table.Rows.Add("", "", "", "", "", "", "", "", "", "", "");
        }

        private void print_Click(object sender, System.EventArgs e)
        {
            new Handle().Print("tên excel.xsl"); // sửa tên
        }

        private void download_Click(object sender, System.EventArgs e)
        {
            new Handle().Download("tên excel.xsl"); // sửa tên
        }

        private void upload_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Select an Excel file to upload";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string targetDirectory = @"..\..\..\documents";

                try
                {
                    string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(selectedFilePath));
                    File.Copy(selectedFilePath, targetFilePath);

                    // Xử lý tệp Excel đã chọn ở đây
                    Workbook workbook = new Workbook();
                    workbook.LoadFromFile(selectedFilePath);

                    // Thực hiện xử lý với dữ liệu từ tệp Excel

                    MessageBox.Show("Tải lên và lưu tệp Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}