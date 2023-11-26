using System.Windows.Forms;

namespace GUI
{
    partial class FormSell
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
            this.TextBoxCustomer = new System.Windows.Forms.TextBox();
            this.TextBoxNote = new System.Windows.Forms.TextBox();
            this.SellBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PayLabel = new System.Windows.Forms.Label();
            this.RottenLabel = new System.Windows.Forms.Label();
            this.TextBoxReceive = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerClear = new System.Windows.Forms.PictureBox();
            this.Find2Panel = new System.Windows.Forms.Panel();
            this.FindCustomerTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleCombobox = new System.Windows.Forms.ComboBox();
            this.txtCus = new System.Windows.Forms.Label();
            this.NewCustomerBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GoodsClear = new System.Windows.Forms.PictureBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Find1Panel = new System.Windows.Forms.Panel();
            this.FindGoodsTable = new System.Windows.Forms.DataGridView();
            this.Barcode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerClear)).BeginInit();
            this.Find2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindCustomerTable)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.Find1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindGoodsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxCustomer
            // 
            this.TextBoxCustomer.AcceptsReturn = true;
            this.TextBoxCustomer.AcceptsTab = true;
            this.TextBoxCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextBoxCustomer.Location = new System.Drawing.Point(30, 75);
            this.TextBoxCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxCustomer.MaximumSize = new System.Drawing.Size(376, 30);
            this.TextBoxCustomer.MinimumSize = new System.Drawing.Size(76, 30);
            this.TextBoxCustomer.Name = "TextBoxCustomer";
            this.TextBoxCustomer.Size = new System.Drawing.Size(346, 30);
            this.TextBoxCustomer.TabIndex = 103;
            this.TextBoxCustomer.Click += new System.EventHandler(this.TextBoxCustomer_Click);
            this.TextBoxCustomer.TextChanged += new System.EventHandler(this.TextBoxCustomer_TextChanged);
            this.TextBoxCustomer.Leave += new System.EventHandler(this.TextBoxCustomer_Leave);
            // 
            // TextBoxNote
            // 
            this.TextBoxNote.AcceptsReturn = true;
            this.TextBoxNote.AcceptsTab = true;
            this.TextBoxNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextBoxNote.Location = new System.Drawing.Point(30, 557);
            this.TextBoxNote.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxNote.MaximumSize = new System.Drawing.Size(376, 30);
            this.TextBoxNote.MinimumSize = new System.Drawing.Size(76, 30);
            this.TextBoxNote.Name = "TextBoxNote";
            this.TextBoxNote.Size = new System.Drawing.Size(346, 30);
            this.TextBoxNote.TabIndex = 104;
            this.TextBoxNote.Text = "Ghi chú đơn hàng";
            this.TextBoxNote.Click += new System.EventHandler(this.TextBoxNote_Click);
            // 
            // SellBtn
            // 
            this.SellBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SellBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.SellBtn.Location = new System.Drawing.Point(47, 611);
            this.SellBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SellBtn.Name = "SellBtn";
            this.SellBtn.Size = new System.Drawing.Size(308, 45);
            this.SellBtn.TabIndex = 105;
            this.SellBtn.Text = "Hoàn tất";
            this.SellBtn.UseVisualStyleBackColor = true;
            this.SellBtn.Click += new System.EventHandler(this.SellBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label2.Location = new System.Drawing.Point(30, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 106;
            this.label2.Text = "Tổng tiền hàng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label3.Location = new System.Drawing.Point(31, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 107;
            this.label3.Text = "Khuyến mãi";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label4.Location = new System.Drawing.Point(32, 386);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 108;
            this.label4.Text = "Khách cần trả";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label5.Location = new System.Drawing.Point(32, 456);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 109;
            this.label5.Text = "Tiền khách đưa";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label6.Location = new System.Drawing.Point(32, 494);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 110;
            this.label6.Text = "Tiền thừa ";
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.TotalLabel.Location = new System.Drawing.Point(230, 303);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(22, 25);
            this.TotalLabel.TabIndex = 111;
            this.TotalLabel.Text = "0";
            this.TotalLabel.TextChanged += new System.EventHandler(this.TotalLabel_TextChanged);
            // 
            // PayLabel
            // 
            this.PayLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PayLabel.AutoSize = true;
            this.PayLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.PayLabel.Location = new System.Drawing.Point(230, 384);
            this.PayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(22, 25);
            this.PayLabel.TabIndex = 113;
            this.PayLabel.Text = "0";
            // 
            // RottenLabel
            // 
            this.RottenLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RottenLabel.AutoSize = true;
            this.RottenLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.RottenLabel.Location = new System.Drawing.Point(230, 492);
            this.RottenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RottenLabel.Name = "RottenLabel";
            this.RottenLabel.Size = new System.Drawing.Size(22, 25);
            this.RottenLabel.TabIndex = 115;
            this.RottenLabel.Text = "0";
            // 
            // TextBoxReceive
            // 
            this.TextBoxReceive.AcceptsReturn = true;
            this.TextBoxReceive.AcceptsTab = true;
            this.TextBoxReceive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextBoxReceive.Location = new System.Drawing.Point(206, 456);
            this.TextBoxReceive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxReceive.MaximumSize = new System.Drawing.Size(376, 30);
            this.TextBoxReceive.MinimumSize = new System.Drawing.Size(76, 30);
            this.TextBoxReceive.Name = "TextBoxReceive";
            this.TextBoxReceive.Size = new System.Drawing.Size(106, 30);
            this.TextBoxReceive.TabIndex = 116;
            this.TextBoxReceive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxReceive_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CustomerClear);
            this.panel1.Controls.Add(this.Find2Panel);
            this.panel1.Controls.Add(this.SaleCombobox);
            this.panel1.Controls.Add(this.txtCus);
            this.panel1.Controls.Add(this.NewCustomerBtn);
            this.panel1.Controls.Add(this.TextBoxReceive);
            this.panel1.Controls.Add(this.RottenLabel);
            this.panel1.Controls.Add(this.PayLabel);
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SellBtn);
            this.panel1.Controls.Add(this.TextBoxNote);
            this.panel1.Controls.Add(this.TextBoxCustomer);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtPoint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1208, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 894);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 124;
            this.label9.Text = "VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 123;
            this.label8.Text = "VNĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 122;
            this.label7.Text = "VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 121;
            this.label1.Text = "VNĐ";
            // 
            // CustomerClear
            // 
            this.CustomerClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerClear.BackColor = System.Drawing.Color.Silver;
            this.CustomerClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerClear.Image = global::GUI.Properties.Resources.reject;
            this.CustomerClear.Location = new System.Drawing.Point(334, 75);
            this.CustomerClear.Name = "CustomerClear";
            this.CustomerClear.Size = new System.Drawing.Size(42, 30);
            this.CustomerClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CustomerClear.TabIndex = 96;
            this.CustomerClear.TabStop = false;
            this.CustomerClear.Click += new System.EventHandler(this.CustomerClear_Click);
            // 
            // Find2Panel
            // 
            this.Find2Panel.Controls.Add(this.FindCustomerTable);
            this.Find2Panel.Location = new System.Drawing.Point(30, 109);
            this.Find2Panel.Name = "Find2Panel";
            this.Find2Panel.Size = new System.Drawing.Size(346, 191);
            this.Find2Panel.TabIndex = 118;
            // 
            // FindCustomerTable
            // 
            this.FindCustomerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindCustomerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.phone,
            this.customer,
            this.point});
            this.FindCustomerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindCustomerTable.Location = new System.Drawing.Point(0, 0);
            this.FindCustomerTable.Name = "FindCustomerTable";
            this.FindCustomerTable.RowHeadersWidth = 51;
            this.FindCustomerTable.RowTemplate.Height = 24;
            this.FindCustomerTable.Size = new System.Drawing.Size(346, 191);
            this.FindCustomerTable.TabIndex = 0;
            this.FindCustomerTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FindCustomerTable_CellClick);
            this.FindCustomerTable.Leave += new System.EventHandler(this.FindCustomerTable_Leave);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 6;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.HeaderText = "Số điện thoại";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // customer
            // 
            this.customer.HeaderText = "Tên khách hàng";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            this.customer.Width = 150;
            // 
            // point
            // 
            this.point.HeaderText = "Điểm";
            this.point.Name = "point";
            this.point.ReadOnly = true;
            this.point.Visible = false;
            this.point.Width = 5;
            // 
            // SaleCombobox
            // 
            this.SaleCombobox.FormattingEnabled = true;
            this.SaleCombobox.Location = new System.Drawing.Point(206, 352);
            this.SaleCombobox.Name = "SaleCombobox";
            this.SaleCombobox.Size = new System.Drawing.Size(156, 21);
            this.SaleCombobox.TabIndex = 120;
            this.SaleCombobox.SelectedIndexChanged += new System.EventHandler(this.SaleCombobox_SelectedIndexChanged);
            // 
            // txtCus
            // 
            this.txtCus.AutoSize = true;
            this.txtCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCus.Location = new System.Drawing.Point(32, 262);
            this.txtCus.Name = "txtCus";
            this.txtCus.Size = new System.Drawing.Size(59, 24);
            this.txtCus.TabIndex = 119;
            this.txtCus.Text = "Guest";
            // 
            // NewCustomerBtn
            // 
            this.NewCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCustomerBtn.Location = new System.Drawing.Point(250, 12);
            this.NewCustomerBtn.Name = "NewCustomerBtn";
            this.NewCustomerBtn.Size = new System.Drawing.Size(130, 48);
            this.NewCustomerBtn.TabIndex = 117;
            this.NewCustomerBtn.Text = "Thêm KH";
            this.NewCustomerBtn.UseVisualStyleBackColor = true;
            this.NewCustomerBtn.Click += new System.EventHandler(this.NewCustomer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 24);
            this.label10.TabIndex = 126;
            this.label10.Text = "điểm";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPoint
            // 
            this.txtPoint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPoint.AutoSize = true;
            this.txtPoint.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtPoint.Location = new System.Drawing.Point(230, 262);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(22, 25);
            this.txtPoint.TabIndex = 127;
            this.txtPoint.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.GoodsClear);
            this.panel2.Controls.Add(this.TextBoxSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 75);
            this.panel2.TabIndex = 2;
            // 
            // GoodsClear
            // 
            this.GoodsClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodsClear.BackColor = System.Drawing.Color.Silver;
            this.GoodsClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoodsClear.Image = global::GUI.Properties.Resources.reject;
            this.GoodsClear.Location = new System.Drawing.Point(1127, 22);
            this.GoodsClear.Name = "GoodsClear";
            this.GoodsClear.Size = new System.Drawing.Size(42, 30);
            this.GoodsClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoodsClear.TabIndex = 13;
            this.GoodsClear.TabStop = false;
            this.GoodsClear.Click += new System.EventHandler(this.GoodsClear_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.AcceptsReturn = true;
            this.TextBoxSearch.AcceptsTab = true;
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextBoxSearch.Location = new System.Drawing.Point(39, 22);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxSearch.MaximumSize = new System.Drawing.Size(1500, 30);
            this.TextBoxSearch.MinimumSize = new System.Drawing.Size(76, 30);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(1130, 30);
            this.TextBoxSearch.TabIndex = 95;
            this.TextBoxSearch.Click += new System.EventHandler(this.TextBoxSearch_Click);
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            this.TextBoxSearch.Leave += new System.EventHandler(this.TextBoxSearch_Leave);
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Barcode,
            this.PName,
            this.Cate,
            this.Unit,
            this.SalePrice,
            this.Dec,
            this.Number,
            this.Inc,
            this.Amount,
            this.Delete});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 75);
            this.table.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(1208, 819);
            this.table.TabIndex = 4;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            this.table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellValueChanged);
            this.table.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.table_RowsAdded);
            // 
            // Index
            // 
            this.Index.FillWeight = 25F;
            this.Index.HeaderText = "STT";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.FillWeight = 80F;
            this.Barcode.HeaderText = "Mã vạch";
            this.Barcode.MinimumWidth = 6;
            this.Barcode.Name = "Barcode";
            // 
            // PName
            // 
            this.PName.FillWeight = 125F;
            this.PName.HeaderText = "Tên sản phẩm";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            // 
            // Cate
            // 
            this.Cate.HeaderText = "Loại";
            this.Cate.MinimumWidth = 6;
            this.Cate.Name = "Cate";
            // 
            // Unit
            // 
            this.Unit.FillWeight = 50F;
            this.Unit.HeaderText = "Đơn vị";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            // 
            // SalePrice
            // 
            this.SalePrice.FillWeight = 80F;
            this.SalePrice.HeaderText = "Giá bán";
            this.SalePrice.MinimumWidth = 6;
            this.SalePrice.Name = "SalePrice";
            // 
            // Dec
            // 
            this.Dec.FillWeight = 15F;
            this.Dec.HeaderText = "";
            this.Dec.MinimumWidth = 6;
            this.Dec.Name = "Dec";
            // 
            // Number
            // 
            this.Number.FillWeight = 50F;
            this.Number.HeaderText = "Số lượng";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            // 
            // Inc
            // 
            this.Inc.FillWeight = 15F;
            this.Inc.HeaderText = "";
            this.Inc.MinimumWidth = 6;
            this.Inc.Name = "Inc";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Thành tiền";
            this.Amount.Name = "Amount";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 25F;
            this.Delete.HeaderText = "Xóa";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            // 
            // Find1Panel
            // 
            this.Find1Panel.Controls.Add(this.FindGoodsTable);
            this.Find1Panel.Location = new System.Drawing.Point(39, 58);
            this.Find1Panel.Name = "Find1Panel";
            this.Find1Panel.Size = new System.Drawing.Size(1130, 598);
            this.Find1Panel.TabIndex = 5;
            // 
            // FindGoodsTable
            // 
            this.FindGoodsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FindGoodsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.FindGoodsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FindGoodsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindGoodsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode2,
            this.Name2,
            this.Cate2,
            this.Unit2,
            this.SalePrice2,
            this.Number2});
            this.FindGoodsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindGoodsTable.Location = new System.Drawing.Point(0, 0);
            this.FindGoodsTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FindGoodsTable.Name = "FindGoodsTable";
            this.FindGoodsTable.RowHeadersWidth = 51;
            this.FindGoodsTable.RowTemplate.Height = 24;
            this.FindGoodsTable.Size = new System.Drawing.Size(1130, 598);
            this.FindGoodsTable.TabIndex = 5;
            this.FindGoodsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FindGoodsTable_CellClick);
            this.FindGoodsTable.Leave += new System.EventHandler(this.FindGoodsTable_Leave);
            // 
            // Barcode2
            // 
            this.Barcode2.FillWeight = 80F;
            this.Barcode2.HeaderText = "ID";
            this.Barcode2.MinimumWidth = 6;
            this.Barcode2.Name = "Barcode2";
            // 
            // Name2
            // 
            this.Name2.FillWeight = 170F;
            this.Name2.HeaderText = "Tên sản phẩm";
            this.Name2.MinimumWidth = 6;
            this.Name2.Name = "Name2";
            // 
            // Cate2
            // 
            this.Cate2.FillWeight = 120F;
            this.Cate2.HeaderText = "Loại";
            this.Cate2.MinimumWidth = 6;
            this.Cate2.Name = "Cate2";
            // 
            // Unit2
            // 
            this.Unit2.FillWeight = 80F;
            this.Unit2.HeaderText = "Đơn vị";
            this.Unit2.MinimumWidth = 6;
            this.Unit2.Name = "Unit2";
            // 
            // SalePrice2
            // 
            this.SalePrice2.FillWeight = 80F;
            this.SalePrice2.HeaderText = "Giá bán";
            this.SalePrice2.MinimumWidth = 6;
            this.SalePrice2.Name = "SalePrice2";
            // 
            // Number2
            // 
            this.Number2.FillWeight = 80F;
            this.Number2.HeaderText = "Số lượng";
            this.Number2.MinimumWidth = 6;
            this.Number2.Name = "Number2";
            // 
            // FormSell
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1600, 894);
            this.ControlBox = false;
            this.Controls.Add(this.Find1Panel);
            this.Controls.Add(this.table);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSell";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.FormSell_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerClear)).EndInit();
            this.Find2Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FindCustomerTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.Find1Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FindGoodsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox TextBoxCustomer;
        private TextBox TextBoxNote;
        private Button SellBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label TotalLabel;
        private Label PayLabel;
        private Label RottenLabel;
        private TextBox TextBoxReceive;
        private Panel panel1;
        private Panel panel2;
        private TextBox TextBoxSearch;
        private DataGridView table;
        private Panel Find1Panel;
        private DataGridView FindGoodsTable;
        private Panel Find2Panel;
        private DataGridView FindCustomerTable;
        private Button NewCustomerBtn;
        private Label txtCus;
		private ComboBox SaleCombobox;
		private PictureBox CustomerClear;
		private PictureBox GoodsClear;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label1;
        private Label label10;
        private Label txtPoint;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn point;
        private DataGridViewTextBoxColumn Barcode2;
        private DataGridViewTextBoxColumn Name2;
        private DataGridViewTextBoxColumn Cate2;
        private DataGridViewTextBoxColumn Unit2;
        private DataGridViewTextBoxColumn SalePrice2;
        private DataGridViewTextBoxColumn Number2;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn PName;
        private DataGridViewTextBoxColumn Cate;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn SalePrice;
        private DataGridViewButtonColumn Dec;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewButtonColumn Inc;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewButtonColumn Delete;
    }
}