using System.Linq;
using System;
using System.Windows.Forms;
using DTO;
using DAL;
using System.Collections.Generic;
using BLL;
using System.Text.RegularExpressions;
using DotNetEnv;
using iText.Layout.Element;
using System.Globalization;
using iText.Commons.Utils;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using System.IO;
using OfficeOpenXml;
using Spire.Xls.AI;
using Excel = Microsoft.Office.Interop.Excel;
using iText.IO.Font.Cmap;
using Microsoft.Office.Interop.Excel;
using TextBox = System.Windows.Forms.TextBox;
using Google.Protobuf.WellKnownTypes;

namespace GUI
{
    public partial class FormStaff : Form
    {

        private bool is_CreateForm = true;
        //check position
        private int checkIndexPositionStaff(string position)
        {
            return position == "Quản kho" ? Env.GetInt("warehouse_manager") : Env.GetInt("sell");
        }
        private string ckeckPositionStaff(int id)
        {
            return StaffBLL.getRole(id);
        }

        private void setBtnAccount()
        {
            if (is_CreateForm)
            {
                if (inpAccount.Text == "" && inpId.Text != "")
                {
                    btnAccount.Visible = true;
                    btnAccount.Text = "Tạo tài khoản";
                }
                else
                {
                    btnAccount.Visible = false;
                }
            }
            else
            {
                btnAccount.Visible = true;
                if (inpAccount.Text == "" && inpId.Text != "")
                {
                    btnAccount.Visible = true;
                    btnAccount.Text = "Tạo tài khoản";
                }
                else if (inpAccount.Text != "" && inpId.Text != "")
                {
                    btnAccount.Visible = true;
                    btnAccount.Text = "Tạo mới tài khoản";
                }
                else
                {
                    btnAccount.Visible = false;
                }
            }
        }
        private void reset()
        {
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
            {
                textBox.Enabled = true;
                textBox.Text = "";
            }
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = true;
            foreach (RadioButton genderBox in form.Controls.OfType<RadioButton>())
            {
                genderBox.Enabled = true;
            }
            inpGenderMale.Checked = true;
            inpTitle.Enabled = true;
            inpTitle.SelectedIndex = 1;
            inpId.Enabled = false;
            btnAccount.Visible = false;
            setBtnAccount();
        }
        // Load dữ liệu tất cả nhân viên lên bảng
        private void Data(List<Staff> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Data null");
                return;
            }
            foreach (Staff item in list)
            {
                if(ckeckPositionStaff(item.Id) != "Quản lý")
                table.Rows.Add(item.Id.ToString(), item.Nickname, item.CitizenId, item.FullName, item.Birthday,
                    item.GenderIsMale == true ? "Nam" : "Nữ", item.Qualification, item.ContactNumber, item.Address,
                    ckeckPositionStaff(item.Id), AccountBLL.getUsernameAccount(item.Id), item.StartDate, item.ResignationDate);
            }
        }
        private void Table_Load(object sender, System.EventArgs e)
        {
            table.Rows.Clear();
            List<Staff> list = StaffBLL.getAllStaff();
            Data(list);
            comboBoxFilter.SelectedIndex = 2;
            comboFilterGender.SelectedIndex = 2;
            inpTitle.SelectedIndex = 1;

        }

