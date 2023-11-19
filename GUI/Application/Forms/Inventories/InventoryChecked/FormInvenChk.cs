using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormInvenChk : Form
    {
        public FormInvenChk()
        {
            InitializeComponent();
        }

        private void table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormDetails().ShowDialog();
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            pnlSearch.Width = 300;
        }

        private void pnlSearch_MouseLeave(object sender, EventArgs e)
        {
            if (inpSearch.Text == "" && !inpSearch.Focused)
                pnlSearch.Width = 50;
        }
    }
}
