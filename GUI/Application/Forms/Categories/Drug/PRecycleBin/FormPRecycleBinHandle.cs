using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPRecycleBin : Form
    {
        private List<CateProduct> list = new List<CateProduct>();

        private void Reload()
        {
            table.Rows.Clear();
            int i = 0;
            foreach (CateProduct product in list)
            {
                table.Rows.Add(++i, product.Barcode, product.Name, false);
            }
            table.CurrentCell = null;
        }

        private void FormPRecycleBin_Load(object sender, System.EventArgs e)
        {
            list = ProductBUS.GetTrash();
            Reload();
        }

        private void restore_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (Convert.ToBoolean(table.Rows[i].Cells["choose"].Value))
                {
                    Int16.TryParse(table.Rows[i].Cells["id"].Value.ToString(), out var listIndex); // lay gia tri STT
                    ProductBUS.Recover(list[listIndex-1].Id);
                    FormCateDrug.list.Add(list[listIndex-1]);
                }
            }
            list = ProductBUS.GetTrash();
            Reload();
        }

        private void delete_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (Convert.ToBoolean(table.Rows[i].Cells["choose"].Value))
                {
                    Int16.TryParse(table.Rows[i].Cells["id"].Value.ToString(), out var listIndex); // lay gia tri STT
                    ProductBUS.DeleteTrash(list[listIndex-1].Id);
                }
            }
            list = ProductBUS.GetTrash();
            Reload();
        }
    }
}
