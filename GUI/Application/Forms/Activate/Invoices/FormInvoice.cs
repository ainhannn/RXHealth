using BLL;
using DTO;
using GUI.Handle;
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
    public partial class FormInvoice : Form
    {
        SaleBUS SBUS = new SaleBUS();
        public FormInvoice()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormInvoice_MouseDown(object sender, MouseEventArgs e)
        {
            HandleGUI.ReleaseCapture();
            HandleGUI.SendMessage(Handle, 0x112, 0xf012, 8);
        }

		private void LoadDataTable()
		{
			BillTable.RowCount = 1;
			int STT = 1;
			foreach (SaleInvoice cus in SBUS.getSelectAllForm())
			{
				BillTable.Rows.Add(STT, cus.DateInit, cus.StaffNickName, cus.CustomerName, cus.TotalAmount);
				STT++;

			}
		}

	}
}
