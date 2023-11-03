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
            GetTable(); //lấy dữ liệu bảng
        }

        // Responsive
        private void FormStaff_Resize(object sender, System.EventArgs e)
        {
            if (Width > 1300)
            {
                foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                    textBox.Width = 250;
                foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                    dateBox.Width = 250;
                inpRole.Width = 250;
                if (Height > 970)
                {
                    table.Height = 450;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else if (Height > 890)
                {
                    table.Height = 400;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else
                {
                    form.Visible = false;
                    table.Dock = DockStyle.Fill;
                }
            }
            else if (Width > 1200)
            {
                lblFilter.Visible = true;
                filterDate.Visible = true;
                foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                    textBox.Width = 200;
                foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                    dateBox.Width = 200;
                inpRole.Width = 200;
                if (Height > 970)
                {
                    table.Height = 450;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else if (Height > 890)
                {
                    table.Height = 400;
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
                lblFilter.Visible = false;
                filterDate.Visible = false;
                table.Dock = DockStyle.Fill;
            }
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            pnlSearch.Width = 300;
        }

        private void pnlSearch_MouseLeave(object sender, EventArgs e)
        {
            if (inpSearch.Text == "" && inpSearch.Focused == false)
                pnlSearch.Width = 50;
        }

        // ------------------------------------------------------------------------------

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

        /*----------------------------
         print: yêu cầu ép tất cả dữ liệu vào excel và lưu lại trong folder documents
                1. ép dữ liệu DB vào excel ()
                2. lưu file tại thư mục documents, ghi đè (nếu có) ()
                3. mở dialog print và thực hiện print 1 file được chỉ định (xong)

         download: yêu cầu ghi file excel chứa dữ liệu hiện có trong database (file được lưu và
                    ghi đè (nếu tồn tại) tại thư mục documents - chuẩn bị sẵn sàng để tải về)
                1. ép dữ liệu DB vào excel ()
                2. lưu file tại thư mục documents, ghi đè (nếu có) ()
                3. dialog để "Save As" file được chỉ định ở location tự chọn của người dùng (xong)

         upload: yêu cầu đăng tải file chứa dữ liệu mới để cập nhật thêm dữ liệu vào DB
                    (lưu ý không cần ghi file vào documents, chỉ cần cập nhật dữ liệu)
                1. dialog chọn file cần đăng tải mà người dùng đã tạo (xong)
                2. đọc dữ liệu file đã chọn và cập nhật thêm mới vào DB ()
         -----------------------------*/

        private void print_Click(object sender, System.EventArgs e)
        {
            Xls.Print("DHT.xlsx"); // sửa đúng tên và định dạng của tệp cần in
        }

        private void download_Click(object sender, System.EventArgs e)
        {
            Xls.Download("DHT"); // sửa tên không cần định dạng
        }

        private void upload_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            Xls.Upload(openFileDialog);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (btnAccount.Text == "Khôi phục mật khẩu")
            {
                
            }
            else
            {

            }
        }
    }
}