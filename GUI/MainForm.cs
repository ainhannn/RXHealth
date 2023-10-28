using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        private bool isResizing = false;
        private int borderSize = 100;
        private Size formSize;
        public MainForm()
        {
            InitializeComponent();
            CollapseMenu();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 8);
            if (Sidebar.Width > 200)
                CollapseMenu();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_RESTORE = 0xF120;
            const int WM_NCHITTEST = 0x0084;
            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                if (WindowState == FormWindowState.Normal)
                {
                    Point screenPoint = new Point(m.LParam.ToInt32());
                    Point clientPoint = PointToClient(screenPoint);

                    if (clientPoint.X <= borderSize && clientPoint.Y <= borderSize)
                        m.Result = (IntPtr)HTTOPLEFT;
                    else if (clientPoint.X >= Width - borderSize && clientPoint.Y <= borderSize)
                        m.Result = (IntPtr)HTTOPRIGHT;
                    else if (clientPoint.X <= borderSize && clientPoint.Y >= Height - borderSize)
                        m.Result = (IntPtr)HTBOTTOMLEFT;
                    else if (clientPoint.X >= Width - borderSize && clientPoint.Y >= Height - borderSize)
                        m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else if (clientPoint.Y <= borderSize)
                        m.Result = (IntPtr)HTTOP;
                    else if (clientPoint.Y >= Height - borderSize)
                        m.Result = (IntPtr)HTBOTTOM;
                    else if (clientPoint.X <= borderSize)
                        m.Result = (IntPtr)HTLEFT;
                    else if (clientPoint.X >= Width - borderSize)
                        m.Result = (IntPtr)HTRIGHT;
                    else
                        m.Result = (IntPtr)HTCLIENT;
                }
                return;
            }

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)
                    formSize = ClientSize;
                if (wParam == SC_RESTORE)
                    Size = formSize;
            }

            base.WndProc(ref m);
        }

        private Point lastMousePosition = Point.Empty;
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                lastMousePosition = e.Location;
                isResizing = true;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;
                Size = new Size(Width + deltaX, Height + deltaY);
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isResizing = false;
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
            {
                WindowState = FormWindowState.Normal;
                restore.Image = Properties.Resources.maximize;
                if(Sidebar.Width > 200)
                    CollapseMenu();
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                restore.Image = Properties.Resources.minimize;
            }
        }

        private void CollapseMenu()
        {
            if (Sidebar.Width > 200)
            {
                Sidebar.Width = 100;
                logo.Visible = false;
                label1.Visible = false;
                menu.Dock = DockStyle.Top;
                foreach (Button menuButton in Sidebar.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                Sidebar.Width = 370;
                logo.Visible = true;
                label1.Visible = true;
                menu.Dock = DockStyle.None;
                foreach (Button menuButton in Sidebar.Controls.OfType<Button>())
                {
                    menuButton.Text = "                " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(29,0,0,0);
                }
            }
            if (cateMenu.Height > 100)
                CollapseCateMenu();
            if (invenMenu.Height > 100)
                CollapseInvenMenu();
        }

        private void menu_Click(object sender, System.EventArgs e)
        {
            CollapseMenu();
            cateMenu.Height = invenMenu.Height = 65;
        }

        private void logout_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                new LoginForm().Show();
            }
        }

        private void category_Click(object sender, System.EventArgs e)
        {
            if (Sidebar.Width < 200)
                CollapseMenu();
            CollapseCateMenu();
        }

        private void CollapseCateMenu()
        {
            if (invenMenu.Height > 190)
                invenMenu.Height = 65;
            if (cateMenu.Height < 100)
                cateMenu.Height = 390;
            else
                cateMenu.Height = 65;
        }

        private void inventory_Click(object sender, System.EventArgs e)
        {
            if (Sidebar.Width < 200)
                CollapseMenu();
            CollapseInvenMenu();
        }

        private void CollapseInvenMenu()
        {
            if (cateMenu.Height > 380)
                cateMenu.Height = 65;
            if (invenMenu.Height > 190)
                invenMenu.Height = 65;
            else
                invenMenu.Height = 195;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (Height > 859)
            {
                setting.Visible = true;
                cateMenu.Visible = true;
                invenMenu.Visible = true;
                menu.Enabled = true;
            }
            else if (Height > 794)
            {
                setting.Visible = false;
                cateMenu.Visible = true;
                invenMenu.Visible = true;
                menu.Enabled = true;
            }
            else if (Height > 534)
            {
                cateMenu.Visible = false;
                invenMenu.Visible = true;
                menu.Enabled = true;
            }
            else
            {
                invenMenu.Visible = false;
                if (Sidebar.Width > 200)
                    CollapseMenu();
                menu.Enabled = false;
            }
        }
    }
}
