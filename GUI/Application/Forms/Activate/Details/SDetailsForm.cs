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
		public List<SaleDetail> DetailsData { get; set; }
		public SDetailsForm()
		{
			InitializeComponent();
		}

		private void SDetailsForm_Load(object sender, EventArgs e)
		{
			// Kiểm tra và sử dụng dữ liệu từ DetailsData để cập nhật DataGridView hoặc thực hiện các hành động khác
			if (DetailsData != null)
			{
				foreach (var item in DetailsData)
				{
					DetailsTable.Rows.Add(item.Barcode, item.Name, item.Unit, item.UnitPrice, item.Number);
				}
			}
		}
	}
}
