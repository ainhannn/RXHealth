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
	public partial class SDetailsForm : Form
	{
        public SaleInvoice CurrentSaleInvoice { get; set; }
        //public List<SaleDetail> SDetailsData { get; set; }
		public SDetailsForm(SaleInvoice saleInvoice)
		{
			InitializeComponent();
            CurrentSaleInvoice = saleInvoice;
            //SDetailsData = sDetailsData;
            SDetailsForm_Load();
        }

        private void SDetailsForm_Load()
		{
			int i = 1;
			// Kiểm tra và sử dụng dữ liệu từ DetailsData để cập nhật DataGridView hoặc thực hiện các hành động khác
			if (CurrentSaleInvoice != null)
			{
				BillTextbox.Text = CurrentSaleInvoice.Code.ToString();
                DateTextBox.Text = CurrentSaleInvoice.DateInit.ToString();
                CustomerTextbox.Text = CurrentSaleInvoice.CustomerName.ToString();
                StaffTextbox.Text = CurrentSaleInvoice.StaffNickName.ToString();
                foreach (var item in CurrentSaleInvoice.Details)
				{
					MessageBox.Show("Thành công");
					SDetailsTable.Rows.Add(i++, item.Name, item.Unit, item.UnitPrice, item.Number);
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
