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
            this.pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cate = new System.Windows.Forms.Button();
            this.staff = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.sell = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.restore = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Sidebar.SuspendLayout();
            this.pnl.SuspendLayout();
            this.Header.SuspendLayout();
            this.Main.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Sidebar.Controls.Add(this.setting);
            this.Sidebar.Controls.Add(this.pnl);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(489, 1102);
            this.Sidebar.TabIndex = 0;
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl.Controls.Add(this.menu);
            this.pnl.Controls.Add(this.label1);
            this.pnl.Controls.Add(this.logo);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Margin = new System.Windows.Forms.Padding(0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(489, 100);
            this.pnl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 89);
            this.label1.TabIndex = 1;
            this.label1.Text = "HEALTH";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.close);
            this.Header.Controls.Add(this.minimize);
            this.Header.Controls.Add(this.restore);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(489, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1453, 60);
            this.Header.TabIndex = 1;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.panel14);
            this.Main.Controls.Add(this.panel10);
            this.Main.Controls.Add(this.panel9);
            this.Main.Controls.Add(this.panel8);
            this.Main.Controls.Add(this.panel7);
            this.Main.Controls.Add(this.panel6);
            this.Main.Controls.Add(this.panel5);
            this.Main.Controls.Add(this.panel3);
            this.Main.Controls.Add(this.panel2);
            this.Main.Controls.Add(this.panel1);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(489, 60);
            this.Main.Margin = new System.Windows.Forms.Padding(0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1453, 1042);
            this.Main.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel14.Location = new System.Drawing.Point(672, 366);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(525, 300);
            this.panel14.TabIndex = 8;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.Controls.Add(this.button9);
            this.panel17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 200);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(525, 100);
            this.panel17.TabIndex = 7;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Controls.Add(this.button8);
            this.panel16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 100);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(525, 100);
            this.panel16.TabIndex = 6;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Controls.Add(this.button7);
            this.panel15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(525, 100);
            this.panel15.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel10.Location = new System.Drawing.Point(672, 25);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(525, 300);
            this.panel10.TabIndex = 5;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.button6);
            this.panel13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 200);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(525, 100);
            this.panel13.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.button2);
            this.panel12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 100);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(525, 100);
            this.panel12.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.button1);
            this.panel11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(525, 100);
            this.panel11.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.button5);
            this.panel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel9.Location = new System.Drawing.Point(40, 25);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(525, 100);
            this.panel9.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.button4);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(40, 843);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(525, 100);
            this.panel8.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.button3);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(40, 727);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(525, 100);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.cate);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(40, 611);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(525, 100);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.staff);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(40, 495);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(525, 100);
            this.panel5.TabIndex = 4;
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
            this.panel2.Controls.Add(this.sell);
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
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RoyalBlue;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::GUI.Properties.Resources.customer_service;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-15, -13);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(554, 126);
            this.button9.TabIndex = 3;
            this.button9.Text = "                Khách Hàng";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.RoyalBlue;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::GUI.Properties.Resources.trolley;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-15, -13);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(554, 126);
            this.button8.TabIndex = 3;
            this.button8.Text = "                Tạo Hóa Đơn";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::GUI.Properties.Resources.trolley;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-15, -13);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(554, 126);
            this.button7.TabIndex = 3;
            this.button7.Text = "                Bán Hàng";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::GUI.Properties.Resources.quality_control;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-15, -13);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(554, 126);
            this.button6.TabIndex = 3;
            this.button6.Text = "                Kiểm Kho";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::GUI.Properties.Resources.import;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-15, -13);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(554, 126);
            this.button2.TabIndex = 3;
            this.button2.Text = "                Nhập Kho";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::GUI.Properties.Resources.stock;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-15, -13);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(554, 126);
            this.button1.TabIndex = 3;
            this.button1.Text = "                Kho";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-15, -13);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(554, 126);
            this.button5.TabIndex = 3;
            this.button5.Text = "                Thống Kê";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-15, -13);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(554, 126);
            this.button4.TabIndex = 3;
            this.button4.Text = "                Thống Kê";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-15, -13);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(554, 126);
            this.button3.TabIndex = 3;
            this.button3.Text = "                Thống Kê";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // cate
            // 
            this.cate.BackColor = System.Drawing.Color.RoyalBlue;
            this.cate.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cate.ForeColor = System.Drawing.Color.White;
            this.cate.Image = global::GUI.Properties.Resources.categorization;
            this.cate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cate.Location = new System.Drawing.Point(-15, -13);
            this.cate.Margin = new System.Windows.Forms.Padding(0);
            this.cate.Name = "cate";
            this.cate.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.cate.Size = new System.Drawing.Size(554, 126);
            this.cate.TabIndex = 3;
            this.cate.Text = "                Danh Mục";
            this.cate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cate.UseVisualStyleBackColor = false;
            // 
            // staff
            // 
            this.staff.BackColor = System.Drawing.Color.RoyalBlue;
            this.staff.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff.ForeColor = System.Drawing.Color.White;
            this.staff.Image = global::GUI.Properties.Resources.team_management;
            this.staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staff.Location = new System.Drawing.Point(-15, -13);
            this.staff.Margin = new System.Windows.Forms.Padding(0);
            this.staff.Name = "staff";
            this.staff.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.staff.Size = new System.Drawing.Size(554, 126);
            this.staff.TabIndex = 3;
            this.staff.Text = "                Nhân Sự";
            this.staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staff.UseVisualStyleBackColor = false;
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
            // sell
            // 
            this.sell.BackColor = System.Drawing.Color.RoyalBlue;
            this.sell.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell.ForeColor = System.Drawing.Color.White;
            this.sell.Image = global::GUI.Properties.Resources.trolley;
            this.sell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sell.Location = new System.Drawing.Point(-15, -13);
            this.sell.Margin = new System.Windows.Forms.Padding(0);
            this.sell.Name = "sell";
            this.sell.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.sell.Size = new System.Drawing.Size(554, 126);
            this.sell.TabIndex = 3;
            this.sell.Text = "                Bán Hàng";
            this.sell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sell.UseVisualStyleBackColor = false;
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
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Crimson;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::GUI.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(1393, 0);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(60, 40);
            this.close.TabIndex = 11;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.MediumAquamarine;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Image = global::GUI.Properties.Resources.minimize1;
            this.minimize.Location = new System.Drawing.Point(1273, 0);
            this.minimize.Margin = new System.Windows.Forms.Padding(0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(60, 40);
            this.minimize.TabIndex = 6;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // restore
            // 
            this.restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restore.BackColor = System.Drawing.Color.RoyalBlue;
            this.restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restore.FlatAppearance.BorderSize = 0;
            this.restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restore.Image = global::GUI.Properties.Resources.minimize;
            this.restore.Location = new System.Drawing.Point(1333, 0);
            this.restore.Margin = new System.Windows.Forms.Padding(0);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(60, 40);
            this.restore.TabIndex = 10;
            this.restore.UseVisualStyleBackColor = false;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.RoyalBlue;
            this.setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting.ForeColor = System.Drawing.Color.White;
            this.setting.Image = global::GUI.Properties.Resources.settings_gears;
            this.setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting.Location = new System.Drawing.Point(0, 1002);
            this.setting.Margin = new System.Windows.Forms.Padding(0);
            this.setting.Name = "setting";
            this.setting.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.setting.Size = new System.Drawing.Size(489, 100);
            this.setting.TabIndex = 3;
            this.setting.Tag = "Cài Đặt Chung";
            this.setting.Text = "                Cài Đặt Chung";
            this.setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting.UseVisualStyleBackColor = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.RoyalBlue;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Location = new System.Drawing.Point(389, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menu.Size = new System.Drawing.Size(100, 100);
            this.menu.TabIndex = 4;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // logo
            // 
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
            this.ClientSize = new System.Drawing.Size(1942, 1102);
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
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button restore;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button cate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button staff;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button menu;
    }
}