using GUI.Components;
using GUI.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        FormStatistic fmStatistic;
        FormCateCate fmCateCate;
        FormCateIngre fmCateIngre;
        FormCateDrug fmCateDrug;
        FormCateProvi fmCateProvi;
        FormCateCus fmCateCus;
        FormInvenImp fmInvenImp;
        FormInvenChk fmInvenChk;
        FormSell fmSell;
        FormStaff fmStaff;
        FormAccount fmAccount;
        FormSetting fmSetting;

        public MainForm()
        {
            InitializeComponent();
            ResetMenu();
            SetStyle(ControlStyles.ResizeRedraw, true);
            username.Text = LoginForm.username;
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            HandleGUI.ReleaseCapture();
            HandleGUI.SendMessage(Handle, 0x112, 0xf012, 8);
            if (WindowState == FormWindowState.Maximized)
            {
                restore.Image = Properties.Resources.minimize;
                ResetMenu();
            } else restore.Image = Properties.Resources.maximize;
        }

        // Control Box
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

        private void logout_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                new LoginForm().Show();
            }
        }

        // Responsive
        private void CollapseMenu()
        {
            if (Sidebar.Width > 200)
            {
                Sidebar.Width = 100;
                logo.Visible = false;
                label1.Visible = false;
                menu.Dock = DockStyle.Top;
                foreach (Button btn in Sidebar.Controls.OfType<Button>())
                {
                    btn.Text = "";
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.Padding = new Padding(0);
                }
                foreach (Button btn in cateMenu.Controls.OfType<Button>())
                    btn.Padding = new Padding(29, 0, 0, 0);
                foreach (Button btn in invenMenu.Controls.OfType<Button>())
                    btn.Padding = new Padding(29, 0, 0, 0);
            }
            else
            {
                Sidebar.Width = 370;
                logo.Visible = true;
                label1.Visible = true;
                menu.Dock = DockStyle.Right;
                foreach (Button btn in Sidebar.Controls.OfType<Button>())
                {
                    btn.Text = "                " + btn.Tag.ToString();
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(29,0,0,0);
                }
                foreach (Button btn in cateMenu.Controls.OfType<Button>())
                {
                    btn.Text = "                " + btn.Tag.ToString();
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(75, 0, 0, 0);
                }
                foreach (Button btn in invenMenu.Controls.OfType<Button>())
                {
                    btn.Text = "                " + btn.Tag.ToString();
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(75, 0, 0, 0);
                }
                category.Padding = new Padding(29, 0, 0, 0);
                inventory.Padding = new Padding(29, 0, 0, 0);
            }
        }

        private void menu_Click(object sender, System.EventArgs e)
        {
            CollapseMenu();
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

        private void category_Click(object sender, EventArgs e)
        {
            SetDefault();
            if (Height < 1000)
                invenMenu.Height = 65;
            CollapseCateMenu();
        }

        private void CollapseCateMenu()
        {
            if (Height < 795)
                invenMenu.Height = 65;
            if (cateMenu.Height < 100)
                cateMenu.Height = 390;
            else
                cateMenu.Height = 65;
        }

        private void inventory_Click(object sender, System.EventArgs e)
        {
            SetDefault();
            if (Height < 1000)
                cateMenu.Height = 65;
            CollapseInvenMenu();
        }

        private void CollapseInvenMenu()
        {
            if (Height < 795)
                cateMenu.Height = 65;
            if (invenMenu.Height > 190)
                invenMenu.Height = 65;
            else
                invenMenu.Height = 195;
        }

        private void SetDefault()
        {
            foreach (Button btn in Sidebar.Controls.OfType<Button>())
                btn.BackColor = Color.RoyalBlue;
            foreach (Button btn in cateMenu.Controls.OfType<Button>())
                btn.BackColor = Color.CornflowerBlue;
            foreach (Button btn in invenMenu.Controls.OfType<Button>())
                btn.BackColor = Color.CornflowerBlue;
            category.BackColor = Color.RoyalBlue;
            inventory.BackColor = Color.RoyalBlue;
            foreach (Control ctrl in pnlAccount.Controls)
                ctrl.Visible = true;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (Height > 870)
            {
                if (Height < 1005 && Height > 1000 && invenMenu.Height > 100)
                    invenMenu.Height = 65;
                setting.Visible = true;
                cateMenu.Visible = true;
                invenMenu.Visible = true;
                menu.Enabled = true;
            }
            else if (Height > 805)
            {
                setting.Visible = false;
                cateMenu.Visible = true;
                invenMenu.Visible = true;
                menu.Enabled = true;
            }
            else if (Height > 740)
            {
                setting.Visible = false;
                cateMenu.Visible = true;
                invenMenu.Visible = false;
                menu.Enabled = true;
            }
            else if (Height > 600)
            {
                setting.Visible = true;
                cateMenu.Visible = false;
                invenMenu.Visible = true;
                menu.Enabled = true;
            }
            else if (Height > 535)
            {
                setting.Visible = false;
                cateMenu.Visible = false;
                invenMenu.Visible = true;
                menu.Enabled = true;
            }
            else
            {
                invenMenu.Visible = false;
                menu.Enabled = false;
                ResetMenu();
            }
            username.Text = WindowState == FormWindowState.Maximized ? LoginForm.username : " ";
        }

        // Navigate
        private void statistic_Click(object sender, EventArgs e)
        {
            SetDefault();
            statistic.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Báo Cáo Thống Kê", fmStatistic, new FormStatistic(), this);
        }

        private void cateCate_Click(object sender, EventArgs e)
        {
            SetDefault();
            cateCate.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Danh Mục", fmCateCate, new FormCateCate(), this);
        }

        private void cateIngre_Click(object sender, EventArgs e)
        {
            SetDefault();
            cateIngre.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Hoạt Chất", fmCateIngre, new FormCateIngre(), this);
        }

        private void cateDrug_Click(object sender, EventArgs e)
        {
            SetDefault();
            cateDrug.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Sản Phẩm", fmCateDrug, new FormCateDrug(), this);
        }

        private void cateProvi_Click(object sender, EventArgs e)
        {
            SetDefault();
            cateProvi.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Nhà Cung Cấp", fmCateProvi, new FormCateProvi(), this);
        }

        private void cateCus_Click(object sender, EventArgs e)
        {
            SetDefault();
            cateCus.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Quản Lý Khách Hàng", fmCateCus, new FormCateCus(), this);
        }

        private void invenImp_Click(object sender, EventArgs e)
        {
            SetDefault();
            invenImp.BackColor = Color.LightSteelBlue;
            inventory.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Nhập Kho", fmInvenImp, new FormInvenImp(), this);
        }

        private void invenChk_Click(object sender, EventArgs e)
        {
            SetDefault();
            invenChk.BackColor = Color.LightSteelBlue;
            inventory.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Kiểm Kho", fmInvenChk, new FormInvenChk(), this);
        }

        private void sell_Click(object sender, EventArgs e)
        {
            SetDefault();
            sell.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Quản Lý Bán Hàng", fmSell, new FormSell(), this);
        }

        private void staff_Click(object sender, EventArgs e)
        {
            SetDefault();
            staff.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Quản Lý Nhân Sự", fmStaff, new FormStaff(), this);
        }

        private void username_Click(object sender, EventArgs e)
        {
            SetDefault();
            foreach (Control ctrl in pnlAccount.Controls)
                ctrl.Visible = false;
            Navigate.Form(formTitle, "Thông Tin Cá Nhân", fmAccount, new FormAccount(), this);
        }

        private void setting_Click(object sender, EventArgs e)
        {
            SetDefault();
            setting.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Cài Đặt Chung", fmSetting, new FormSetting(), this);
        }
    }
}
