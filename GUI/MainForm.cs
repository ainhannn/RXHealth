using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        private bool isMaximized = true;
        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 8);
        }

        private void close_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void restore_Click(object sender, System.EventArgs e)
        {
            if (isMaximized)
            {
                WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
        }
    }
}
