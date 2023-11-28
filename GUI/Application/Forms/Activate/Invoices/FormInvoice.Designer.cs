namespace GUI
{
    partial class FormInvoice
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            this.exit = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableImp = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableSale = new System.Windows.Forms.DataGridView();
            this.saleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableImp)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableSale)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = global::GUI.Properties.Resources.reject;
            this.exit.Location = new System.Drawing.Point(959, 15);
            this.exit.Margin = new System.Windows.Forms.Padding(6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 38);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 43;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(338, 42);
            this.title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(400, 57);
            this.title.TabIndex = 42;
            this.title.Text = "LỊCH SỬ HÓA ĐƠN";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormInvoice_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableImp);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(30, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 302);
            this.panel2.TabIndex = 64;
            // 
            // tableImp
            // 
            this.tableImp.AllowUserToAddRows = false;
            this.tableImp.AllowUserToDeleteRows = false;
            this.tableImp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableImp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tableImp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableImp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableImp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.code,
            this.date,
            this.staff,
            this.supplier,
            this.totalPrice});
            this.tableImp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableImp.Location = new System.Drawing.Point(0, 37);
            this.tableImp.Margin = new System.Windows.Forms.Padding(0);
            this.tableImp.Name = "tableImp";
            this.tableImp.ReadOnly = true;
            this.tableImp.RowHeadersVisible = false;
            this.tableImp.RowHeadersWidth = 51;
            this.tableImp.Size = new System.Drawing.Size(950, 265);
            this.tableImp.TabIndex = 46;
            this.tableImp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableImp_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "STT";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // code
            // 
            this.code.HeaderText = "Mã hóa đơn";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Ngày";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // staff
            // 
            this.staff.HeaderText = "Nhân viên";
            this.staff.MinimumWidth = 6;
            this.staff.Name = "staff";
            this.staff.ReadOnly = true;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Nhà cung cấp";
            this.supplier.MinimumWidth = 6;
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Tổng giá trị";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Controls.Add(this.label18);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(950, 37);
            this.panel4.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(388, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(215, 36);
            this.label18.TabIndex = 10;
            this.label18.Text = "Hóa đơn nhập";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableSale);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(30, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 302);
            this.panel1.TabIndex = 65;
            // 
            // tableSale
            // 
            this.tableSale.AllowUserToAddRows = false;
            this.tableSale.AllowUserToDeleteRows = false;
            this.tableSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableSale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tableSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleId,
            this.saleCode,
            this.saleDate,
            this.saleStaff,
            this.customer,
            this.saleTotalPrice});
            this.tableSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSale.Location = new System.Drawing.Point(0, 37);
            this.tableSale.Margin = new System.Windows.Forms.Padding(0);
            this.tableSale.Name = "tableSale";
            this.tableSale.ReadOnly = true;
            this.tableSale.RowHeadersVisible = false;
            this.tableSale.RowHeadersWidth = 51;
            this.tableSale.Size = new System.Drawing.Size(950, 265);
            this.tableSale.TabIndex = 46;
            this.tableSale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableSale_CellClick);
            // 
            // saleId
            // 
            this.saleId.HeaderText = "STT";
            this.saleId.MinimumWidth = 6;
            this.saleId.Name = "saleId";
            this.saleId.ReadOnly = true;
            // 
            // saleCode
            // 
            this.saleCode.HeaderText = "Mã hóa đơn";
            this.saleCode.MinimumWidth = 6;
            this.saleCode.Name = "saleCode";
            this.saleCode.ReadOnly = true;
            // 
            // saleDate
            // 
            this.saleDate.HeaderText = "Ngày";
            this.saleDate.MinimumWidth = 6;
            this.saleDate.Name = "saleDate";
            this.saleDate.ReadOnly = true;
            // 
            // saleStaff
            // 
            this.saleStaff.HeaderText = "Nhân viên";
            this.saleStaff.MinimumWidth = 6;
            this.saleStaff.Name = "saleStaff";
            this.saleStaff.ReadOnly = true;
            // 
            // customer
            // 
            this.customer.HeaderText = "Khách hàng";
            this.customer.MinimumWidth = 6;
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // saleTotalPrice
            // 
            this.saleTotalPrice.HeaderText = "Tổng giá trị";
            this.saleTotalPrice.MinimumWidth = 6;
            this.saleTotalPrice.Name = "saleTotalPrice";
            this.saleTotalPrice.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 37);
            this.panel3.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(395, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hóa đơn bán";
            // 
            // FormInvoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1010, 763);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStatistic";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormInvoice_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableImp)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableSale)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tableSale;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableImp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleTotalPrice;
    }
}