        //Tìm kiếm
        private void search_Click(object sender, System.EventArgs e)
        {
            string contentSearch = inpSearch.Text;
            int filter = comboBoxFilter.SelectedIndex;
            int gender = comboFilterGender.SelectedIndex;
            if (contentSearch == "" || contentSearch == " ")
            {
                MessageBox.Show("Chưa có dữ liệu để tìm kiếm!");
                return;
            }
            table.Rows.Clear();
            pnlSearch.Text = "";
            List<Staff> list = StaffBLL.getStaffsOnRequest(contentSearch, filter, gender);
            Data(list);
        }
        private void create_Click(object sender, System.EventArgs e)
        {
            is_CreateForm = true;
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
            {
                Console.WriteLine(textBox.Name);
                textBox.Enabled = true;
                textBox.Text = "";
            }
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = true;
            foreach (RadioButton genderBox in form.Controls.OfType<RadioButton>())
            {
                genderBox.Enabled = true;
            }
            inpGenderMale.Checked = true;
            inpTitle.Enabled = true;
            inpTitle.SelectedIndex = 1;
            inpId.Enabled = false;
            inpAccount.Enabled = false;
            btnAccount.Visible = false;
            inpStartDate.Enabled = false;
            setBtnAccount();
        }
        private void update_Click(object sender, System.EventArgs e)
        {
            is_CreateForm = false;
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                textBox.Enabled = true;
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = true;
            foreach (RadioButton genderBox in form.Controls.OfType<RadioButton>())
                genderBox.Enabled = true;
            inpTitle.Enabled = true;
            inpAccount.Enabled = false;
            inpStartDate.Enabled = false;
            setBtnAccount();
        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Loại bỏ các khoảng trắng và dấu gạch nếu có
            string cleanedPhoneNumber = Regex.Replace(phoneNumber, @"[\s-]", "");

            if (Regex.IsMatch(cleanedPhoneNumber, @"^\d{10}$") ||
                Regex.IsMatch(cleanedPhoneNumber, @"^\d{11}$") ||
                Regex.IsMatch(cleanedPhoneNumber, @"^\(\d{3}\)\d{7}$") ||
                Regex.IsMatch(cleanedPhoneNumber, @"^\(\d{3}\)\s\d{7}$"))
            {
                return true;
            }

            return false;
        }
        private bool IsCitizenId(string citizenId)
        {
            string cleanedPhoneNumber = Regex.Replace(citizenId, @"[\s-]", "");
            if (Regex.IsMatch(cleanedPhoneNumber, @"^\d{12}$"))
            {
                return true;
            }
            return false;
        }
        private string validateInpStaff()
        {
            List<TextBox> textList = new List<TextBox>{inpAddress,
                                                       inpCitizenId,
                                                       inpContactNumber,
                                                       inpNickname,
                                                       inpQualification,
                                                       inpFullName};
            foreach (TextBox textBox in textList)
            {
                if (textBox.Text == "" || textBox.Text == " ")
                {
                    return "Vui lòng điền đầy đủ thông tin!";
                }
                else if (!IsPhoneNumberValid(inpContactNumber.Text))
                {
                    return "Định dạng số điện thoại sai!";
                }
                else if (!IsCitizenId(inpCitizenId.Text))
                {
                    return "Định dạng căn cước công dân sai!";
                }
            }
            return "200";
        }
        private void delete_Click(object sender, System.EventArgs e)
        {
            int count = 0;
            for (int i = table.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = table.Rows[i];
                if (Convert.ToBoolean(row.Cells[13].Value) == true)
                {
                    bool rs = StaffBLL.deleteStaff(Convert.ToInt16(row.Cells[0].Value));
                    if (rs == false) Console.WriteLine("Id " + Convert.ToInt16(row.Cells[0].Value) + " không có!");
                }
            }
            table.Rows.Clear();
            List<Staff> list = StaffBLL.getAllStaff();
            Data(list);
            if (count != 0)
                MessageBox.Show("Đã xóa " + count + "nhân viên");
            reset();
        }

