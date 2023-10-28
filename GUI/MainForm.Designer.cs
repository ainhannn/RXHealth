using System.Configuration;

namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Main = new System.Windows.Forms.Panel();
            this.setting = new System.Windows.Forms.Button();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.invenMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.cateMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.sell = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.statistic = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.restore = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Sidebar.SuspendLayout();
            this.invenMenu.SuspendLayout();
            this.cateMenu.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            resources.ApplyResources(this.Main, "Main");
            this.Main.Name = "Main";
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.RoyalBlue;
            this.setting.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.setting, "setting");
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.ForeColor = System.Drawing.Color.White;
            this.setting.Image = global::GUI.Properties.Resources.settings_gears;
            this.setting.Name = "setting";
            this.setting.Tag = "Cài Đặt";
            this.setting.UseVisualStyleBackColor = false;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Sidebar.Controls.Add(this.button1);
            this.Sidebar.Controls.Add(this.invenMenu);
            this.Sidebar.Controls.Add(this.cateMenu);
            this.Sidebar.Controls.Add(this.sell);
            this.Sidebar.Controls.Add(this.setting);
            this.Sidebar.Controls.Add(this.logout);
            this.Sidebar.Controls.Add(this.statistic);
            this.Sidebar.Controls.Add(this.pnl);
            resources.ApplyResources(this.Sidebar, "Sidebar");
            this.Sidebar.Name = "Sidebar";
            // 
            // invenMenu
            // 
            this.invenMenu.Controls.Add(this.inventory);
            this.invenMenu.Controls.Add(this.button16);
            this.invenMenu.Controls.Add(this.button17);
            resources.ApplyResources(this.invenMenu, "invenMenu");
            this.invenMenu.Name = "invenMenu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::GUI.Properties.Resources.team_management;
            this.button1.Name = "button1";
            this.button1.Tag = "Nhân Sự";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button17, "button17");
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Image = global::GUI.Properties.Resources.quality_control;
            this.button17.Name = "button17";
            this.button17.Tag = "";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button16, "button16");
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Image = global::GUI.Properties.Resources.import;
            this.button16.Name = "button16";
            this.button16.Tag = "";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // inventory
            // 
            this.inventory.BackColor = System.Drawing.Color.RoyalBlue;
            this.inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.inventory, "inventory");
            this.inventory.FlatAppearance.BorderSize = 0;
            this.inventory.ForeColor = System.Drawing.Color.White;
            this.inventory.Image = global::GUI.Properties.Resources.stock;
            this.inventory.Name = "inventory";
            this.inventory.Tag = "";
            this.inventory.UseVisualStyleBackColor = false;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // cateMenu
            // 
            this.cateMenu.Controls.Add(this.category);
            this.cateMenu.Controls.Add(this.button13);
            this.cateMenu.Controls.Add(this.button14);
            this.cateMenu.Controls.Add(this.button3);
            this.cateMenu.Controls.Add(this.button4);
            this.cateMenu.Controls.Add(this.button5);
            resources.ApplyResources(this.cateMenu, "cateMenu");
            this.cateMenu.Name = "cateMenu";
            // 
            // sell
            // 
            this.sell.BackColor = System.Drawing.Color.RoyalBlue;
            this.sell.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.sell, "sell");
            this.sell.FlatAppearance.BorderSize = 0;
            this.sell.ForeColor = System.Drawing.Color.White;
            this.sell.Image = global::GUI.Properties.Resources.trolley;
            this.sell.Name = "sell";
            this.sell.Tag = "Bán Hàng";
            this.sell.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button5, "button5");
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::GUI.Properties.Resources.customer_service;
            this.button5.Name = "button5";
            this.button5.Tag = "";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // statistic
            // 
            this.statistic.BackColor = System.Drawing.Color.RoyalBlue;
            this.statistic.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.statistic, "statistic");
            this.statistic.FlatAppearance.BorderSize = 0;
            this.statistic.ForeColor = System.Drawing.Color.White;
            this.statistic.Image = global::GUI.Properties.Resources.dashboard;
            this.statistic.Name = "statistic";
            this.statistic.Tag = "Hoạt Động";
            this.statistic.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.RoyalBlue;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.logout, "logout");
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Image = global::GUI.Properties.Resources.logout;
            this.logout.Name = "logout";
            this.logout.Tag = "Đăng Xuất";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button4, "button4");
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::GUI.Properties.Resources.take_medicines;
            this.button4.Name = "button4";
            this.button4.Tag = "";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::GUI.Properties.Resources.drugs;
            this.button3.Name = "button3";
            this.button3.Tag = "";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button14, "button14");
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Image = global::GUI.Properties.Resources.herb;
            this.button14.Name = "button14";
            this.button14.Tag = "";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button13, "button13");
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = global::GUI.Properties.Resources.production;
            this.button13.Name = "button13";
            this.button13.Tag = "Bán Hàng";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.RoyalBlue;
            this.category.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.category, "category");
            this.category.FlatAppearance.BorderSize = 0;
            this.category.ForeColor = System.Drawing.Color.White;
            this.category.Image = global::GUI.Properties.Resources.categorization;
            this.category.Name = "category";
            this.category.Tag = "";
            this.category.UseVisualStyleBackColor = false;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl.Controls.Add(this.menu);
            this.pnl.Controls.Add(this.label1);
            this.pnl.Controls.Add(this.logo);
            resources.ApplyResources(this.pnl, "pnl");
            this.pnl.Name = "pnl";
            // 
            // logo
            // 
            this.logo.Image = global::GUI.Properties.Resources.RXlogo;
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.RoyalBlue;
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.menu, "menu");
            this.menu.Image = global::GUI.Properties.Resources.main_menu;
            this.menu.Name = "menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // restore
            // 
            resources.ApplyResources(this.restore, "restore");
            this.restore.BackColor = System.Drawing.Color.RoyalBlue;
            this.restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restore.FlatAppearance.BorderSize = 0;
            this.restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.restore.Image = global::GUI.Properties.Resources.minimize;
            this.restore.Name = "restore";
            this.restore.UseVisualStyleBackColor = false;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.close);
            this.Header.Controls.Add(this.minimize);
            this.Header.Controls.Add(this.restore);
            resources.ApplyResources(this.Header, "Header");
            this.Header.Name = "Header";
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // minimize
            // 
            resources.ApplyResources(this.minimize, "minimize");
            this.minimize.BackColor = System.Drawing.Color.MediumAquamarine;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimize.Image = global::GUI.Properties.Resources.minimize1;
            this.minimize.Name = "minimize";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            resources.ApplyResources(this.close, "close");
            this.close.BackColor = System.Drawing.Color.Crimson;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close.Image = global::GUI.Properties.Resources.close;
            this.close.Name = "close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.button8, "button8");
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::GUI.Properties.Resources.bill;
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.Sidebar.ResumeLayout(false);
            this.invenMenu.ResumeLayout(false);
            this.cateMenu.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel invenMenu;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.FlowLayoutPanel cateMenu;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button statistic;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button restore;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button button8;
    }
}