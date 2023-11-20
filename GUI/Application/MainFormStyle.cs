using System.Linq;
using System;
using System.Windows.Forms;
using System.Drawing;
using BLL;

namespace GUI
{
    public partial class MainForm : Form
    {
        private int x;

        private void SetDefault()
        {
            foreach (Button btn in Sidebar.Controls.OfType<Button>())
                btn.BackColor = Color.RoyalBlue;
            foreach (Button btn in cateMenu.Controls.OfType<Button>())
                btn.BackColor = Color.CornflowerBlue;
            foreach (Button btn in invenMenu.Controls.OfType<Button>())
                btn.BackColor = Color.CornflowerBlue;
            foreach (Button btn in transacMenu.Controls.OfType<Button>())
                btn.BackColor = Color.CornflowerBlue;
            category.BackColor = inventory.BackColor = transaction.BackColor = Color.RoyalBlue;
            if (!transaction.Visible)
                buy.BackColor = sell.BackColor = Color.RoyalBlue;
            foreach (Control ctrl in pnlAccount.Controls)
                ctrl.Visible = true;
        }

        private void CollapseMenu()
        {
            if (Sidebar.Width > 200)
            {
                Sidebar.Width = 100;
                logo.Visible = label1.Visible = false;
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
                foreach (Button btn in transacMenu.Controls.OfType<Button>())
                    btn.Padding = new Padding(29, 0, 0, 0);
            }
            else
            {
                Sidebar.Width = 370;
                logo.Visible = label1.Visible = true;
                menu.Dock = DockStyle.Right;
                foreach (Button btn in Sidebar.Controls.OfType<Button>())
                {
                    btn.Text = "                " + btn.Tag.ToString();
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(29, 0, 0, 0);
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
                foreach (Button btn in transacMenu.Controls.OfType<Button>())
                {
                    btn.Text = "                " + btn.Tag.ToString();
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(75, 0, 0, 0);
                }
                category.Padding = inventory.Padding = transaction.Padding = new Padding(29, 0, 0, 0);
                if (!transaction.Visible)
                    buy.Padding = sell.Padding = new Padding(29, 0, 0, 0);
            }
        }

        private void menu_Click(object sender, System.EventArgs e)
        {
            CollapseMenu();
        }

        private void ResetMenu()
        {
            if (Sidebar.Width > 200)
                CollapseMenu();
            if (cateMenu.Height > 100)
                CollapseCateMenu();
            if (invenMenu.Height > 100)
                CollapseInvenMenu();
            if (transacMenu.Height > 100)
                CollapseTransacMenu();
        }

        private void category_Click(object sender, EventArgs e)
        {
            SetDefault();
            if (Height < 900)
                invenMenu.Height = transacMenu.Height = 65;
            CollapseCateMenu();
        }

        private void CollapseCateMenu()
        {
            if (cateMenu.Height < 100)
                cateMenu.Height = 390 - 65 * x;
            else
                cateMenu.Height = 65;
        }

        private void inventory_Click(object sender, System.EventArgs e)
        {
            SetDefault();
            if (Height < 900)
                cateMenu.Height = transacMenu.Height = 65;
            else transacMenu.Height = 65;
            CollapseInvenMenu();
        }

        private void CollapseInvenMenu()
        {
            if (invenMenu.Height > 190)
                invenMenu.Height = 65;
            else
                invenMenu.Height = 195;
        }

        private void transaction_Click(object sender, EventArgs e)
        {
            SetDefault();
            if (Height < 900)
                cateMenu.Height = invenMenu.Height = 65;
            else invenMenu.Height = 65;
            CollapseTransacMenu();
        }

        private void CollapseTransacMenu()
        {
            if (transacMenu.Height > 190)
                transacMenu.Height = 65;
            else
                transacMenu.Height = 195;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (Height > 875)
            {
                if (WindowState != FormWindowState.Maximized)
                {
                    invenMenu.Height = transacMenu.Height = 65;
                    restore.Image = Properties.Resources.maximize;
                } else restore.Image = Properties.Resources.minimize;
                setting.Visible = roleUser == 0;
                cateMenu.Visible = true;
                invenMenu.Visible = roleUser != 2;
                transacMenu.Visible = true;
                menu.Enabled = true;
            }
            else if (Height > 810)
            {
                setting.Visible = false;
                cateMenu.Visible = true;
                invenMenu.Visible = roleUser != 2;
                transacMenu.Visible = true;
                menu.Enabled = true;
            }
            else if (Height > 745)
            {
                setting.Visible = false;
                cateMenu.Visible = true;
                invenMenu.Visible = false;
                transacMenu.Visible = true;
                menu.Enabled = true;
            }
            else if (Height > 680)
            {
                setting.Visible = false;
                cateMenu.Visible = true;
                invenMenu.Visible = false;
                transacMenu.Visible = roleUser != 0;
                menu.Enabled = true;
            }
            else if (Height > 615)
            {
                setting.Visible = roleUser == 0;
                cateMenu.Visible = false;
                invenMenu.Visible = roleUser != 2;
                transacMenu.Visible = true;
                menu.Enabled = true;
            }
            else if (Height > 550)
            {
                setting.Visible = false;
                cateMenu.Visible = false;
                invenMenu.Visible = roleUser != 2;
                transacMenu.Visible = true;
                menu.Enabled = true;
            }
            else if (Height > 485)
            {
                setting.Visible = false;
                cateMenu.Visible = false;
                invenMenu.Visible = false;
                transacMenu.Visible = true;
                menu.Enabled = true;
            }
            else
            {
                setting.Visible = roleUser == 0;
                transacMenu.Visible = roleUser != 0;
                menu.Enabled = false;
                ResetMenu();
            }
            username.Text = WindowState == FormWindowState.Maximized ? StaffBLL.getNickName(idUser) : " ";
        }
    }
}
