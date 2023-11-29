using System.Drawing.Printing;
using System.Windows.Forms;
using System;
using Spire.Xls;
using System.IO;
using OfficeOpenXml;

namespace GUI
{
    internal class Xls
    {
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

        public static void Print(string path)
        {
            try
            {
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(@"..\..\..\documents\" + path);

                PageSetup pageSetup = workbook.Worksheets[0].PageSetup;
                pageSetup.IsFitToPage = true;

                PrintDialog dialog = new PrintDialog();
                dialog.AllowCurrentPage = true;
                dialog.AllowSomePages = true;
                dialog.AllowSelection = true;
                dialog.UseEXDialog = true;
                dialog.PrinterSettings.Duplex = Duplex.Simplex;
                workbook.PrintDialog = dialog;
                PrintDocument printDocument = workbook.PrintDocument;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Download(string srcName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            saveFileDialog.FileName = srcName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                try
                {
                    File.Copy(@"..\..\..\documents\"+ srcName, savePath, true);
                    MessageBox.Show("Tải tệp Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static Worksheet Upload()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Select an Excel file to upload";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                try
                {
                    Workbook workbook = new Workbook();
                    workbook.LoadFromFile(selectedFilePath);

                    if (workbook != null && workbook.Worksheets.Count > 0)
                        return workbook.Worksheets[0];
                }
                catch { }
            }
            return null;
        }
    }
}
