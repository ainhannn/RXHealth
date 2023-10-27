using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
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
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void CollapseMenu()
        {
            if (Sidebar.Width > 200)
            {
                Sidebar.Width = 150;
                logo.Visible = false;
                label1.Visible = false;
                menu.Dock = DockStyle.Top;
                foreach (Button menuButton in Sidebar.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0,10,0,10);
                }
            }
            else
            {
                Sidebar.Width = 400;
                logo.Visible = true;
                label1.Visible = true;
                menu.Dock = DockStyle.None;
                foreach (Button menuButton in Sidebar.Controls.OfType<Button>())
                {
                    menuButton.Text = "                " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(25,0,0,0);
                }
            }
        }

        private void menu_Click(object sender, System.EventArgs e)
        {
            CollapseMenu();
        }
    }
}
