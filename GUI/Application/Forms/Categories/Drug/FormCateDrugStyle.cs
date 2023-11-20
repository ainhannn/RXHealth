using System.Windows.Forms;

namespace GUI
{
    public partial class FormCateDrug : Form
    {
        private ToolTip toolTip;
        private void InitializeToolTip()
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(RecycleBin, "Products Recycle Bin");
        }
    }
}
