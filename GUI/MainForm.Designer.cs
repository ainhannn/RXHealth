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
            this.Sidebar = new System.Windows.Forms.Panel();
            this.staff = new System.Windows.Forms.Button();
            this.sell = new System.Windows.Forms.Button();
            this.invenMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.inventory = new System.Windows.Forms.Button();
            this.invenImp = new System.Windows.Forms.Button();
            this.invenChk = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.cateMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.category = new System.Windows.Forms.Button();
            this.cateCate = new System.Windows.Forms.Button();
            this.cateIngre = new System.Windows.Forms.Button();
            this.cateDrug = new System.Windows.Forms.Button();
            this.cateProvi = new System.Windows.Forms.Button();
            this.cateCus = new System.Windows.Forms.Button();
            this.statistic = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.username = new System.Windows.Forms.Label();
            this.formTitle = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.restore = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Sidebar.SuspendLayout();
            this.invenMenu.SuspendLayout();
            this.cateMenu.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.Header.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Sidebar.Controls.Add(this.staff);
            this.Sidebar.Controls.Add(this.sell);
            this.Sidebar.Controls.Add(this.invenMenu);
            this.Sidebar.Controls.Add(this.setting);
            this.Sidebar.Controls.Add(this.logout);
            this.Sidebar.Controls.Add(this.cateMenu);
            this.Sidebar.Controls.Add(this.statistic);
            this.Sidebar.Controls.Add(this.pnl);
            resources.ApplyResources(this.Sidebar, "Sidebar");
            this.Sidebar.Name = "Sidebar";
            // 
            // staff
            // 
            this.staff.BackColor = System.Drawing.Color.RoyalBlue;
            this.staff.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.staff, "staff");
            this.staff.FlatAppearance.BorderSize = 0;
            this.staff.ForeColor = System.Drawing.Color.White;
            this.staff.Image = global::GUI.Properties.Resources.team_management;
            this.staff.Name = "staff";
            this.staff.Tag = "Nhân Sự";
            this.staff.UseVisualStyleBackColor = false;
            this.staff.Click += new System.EventHandler(this.staff_Click);
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
            this.sell.Click += new System.EventHandler(this.sell_Click);
            // 
            // invenMenu
            // 
            this.invenMenu.Controls.Add(this.inventory);
            this.invenMenu.Controls.Add(this.invenImp);
            this.invenMenu.Controls.Add(this.invenChk);
            resources.ApplyResources(this.invenMenu, "invenMenu");
            this.invenMenu.Name = "invenMenu";
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
            this.inventory.Tag = "Quản Lý Kho";
            this.inventory.UseVisualStyleBackColor = false;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // invenImp
            // 
            this.invenImp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.invenImp.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.invenImp, "invenImp");
            this.invenImp.FlatAppearance.BorderSize = 0;
            this.invenImp.ForeColor = System.Drawing.Color.White;
            this.invenImp.Image = global::GUI.Properties.Resources.import;
            this.invenImp.Name = "invenImp";
            this.invenImp.Tag = "Nhập Kho";
            this.invenImp.UseVisualStyleBackColor = false;
            this.invenImp.Click += new System.EventHandler(this.invenImp_Click);
            // 
            // invenChk
            // 
            this.invenChk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.invenChk.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.invenChk, "invenChk");
            this.invenChk.FlatAppearance.BorderSize = 0;
            this.invenChk.ForeColor = System.Drawing.Color.White;
            this.invenChk.Image = global::GUI.Properties.Resources.quality_control;
            this.invenChk.Name = "invenChk";
            this.invenChk.Tag = "Kiểm Kho";
            this.invenChk.UseVisualStyleBackColor = false;
            this.invenChk.Click += new System.EventHandler(this.invenChk_Click);
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
            this.setting.Click += new System.EventHandler(this.setting_Click);
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
            // cateMenu
            // 
            this.cateMenu.Controls.Add(this.category);
            this.cateMenu.Controls.Add(this.cateCate);
            this.cateMenu.Controls.Add(this.cateIngre);
            this.cateMenu.Controls.Add(this.cateDrug);
            this.cateMenu.Controls.Add(this.cateProvi);
            this.cateMenu.Controls.Add(this.cateCus);
            resources.ApplyResources(this.cateMenu, "cateMenu");
            this.cateMenu.Name = "cateMenu";
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
            this.category.Tag = "Danh Mục";
            this.category.UseVisualStyleBackColor = false;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // cateCate
            // 
            this.cateCate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cateCate.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.cateCate, "cateCate");
            this.cateCate.FlatAppearance.BorderSize = 0;
            this.cateCate.ForeColor = System.Drawing.Color.White;
            this.cateCate.Image = global::GUI.Properties.Resources.production;
            this.cateCate.Name = "cateCate";
            this.cateCate.Tag = "Ngành Hàng";
            this.cateCate.UseVisualStyleBackColor = false;
            this.cateCate.Click += new System.EventHandler(this.cateCate_Click);
            // 
            // cateIngre
            // 
            this.cateIngre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cateIngre.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.cateIngre, "cateIngre");
            this.cateIngre.FlatAppearance.BorderSize = 0;
            this.cateIngre.ForeColor = System.Drawing.Color.White;
            this.cateIngre.Image = global::GUI.Properties.Resources.herb;
            this.cateIngre.Name = "cateIngre";
            this.cateIngre.Tag = "Hoạt Chất";
            this.cateIngre.UseVisualStyleBackColor = false;
            this.cateIngre.Click += new System.EventHandler(this.cateIngre_Click);
            // 
            // cateDrug
            // 
            this.cateDrug.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cateDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.cateDrug, "cateDrug");
            this.cateDrug.FlatAppearance.BorderSize = 0;
            this.cateDrug.ForeColor = System.Drawing.Color.White;
            this.cateDrug.Image = global::GUI.Properties.Resources.drugs;
            this.cateDrug.Name = "cateDrug";
            this.cateDrug.Tag = "Sản Phẩm";
            this.cateDrug.UseVisualStyleBackColor = false;
            this.cateDrug.Click += new System.EventHandler(this.cateDrug_Click);
            // 
            // cateProvi
            // 
            this.cateProvi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cateProvi.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.cateProvi, "cateProvi");
            this.cateProvi.FlatAppearance.BorderSize = 0;
            this.cateProvi.ForeColor = System.Drawing.Color.White;
            this.cateProvi.Image = global::GUI.Properties.Resources.take_medicines;
            this.cateProvi.Name = "cateProvi";
            this.cateProvi.Tag = "Nhà Cung Cấp";
            this.cateProvi.UseVisualStyleBackColor = false;
            this.cateProvi.Click += new System.EventHandler(this.cateProvi_Click);
            // 
            // cateCus
            // 
            this.cateCus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cateCus.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.cateCus, "cateCus");
            this.cateCus.FlatAppearance.BorderSize = 0;
            this.cateCus.ForeColor = System.Drawing.Color.White;
            this.cateCus.Image = global::GUI.Properties.Resources.customer_service;
            this.cateCus.Name = "cateCus";
            this.cateCus.Tag = "Khách Hàng";
            this.cateCus.UseVisualStyleBackColor = false;
            this.cateCus.Click += new System.EventHandler(this.cateCus_Click);
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
            this.statistic.Click += new System.EventHandler(this.statistic_Click);
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
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.RoyalBlue;
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.menu, "menu");
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.Image = global::GUI.Properties.Resources.main_menu;
            this.menu.Name = "menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // logo
            // 
            resources.ApplyResources(this.logo, "logo");
            this.logo.Image = global::GUI.Properties.Resources.RXlogo;
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.pnlAccount);
            this.Header.Controls.Add(this.formTitle);
            this.Header.Controls.Add(this.close);
            this.Header.Controls.Add(this.minimize);
            this.Header.Controls.Add(this.restore);
            resources.ApplyResources(this.Header, "Header");
            this.Header.Name = "Header";
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.avatar);
            this.pnlAccount.Controls.Add(this.username);
            resources.ApplyResources(this.pnlAccount, "pnlAccount");
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            this.avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.avatar, "avatar");
            this.avatar.FillColor = System.Drawing.Color.Transparent;
            this.avatar.Image = global::GUI.Properties.Resources.account;
            this.avatar.ImageRotate = 0F;
            this.avatar.Name = "avatar";
            this.avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.username_Click);
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.username.ForeColor = System.Drawing.Color.RoyalBlue;
            this.username.Name = "username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // formTitle
            // 
            resources.ApplyResources(this.formTitle, "formTitle");
            this.formTitle.BackColor = System.Drawing.Color.Transparent;
            this.formTitle.ForeColor = System.Drawing.Color.Navy;
            this.formTitle.Name = "formTitle";
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
            this.ControlBox = false;
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Sidebar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.Sidebar.ResumeLayout(false);
            this.invenMenu.ResumeLayout(false);
            this.cateMenu.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Panel Sidebar;
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
        private System.Windows.Forms.Button staff;
        private System.Windows.Forms.FlowLayoutPanel cateMenu;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.Button cateCate;
        private System.Windows.Forms.Button cateIngre;
        private System.Windows.Forms.Button cateDrug;
        private System.Windows.Forms.Button cateProvi;
        private System.Windows.Forms.Button cateCus;
        private System.Windows.Forms.FlowLayoutPanel invenMenu;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button invenImp;
        private System.Windows.Forms.Button invenChk;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label username;
        private Guna.UI2.WinForms.Guna2CirclePictureBox avatar;
        private System.Windows.Forms.Panel pnlAccount;
    }
}