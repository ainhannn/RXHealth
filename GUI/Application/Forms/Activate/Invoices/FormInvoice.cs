using GUI.Handle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormInvoice_MouseDown(object sender, MouseEventArgs e)
        {
            HandleGUI.ReleaseCapture();
            HandleGUI.SendMessage(Handle, 0x112, 0xf012, 8);
        }
    }
}
