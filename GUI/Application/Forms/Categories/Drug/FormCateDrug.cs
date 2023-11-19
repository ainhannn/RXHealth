using System.Windows.Forms;

namespace GUI
{
    public partial class FormCateDrug : Form
    {
        public FormCateDrug()
        {
            InitializeComponent();
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormPDetails().ShowDialog();
        }
    }
}
