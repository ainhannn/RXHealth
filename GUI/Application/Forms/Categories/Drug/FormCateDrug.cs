using System.Windows.Forms;

namespace GUI
{
    public partial class FormCateDrug : Form
    {
        private System.Windows.Forms.ToolTip toolTip;
        public FormCateDrug()
        {
            InitializeComponent();
            InitializeToolTip();
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormPDetails().ShowDialog();
        }

        private void InitializeToolTip()
        {
            toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(RecycleBin, "Products Recycle Bin");
        }
    }
}
