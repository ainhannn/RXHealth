using GUI.Handle;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPRecycleBin : Form
    {
        public FormPRecycleBin()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FormPRecycleBin_MouseDown(object sender, MouseEventArgs e)
        {
            HandleGUI.ReleaseCapture();
            HandleGUI.SendMessage(Handle, 0x112, 0xf012, 8);
        }
    }
}