        public static DateTime ConvertStringToDateTime(string dateString)
        {
            DateTime result;

            if (DateTime.TryParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                return result;
            }
            else
            {
                throw new FormatException("Chuỗi không hợp lệ hoặc không thể chuyển đổi thành DateTime.");
            }
        }
        private void insertStaff()
        {
            int role = inpTitle.SelectedIndex;
            if (StaffBLL.insertStaff(new Staff(inpNickname.Text, inpCitizenId.Text, inpFullName.Text,
                ConvertStringToDateTime(inpBirthday.Text), inpGenderMale.Checked == true,
                inpQualification.Text, inpContactNumber.Text, inpAddress.Text,
                ConvertStringToDateTime(DateTime.Now.ToString("dd-MM-yyyy"))), role+1, inpCitizenId.Text))
            {
                MessageBox.Show("Thêm thành công");
                return;
            }
            MessageBox.Show("Thêm thất bại, có thể trùng tên hiển thị, cmnd/cccd hoặc số điện thoại!");
        }

        private void updateStaff()
        {

            if (inpId.Text == "" || inpId.Text == " ")
            {
                MessageBox.Show("Chưa điền Id");
                return;
            }
            int role = inpTitle.SelectedIndex;
            bool rs = StaffBLL.updateStaff(new Staff(Convert.ToInt16(inpId.Text), inpNickname.Text, inpCitizenId.Text, inpFullName.Text,
                ConvertStringToDateTime(inpBirthday.Text), inpGenderMale.Checked == true,
                inpQualification.Text, inpContactNumber.Text, inpAddress.Text,
                ConvertStringToDateTime(DateTime.Now.ToString("dd-MM-yyyy")), ConvertStringToDateTime(inpResignationDate.Text)), role+1);
            if (rs == true)
            {
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành cônhg, vui lòng kiểm tra lại thông tin");

            }


        }
        private void save_Click(object sender, System.EventArgs e)
        {
            string resultValidate = validateInpStaff();
            if (resultValidate != "200")
            {
                MessageBox.Show(resultValidate);
                return;
            }
            else if (is_CreateForm)
            {
                insertStaff();
            }
            else

            {
                updateStaff();
            }
            table.Rows.Clear();
            List<Staff> list = StaffBLL.getAllStaff();
            Data(list);
            inpTitle.SelectedIndex = 1;
            setBtnAccount();
        }
        //foreach (TextBox textBox in form.Controls.OfType<TextBox>())
        //    textBox.Enabled = false;
        //foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
        //    dateBox.Enabled = false;
        //foreach (RadioButton genderBox in form.Controls.OfType<RadioButton>())
        //    genderBox.Enabled = false;

