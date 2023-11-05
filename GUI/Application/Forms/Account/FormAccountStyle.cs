using System.Windows.Forms;

namespace GUI
{
    public partial class FormAccount : Form
    {
        private void FormAccount_Resize(object sender, System.EventArgs e)
        {
            form.Visible = Height > 900 && Width > 1100;
            avtForm.Visible = Height > 700;
        }
    }
}
