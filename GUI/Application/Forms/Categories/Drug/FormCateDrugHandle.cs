using System.Windows.Forms;

namespace GUI
{
    public partial class FormCateDrug : Form
    {
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
