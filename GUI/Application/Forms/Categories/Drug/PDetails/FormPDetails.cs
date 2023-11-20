using System.Drawing;
using System.Windows.Forms;
using System.IO;
using GUI.Handle;

namespace GUI
{
    public partial class FormPDetails : Form
    {
        public FormPDetails()
        {
            InitializeComponent();
        }

        private void FormPDetails_MouseDown(object sender, MouseEventArgs e)
        {
            HandleGUI.ReleaseCapture();
            HandleGUI.SendMessage(this.Handle, 0x112, 0xf012, 8);
        }
        private void exit_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
