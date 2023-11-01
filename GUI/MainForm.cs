using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        FormSell fmSell;
        FormStaff fmStaff;
        public MainForm()
        {
            InitializeComponent();
            CollapseMenu();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 8);
            if (WindowState == FormWindowState.Maximized)
            {
                restore.Image = Properties.Resources.minimize;
                ResetMenu();
            } else restore.Image = Properties.Resources.maximize;
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
        }

        private void menu_Click(object sender, System.EventArgs e)
        {
            CollapseMenu();
            if (cateMenu.Height > 100)
                CollapseCateMenu();
            if (invenMenu.Height > 100)
                CollapseInvenMenu();
        }

        private void ResetMenu()
        {
            if(Sidebar.Width > 200)
                CollapseMenu();
            if (cateMenu.Height > 100)
                CollapseCateMenu();
            if (invenMenu.Height > 100)
                CollapseInvenMenu();
        }

        private void logout_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                new LoginForm().Show();
            }
        }

        private void category_Click(object sender, EventArgs e)
        {
            SetDefaultColorButton();
            category.BackColor = Color.Navy;
            if (Sidebar.Width < 200)
                CollapseMenu();
            CollapseCateMenu();
        }

        private void CollapseCateMenu()
        {
            if (WindowState != FormWindowState.Maximized)
                invenMenu.Height = 65;
            if (cateMenu.Height < 100)
                cateMenu.Height = 390;
            else
                cateMenu.Height = 65;
        }

        private void inventory_Click(object sender, System.EventArgs e)
        {
            SetDefaultColorButton();
            inventory.BackColor = Color.Navy;
            if (Sidebar.Width < 200)
                CollapseMenu();
            CollapseInvenMenu();
        }

        private void CollapseInvenMenu()
        {
            if (WindowState != FormWindowState.Maximized)
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
            else if (Height > 795)
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
                ResetMenu();
                menu.Enabled = false;
            }
        }

        private void SetDefaultColorButton()
        {
            statistic.BackColor = Color.RoyalBlue;
            category.BackColor = Color.RoyalBlue;
            sell.BackColor = Color.RoyalBlue;
            cateCate.BackColor = Color.CornflowerBlue;
            cateIngre.BackColor = Color.CornflowerBlue;
            cateDrug.BackColor = Color.CornflowerBlue;
            cateProvi.BackColor = Color.CornflowerBlue;
            cateCus.BackColor = Color.CornflowerBlue;
            inventory.BackColor = Color.RoyalBlue;
            invenImp.BackColor = Color.CornflowerBlue;
            invenChk.BackColor = Color.CornflowerBlue;
            staff.BackColor = Color.RoyalBlue;
            setting.BackColor = Color.RoyalBlue;
        }

        private void statistic_Click(object sender, EventArgs e)
        {
            SetDefaultColorButton();
            statistic.BackColor = Color.Navy;
        }

        private void cateCate_Click(object sender, EventArgs e)
        {
            SetDefaultColorButton();
            cateCate.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
        }

        private void cateIngre_Click(object sender, EventArgs e)
        {
            SetDefaultColorButton();
            cateIngre.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
        }

        private void cateDrug_Click(object sender, EventArgs e)
        {
            SetDefaultColorButton();
            cateDrug.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
        }

        private void cateProvi_Click(object sender, EventArgs e)
        {
            SetDefaultColorButton();
            cateProvi.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
        }

        private void cateCus_Click(object sender, EventArgs e)
        {
            SetDefaultColorButton();
            cateCus.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
        }

        private void invenImp_Click(object sender, EventArgs e)
        {
            SetDefaultColorButton();
            invenImp.BackColor = Color.LightSteelBlue;
            inventory.BackColor = Color.Navy;
        }

        private void invenChk_Click(object sender, EventArgs e)
        {
            SetDefaultColorButton();
            invenChk.BackColor = Color.LightSteelBlue;
            inventory.BackColor = Color.Navy;
        }

        private void sell_Click(object sender, EventArgs e)
        {
            formTitle.Text = "Quản Lý Bán Hàng";
            SetDefaultColorButton();
            sell.BackColor = Color.Navy;
            if (fmSell == null)
            {
                fmSell = new FormSell();
                fmSell.FormClosed += FormSell_FormClosed;
                fmSell.MdiParent = this;
                fmSell.Dock = DockStyle.Fill;
                fmSell.Show();
            }
            else
                fmSell.Activate();
        }

        private void FormSell_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmSell = null;
        }

        private void staff_Click(object sender, EventArgs e)
        {
            formTitle.Text = "Quản Lý Nhân Sự";
            SetDefaultColorButton();
            staff.BackColor = Color.Navy;
            if(fmStaff == null)
            {
                fmStaff = new FormStaff();
                fmStaff.FormClosed += FormStaff_FormClosed;
                fmStaff.MdiParent = this;
                fmStaff.Dock = DockStyle.Fill;
                fmStaff.Show();
            }
            else
                fmStaff.Activate();
        }

        private void FormStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmStaff = null;
        }

        private void setting_Click(object sender, EventArgs e)
        {
            SetDefaultColorButton();
            setting.BackColor = Color.Navy;
        }
    }
}
