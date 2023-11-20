using GUI.Handle;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDetails : Form
    {
        public FormDetails()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDetails_MouseDown(object sender, MouseEventArgs e)
        {
            HandleGUI.ReleaseCapture();
            HandleGUI.SendMessage(Handle, 0x112, 0xf012, 8);
        }
    }
}