        //Thao tác lấy dữ liệu với từng dòng, t đặt tên các textbox là (inp + tên) á hoặc m cứ xài theo foreach load index
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                inpId.Text = (string)selectedRow.Cells[0].Value;
                inpNickname.Text = (string)selectedRow.Cells[1].Value;
                inpCitizenId.Text = (string)selectedRow.Cells[2].Value;
                inpFullName.Text = (string)selectedRow.Cells[3].Value;
                try
                {
                    inpBirthday.Value = (DateTime)selectedRow.Cells[4].Value;
                }
                catch
                {
                    inpBirthday.Value = ConvertStringToDateTime(Convert.ToDateTime(selectedRow.Cells[4].Value).ToString("dd-MM-yyyy"));
                }
                if ((string)selectedRow.Cells[5].Value == "Nam")
                {
                    inpGenderMale.Checked = true;
                }
                else
                {
                    inpGenderFemale.Checked = true;
                }
                inpQualification.Text = (string)selectedRow.Cells[6].Value;
                inpContactNumber.Text = (string)selectedRow.Cells[7].Value;
                inpAddress.Text = (string)selectedRow.Cells[8].Value;
                inpTitle.SelectedIndex = checkIndexPositionStaff((string)selectedRow.Cells[9].Value) -1 ;
                inpAccount.Text = (string)selectedRow.Cells[10].Value;
                try
                {
                    inpStartDate.Value = (DateTime)selectedRow.Cells[11].Value;
                }
                catch
                {
                    inpStartDate.Value = ConvertStringToDateTime(Convert.ToDateTime(selectedRow.Cells[11].Value).ToString("dd-MM-yyyy"));
                }
                try
                {
                    inpResignationDate.Value = (DateTime)selectedRow.Cells[12].Value;
                }
                catch (Exception ex)
                {
                    inpResignationDate.Value = ConvertStringToDateTime(Convert.ToDateTime(selectedRow.Cells[12].Value).ToString("dd-MM-yyyy"));
                    Console.WriteLine(ex.Message);
                }
            }
            setBtnAccount();
        }

        private void saveDatasUpload()
        {
            List<Staff> error = new List<Staff>();
            for (int i = table.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = table.Rows[i];
                int id = Convert.ToInt16(row.Cells[0].Value);
                string nickname = Convert.ToString(row.Cells[1].Value);
                string citizenId = Convert.ToString(row.Cells[2].Value);
                string fullname = Convert.ToString(row.Cells[3].Value);
                DateTime birthday = (Convert.ToDateTime(row.Cells[4].Value));
                bool gender = Convert.ToString(row.Cells[5].Value) == "Nam";
                string qualification = Convert.ToString(row.Cells[6].Value);
                string contactNumber = Convert.ToString(row.Cells[7].Value);
                string address = Convert.ToString(row.Cells[8].Value);
                int role = checkIndexPositionStaff(Convert.ToString(row.Cells[9].Value));
                String startstr = Convert.ToString(row.Cells[11].Value);
                DateTime start = startstr == "" ? ConvertStringToDateTime(DateTime.Now.ToString("dd-MM-yyyy")) : Convert.ToDateTime(startstr);
                Staff staff = new Staff(nickname, citizenId, fullname, birthday, gender, qualification, contactNumber, address, start);
                if (StaffBLL.insertStaff(staff, role, citizenId) == false)
                {
                    error.Add(staff);
                    continue;
                }
                else
                {
                    table.Rows.Remove(row);
                }
            }
            if (error != null)
            {
                DialogResult result = MessageBox.Show("Dữ liệu còn lại trong bảng lưu không thành công, bạn có muốn xem", "Thông báo thất bại", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Có thể trùng tên hiển thị, cmnd/cccd hoặc số điện thoại!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Dữ liệu mới");
                    table.Rows.Clear();
                    List<Staff> list = StaffBLL.getAllStaff();
                    Data(list);
                }
            }
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
                    (lưu ý không cần ghi file vào documents, chỉ cần đọc để lấy dữ liệu mới)
                1. dialog chọn file cần đăng tải mà người dùng đã tạo (xong)
                2. đọc dữ liệu file đã chọn và cập nhật thêm mới vào DB ()
         -----------------------------*/

        private void print_Click(object sender, System.EventArgs e)
        {
            Xls.Print("DHT.xlsx"); // sửa đúng tên và định dạng của tệp cần in
        }

        private void download_Click(object sender, System.EventArgs e)
        {
            //Xls.Download("DHT"); // sửa tên không cần định dạng
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];
            worksheet.Cells[1, 6] = "DANH SÁCH NHÂN VIÊN";
            Excel.Range titleHeaderRange = worksheet.Cells[1, 6];
            titleHeaderRange.Font.Name = "Times New Roman";
            titleHeaderRange.Font.Size = 16;
            titleHeaderRange.Font.Bold = true;
            titleHeaderRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;


            string[] title = new string[] { "ID", "Tên Hiển Thị", "CMND/CCCD", "HỌ VÀ TÊN", "NGÀY SINH", "GIỚI TÍNH", "BẰNG CẤP", "SỐ ĐIỆN THOẠI", "ĐỊA CHỈ", "CHỨC VỤ", "BẮT ĐẦU", "NGHỈ VIỆC" };
            for (int i = 0; i < title.Length; i++)
            {
                worksheet.Cells[3, i + 1].NumberFormat = "@";
                worksheet.Cells[3, i + 1] = title[i];
                Excel.Range titleRange = worksheet.Cells[3, i + 1];
                titleRange.Font.Name = "Times New Roman";
                titleRange.Font.Size = 12;
                titleRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                titleRange.Font.Bold = true;
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                titleRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataGridViewRow row = table.Rows[i];
                for (int k = 0; k < row.Cells.Count; k++)
                {
                    worksheet.Cells[i + 4, k + 1].NumberFormat = "@";
                    worksheet.Cells[i + 4, k + 1] = row.Cells[(k >= 10 && k < 13) ? k + 1 : k].Value;
                }
            }
            for (int columnIndex = 1; columnIndex <= table.Columns.Count; columnIndex++)
            {
                if (columnIndex == 4)
                {
                    worksheet.Columns[columnIndex].ColumnWidth = 20;
                    continue;
                }
                worksheet.Columns[columnIndex].ColumnWidth = 15;
            }
            excelApp.Visible = true;
            var saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Excel File";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();
            }

            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }

        private void upload_Click(object sender, System.EventArgs e)
        {
            table.Rows.Clear();
            Excel.Application excelApp = new Excel.Application();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                excelApp.Visible = true;
                string selectedFilePath = openFileDialog.FileName;
                Excel.Workbook workbook = excelApp.Workbooks.Open(selectedFilePath);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                Excel.Range usedRange = worksheet.UsedRange;
                int rowCount = usedRange.Rows.Count;


                for (int row = 4; row <= rowCount; row++)
                {
                    table.Rows.Add(
                        usedRange.Cells[row, 1].Value != null ? usedRange.Cells[row, 1].Value.ToString() : string.Empty,
                        usedRange.Cells[row, 2].Value != null ? usedRange.Cells[row, 2].Value.ToString() : string.Empty,
                        usedRange.Cells[row, 3].Value != null ? usedRange.Cells[row, 3].Value.ToString() : string.Empty,
                        usedRange.Cells[row, 4].Value != null ? usedRange.Cells[row, 4].Value.ToString() : string.Empty,
                        usedRange.Cells[row, 5].Value != null ? usedRange.Cells[row, 5].Value.ToString() : string.Empty,
                        usedRange.Cells[row, 6].Value != null ? usedRange.Cells[row, 6].Value.ToString() : string.Empty,
                        usedRange.Cells[row, 7].Value != null ? usedRange.Cells[row, 7].Value.ToString() : string.Empty,
                        usedRange.Cells[row, 8].Value != null ? usedRange.Cells[row, 8].Value.ToString() : string.Empty,
                        usedRange.Cells[row, 9].Value != null ? usedRange.Cells[row, 9].Value.ToString() : string.Empty,
                        usedRange.Cells[row, 10].Value != null ? usedRange.Cells[row, 10].Value.ToString() : string.Empty,
                        string.Empty,
                        usedRange.Cells[row, 11].Value != null ? usedRange.Cells[row, 11].Value.ToString() : string.Empty,
                        usedRange.Cells[row, 12].Value != null ? usedRange.Cells[row, 12].Value.ToString() : string.Empty
                    );
                }
                workbook.Close();
                excelApp.Quit();
                DialogResult result = MessageBox.Show("Bạn có muốn lưu tất cả không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    saveDatasUpload();
                }
                else
                {
                    MessageBox.Show("Không lưu dữ liệu", "Thông báo");
                }
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            try
            {
                AccountBLL.createDefautAccount(Convert.ToInt16(inpId.Text), inpContactNumber.Text, inpCitizenId.Text);
                MessageBox.Show("Tài khoản đã được tạo thành công\n" + "Username: " + inpCitizenId.Text + "\nPassword: " + inpContactNumber.Text);
                table.Rows.Clear();
                List<Staff> list = StaffBLL.getAllStaff();
                Data(list);
                comboBoxFilter.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản không được tạo thành công, có lẽ nhân viên đã bị xóa");
            }
        }
    }
}