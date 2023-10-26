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
            this.panel4 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.sliding = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.sale = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.menuicon = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Sidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menu.SuspendLayout();
            this.Header.SuspendLayout();
            this.Main.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Sidebar.Controls.Add(this.panel4);
            this.Sidebar.Controls.Add(this.menu);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(525, 825);
            this.Sidebar.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.setting);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 725);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(525, 100);
            this.panel4.TabIndex = 4;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.RoyalBlue;
            this.menu.Controls.Add(this.menuicon);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.logo);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(525, 100);
            this.menu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 99);
            this.label1.TabIndex = 1;
            this.label1.Text = "HEALTH";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.close);
            this.Header.Controls.Add(this.minimize);
            this.Header.Controls.Add(this.sliding);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(525, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(668, 60);
            this.Header.TabIndex = 1;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.panel3);
            this.Main.Controls.Add(this.panel2);
            this.Main.Controls.Add(this.panel1);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(525, 60);
            this.Main.Margin = new System.Windows.Forms.Padding(0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(668, 765);
            this.Main.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.inventory);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(40, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 100);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.sale);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(40, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 100);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(40, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 100);
            this.panel1.TabIndex = 2;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Crimson;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close.Image = global::GUI.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(616, 0);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(52, 36);
            this.close.TabIndex = 11;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // sliding
            // 
            this.sliding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sliding.BackColor = System.Drawing.Color.RoyalBlue;
            this.sliding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliding.FlatAppearance.BorderSize = 0;
            this.sliding.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sliding.Image = global::GUI.Properties.Resources.minimize;
            this.sliding.Location = new System.Drawing.Point(558, 0);
            this.sliding.Margin = new System.Windows.Forms.Padding(0);
            this.sliding.Name = "sliding";
            this.sliding.Size = new System.Drawing.Size(52, 36);
            this.sliding.TabIndex = 10;
            this.sliding.UseVisualStyleBackColor = false;
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.MediumAquamarine;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimize.Image = global::GUI.Properties.Resources.minimize1;
            this.minimize.Location = new System.Drawing.Point(500, 0);
            this.minimize.Margin = new System.Windows.Forms.Padding(0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(52, 36);
            this.minimize.TabIndex = 6;
            this.minimize.UseVisualStyleBackColor = false;
            // 
            // inventory
            // 
            this.inventory.BackColor = System.Drawing.Color.RoyalBlue;
            this.inventory.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.ForeColor = System.Drawing.Color.White;
            this.inventory.Image = global::GUI.Properties.Resources.stock;
            this.inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory.Location = new System.Drawing.Point(-15, -13);
            this.inventory.Margin = new System.Windows.Forms.Padding(0);
            this.inventory.Name = "inventory";
            this.inventory.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.inventory.Size = new System.Drawing.Size(554, 126);
            this.inventory.TabIndex = 3;
            this.inventory.Text = "                Kho";
            this.inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory.UseVisualStyleBackColor = false;
            // 
            // sale
            // 
            this.sale.BackColor = System.Drawing.Color.RoyalBlue;
            this.sale.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale.ForeColor = System.Drawing.Color.White;
            this.sale.Image = ((System.Drawing.Image)(resources.GetObject("sale.Image")));
            this.sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sale.Location = new System.Drawing.Point(-15, -13);
            this.sale.Margin = new System.Windows.Forms.Padding(0);
            this.sale.Name = "sale";
            this.sale.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.sale.Size = new System.Drawing.Size(554, 126);
            this.sale.TabIndex = 3;
            this.sale.Text = "                Bán Hàng";
            this.sale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sale.UseVisualStyleBackColor = false;
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.RoyalBlue;
            this.dashboard.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.Image = ((System.Drawing.Image)(resources.GetObject("dashboard.Image")));
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Location = new System.Drawing.Point(-15, -13);
            this.dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dashboard.Size = new System.Drawing.Size(554, 126);
            this.dashboard.TabIndex = 3;
            this.dashboard.Text = "                Thống Kê";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.UseVisualStyleBackColor = false;
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.RoyalBlue;
            this.setting.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting.ForeColor = System.Drawing.Color.White;
            this.setting.Image = global::GUI.Properties.Resources.settings_gears;
            this.setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting.Location = new System.Drawing.Point(-15, -13);
            this.setting.Margin = new System.Windows.Forms.Padding(0);
            this.setting.Name = "setting";
            this.setting.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.setting.Size = new System.Drawing.Size(554, 126);
            this.setting.TabIndex = 3;
            this.setting.Text = "                Cài Đặt Chung";
            this.setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting.UseVisualStyleBackColor = false;
            // 
            // menuicon
            // 
            this.menuicon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuicon.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuicon.Image = global::GUI.Properties.Resources.more;
            this.menuicon.Location = new System.Drawing.Point(425, 0);
            this.menuicon.Margin = new System.Windows.Forms.Padding(0);
            this.menuicon.Name = "menuicon";
            this.menuicon.Padding = new System.Windows.Forms.Padding(20);
            this.menuicon.Size = new System.Drawing.Size(100, 100);
            this.menuicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuicon.TabIndex = 2;
            this.menuicon.TabStop = false;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = global::GUI.Properties.Resources.RXlogo;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Padding = new System.Windows.Forms.Padding(15);
            this.logo.Size = new System.Drawing.Size(100, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 825);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Sidebar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox menuicon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sale;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button sliding;
    }
}