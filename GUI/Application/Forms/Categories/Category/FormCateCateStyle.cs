using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCateCate : Form
    {
        private void resetMenu()
        {
            foreach (PictureBox btn in panel2.Controls.OfType<PictureBox>())
            {
                btn.SizeMode = PictureBoxSizeMode.Zoom;
                btn.Padding = new Padding(20, 20, 20, 20);
                btn.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
