using DTO;
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
    public partial class IDetailsForm : Form
    {
        public ImportInvoice CurrentImportInvoice { get; set; }
        public IDetailsForm(ImportInvoice importInvoice)
        {
            InitializeComponent();
            CurrentImportInvoice = importInvoice;
            IDetailsForm_Load();
        }

        private void IDetailsForm_Load()
        {
            int i = 1;
            // Kiểm tra và sử dụng dữ liệu từ DetailsData để cập nhật DataGridView hoặc thực hiện các hành động khác
            if (CurrentImportInvoice != null)
            {
                BillTextboxI.Text = CurrentImportInvoice.Code.ToString();
                DateTextBoxI.Text = CurrentImportInvoice.DateInit.ToString();
                StaffTextboxI.Text = CurrentImportInvoice.StaffNickName.ToString();
                ProviderTextboxI.Text = CurrentImportInvoice.SupplierName.ToString();
                foreach (var item in CurrentImportInvoice.Details)
                {
                    IDetailsTable.Rows.Add(i++, item.Barcode, item.Name, item.MFGDate, item.EXPDate, item.Unit, item.Number, item.ImportPrice);
                }
            }
            else
            {
                MessageBox.Show("Không có");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
