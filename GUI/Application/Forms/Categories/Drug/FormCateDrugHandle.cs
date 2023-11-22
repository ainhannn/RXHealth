using DTO;
using BLL;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GUI
{
    public partial class FormCateDrug : Form
    {
        private void LoadIntoTable(List<Product> products)
        {

        }

        private void FormCateDrug_Load(object sender, EventArgs e)
        {
            LoadIntoTable(ProductBUS.SelectAll());
        }

        private void table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormPDetails().ShowDialog();
        }

        private void RecycleBin_Click(object sender, System.EventArgs e)
        {
            new FormPRecycleBin().ShowDialog();
        }


    }
}
