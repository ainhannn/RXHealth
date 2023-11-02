using System.Drawing.Printing;
using System.Windows.Forms;
using System;
using Spire.Xls;
using System.IO;

namespace GUI
{
    internal class Handle
    {
        public Handle() { }

        public void Print(string path)
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

        public void Download(string path)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.FileName = path;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                try
                {
                    File.Copy(@"..\..\..\documents\" + path, savePath, true);
                    MessageBox.Show("Tải tệp Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Upload(OpenFileDialog openFileDialog)
        {
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Select an Excel file to upload";
        }
    }
}
