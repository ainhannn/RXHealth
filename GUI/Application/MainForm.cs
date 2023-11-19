using BLL;
using GUI.Handle;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        private int idUser;
        private int roleUser;
        public MainForm(int idUser, int roleUser)
        {
            InitializeComponent();
            this.idUser = idUser;
            SetStyle(ControlStyles.ResizeRedraw, true);
            this.roleUser = roleUser;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetMenu();
            string path = AccountBLL.getAvatarAccount(idUser);
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
                avatar.Image = new Bitmap(path);
            username.Text = StaffBLL.getNickName(idUser);
            if (roleUser == 0)
                return;
            else if (roleUser == 1) // Warehouse Manager
            {
                foreach (Button btn in Sidebar.Controls.OfType<Button>())
                    btn.Visible = false;
                logout.Visible = true;
                foreach (Button btn in cateMenu.Controls.OfType<Button>())
                    btn.Visible = true;
                x = 1;
                cateCus.Visible = false;
                foreach (Button btn in invenMenu.Controls.OfType<Button>())
                    btn.Visible = true;
                foreach (Button btn in transacMenu.Controls.OfType<Button>())
                    btn.Visible = false;
                buy.Visible = true;
                buy.BackColor = Color.RoyalBlue;
            }
            else if (roleUser == 2) // Saler
            {
                foreach (Button btn in Sidebar.Controls.OfType<Button>())
                    btn.Visible = false;
                logout.Visible = true;
                foreach (Button btn in cateMenu.Controls.OfType<Button>())
                    btn.Visible = true;
                x = 1;
                cateProvi.Visible = false;
                foreach (Button btn in invenMenu.Controls.OfType<Button>())
                    btn.Visible = false;
                invenMenu.Visible = false;
                foreach (Button btn in transacMenu.Controls.OfType<Button>())
                    btn.Visible = false;
                sell.Visible = true;
                sell.BackColor = Color.RoyalBlue;
            }
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            HandleGUI.ReleaseCapture();
            HandleGUI.SendMessage(Handle, 0x112, 0xf012, 8);
            if (WindowState == FormWindowState.Maximized)
                restore.Image = Properties.Resources.minimize;
            else restore.Image = Properties.Resources.maximize;
        }

        // Control Box
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void restore_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ResetMenu();
                WindowState = FormWindowState.Normal;
                Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
                restore.Image = Properties.Resources.maximize;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                restore.Image = Properties.Resources.minimize;
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                new LoginForm().Show();
            }
        }
    }
}
