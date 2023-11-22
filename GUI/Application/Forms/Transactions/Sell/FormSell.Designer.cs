using System.Drawing;
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
			this.Find2Panel = new System.Windows.Forms.Panel();
			this.FindCustomerTable = new System.Windows.Forms.DataGridView();
			this.Customer3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SaleCombobox = new System.Windows.Forms.ComboBox();
			this.ShowPhoneLabel = new System.Windows.Forms.Label();
			this.NewCustomerBtn = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.TextBoxSearch = new System.Windows.Forms.TextBox();
			this.table = new System.Windows.Forms.DataGridView();
			this.Barcode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unit1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SalePrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Plus1 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Minus1 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete1 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Find1Panel = new System.Windows.Forms.Panel();
			this.FindGoodsTable = new System.Windows.Forms.DataGridView();
			this.Barcode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SalePrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Number2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.Find2Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FindCustomerTable)).BeginInit();
			this.panel2.SuspendLayout();
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
			this.SellBtn.Text = "Thanh toán";
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
			this.label2.Size = new System.Drawing.Size(174, 29);
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
			this.label3.Size = new System.Drawing.Size(138, 29);
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
			this.label4.Size = new System.Drawing.Size(157, 29);
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
			this.label5.Size = new System.Drawing.Size(177, 29);
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
			this.label6.Size = new System.Drawing.Size(119, 29);
			this.label6.TabIndex = 110;
			this.label6.Text = "Tiền thừa ";
			// 
			// TotalLabel
			// 
			this.TotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.TotalLabel.AutoSize = true;
			this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
			this.TotalLabel.Location = new System.Drawing.Point(240, 304);
			this.TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TotalLabel.Name = "TotalLabel";
			this.TotalLabel.Size = new System.Drawing.Size(76, 31);
			this.TotalLabel.TabIndex = 111;
			this.TotalLabel.Text = "label1";
			// 
			// PayLabel
			// 
			this.PayLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PayLabel.AutoSize = true;
			this.PayLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
			this.PayLabel.Location = new System.Drawing.Point(240, 387);
			this.PayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PayLabel.Name = "PayLabel";
			this.PayLabel.Size = new System.Drawing.Size(76, 31);
			this.PayLabel.TabIndex = 113;
			this.PayLabel.Text = "label8";
			// 
			// RottenLabel
			// 
			this.RottenLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.RottenLabel.AutoSize = true;
			this.RottenLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
			this.RottenLabel.Location = new System.Drawing.Point(240, 494);
			this.RottenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.RottenLabel.Name = "RottenLabel";
			this.RottenLabel.Size = new System.Drawing.Size(88, 31);
			this.RottenLabel.TabIndex = 115;
			this.RottenLabel.Text = "label10";
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
			this.TextBoxReceive.Size = new System.Drawing.Size(156, 30);
			this.TextBoxReceive.TabIndex = 116;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.Find2Panel);
			this.panel1.Controls.Add(this.SaleCombobox);
			this.panel1.Controls.Add(this.ShowPhoneLabel);
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
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel1.Location = new System.Drawing.Point(1208, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(392, 894);
			this.panel1.TabIndex = 1;
			// 
			// Find2Panel
			// 
			this.Find2Panel.Controls.Add(this.FindCustomerTable);
			this.Find2Panel.Location = new System.Drawing.Point(30, 101);
			this.Find2Panel.Name = "Find2Panel";
			this.Find2Panel.Size = new System.Drawing.Size(346, 191);
			this.Find2Panel.TabIndex = 118;
			// 
			// FindCustomerTable
			// 
			this.FindCustomerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.FindCustomerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer3,
            this.Id});
			this.FindCustomerTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FindCustomerTable.Location = new System.Drawing.Point(0, 0);
			this.FindCustomerTable.Name = "FindCustomerTable";
			this.FindCustomerTable.RowHeadersWidth = 51;
			this.FindCustomerTable.RowTemplate.Height = 24;
			this.FindCustomerTable.Size = new System.Drawing.Size(346, 191);
			this.FindCustomerTable.TabIndex = 0;
			this.FindCustomerTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FindCustomerTable_CellClick);
			// 
			// Customer3
			// 
			this.Customer3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Customer3.HeaderText = "Số điện thoại";
			this.Customer3.MinimumWidth = 6;
			this.Customer3.Name = "Customer3";
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.MinimumWidth = 6;
			this.Id.Name = "Id";
			this.Id.Visible = false;
			this.Id.Width = 125;
			// 
			// SaleCombobox
			// 
			this.SaleCombobox.FormattingEnabled = true;
			this.SaleCombobox.Location = new System.Drawing.Point(206, 352);
			this.SaleCombobox.Name = "SaleCombobox";
			this.SaleCombobox.Size = new System.Drawing.Size(156, 24);
			this.SaleCombobox.TabIndex = 120;
			// 
			// ShowPhoneLabel
			// 
			this.ShowPhoneLabel.AutoSize = true;
			this.ShowPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ShowPhoneLabel.Location = new System.Drawing.Point(147, 167);
			this.ShowPhoneLabel.Name = "ShowPhoneLabel";
			this.ShowPhoneLabel.Size = new System.Drawing.Size(62, 29);
			this.ShowPhoneLabel.TabIndex = 119;
			this.ShowPhoneLabel.Text = "SDT";
			// 
			// NewCustomerBtn
			// 
			this.NewCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewCustomerBtn.Location = new System.Drawing.Point(250, 12);
			this.NewCustomerBtn.Name = "NewCustomerBtn";
			this.NewCustomerBtn.Size = new System.Drawing.Size(130, 48);
			this.NewCustomerBtn.TabIndex = 117;
			this.NewCustomerBtn.Text = "Thêm mới";
			this.NewCustomerBtn.UseVisualStyleBackColor = true;
			this.NewCustomerBtn.Click += new System.EventHandler(this.NewCustomerLabel_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.TextBoxSearch);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1208, 75);
			this.panel2.TabIndex = 2;
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
			// 
			// table
			// 
			this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode1,
            this.Name1,
            this.Cate1,
            this.Unit1,
            this.SalePrice1,
            this.Number1,
            this.Plus1,
            this.Minus1,
            this.Delete1});
			this.table.Dock = System.Windows.Forms.DockStyle.Fill;
			this.table.Location = new System.Drawing.Point(0, 75);
			this.table.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.table.Name = "table";
			this.table.RowHeadersWidth = 51;
			this.table.RowTemplate.Height = 24;
			this.table.Size = new System.Drawing.Size(1208, 819);
			this.table.TabIndex = 4;
			this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
			this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
			// 
			// Barcode1
			// 
			this.Barcode1.HeaderText = "ID";
			this.Barcode1.MinimumWidth = 6;
			this.Barcode1.Name = "Barcode1";
			// 
			// Name1
			// 
			this.Name1.HeaderText = "Tên sản phẩm";
			this.Name1.MinimumWidth = 6;
			this.Name1.Name = "Name1";
			// 
			// Cate1
			// 
			this.Cate1.HeaderText = "Loại";
			this.Cate1.MinimumWidth = 6;
			this.Cate1.Name = "Cate1";
			// 
			// Unit1
			// 
			this.Unit1.HeaderText = "Đơn vị";
			this.Unit1.MinimumWidth = 6;
			this.Unit1.Name = "Unit1";
			// 
			// SalePrice1
			// 
			this.SalePrice1.HeaderText = "Giá bán";
			this.SalePrice1.MinimumWidth = 6;
			this.SalePrice1.Name = "SalePrice1";
			// 
			// Number1
			// 
			this.Number1.HeaderText = "Số lượng";
			this.Number1.MinimumWidth = 6;
			this.Number1.Name = "Number1";
			// 
			// Plus1
			// 
			this.Plus1.HeaderText = "Cộng";
			this.Plus1.MinimumWidth = 6;
			this.Plus1.Name = "Plus1";
			// 
			// Minus1
			// 
			this.Minus1.HeaderText = "Trừ";
			this.Minus1.MinimumWidth = 6;
			this.Minus1.Name = "Minus1";
			// 
			// Delete1
			// 
			this.Delete1.HeaderText = "Xóa";
			this.Delete1.MinimumWidth = 6;
			this.Delete1.Name = "Delete1";
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
			// 
			// Barcode2
			// 
			this.Barcode2.HeaderText = "ID";
			this.Barcode2.MinimumWidth = 6;
			this.Barcode2.Name = "Barcode2";
			// 
			// Name2
			// 
			this.Name2.HeaderText = "Tên sản phẩm";
			this.Name2.MinimumWidth = 6;
			this.Name2.Name = "Name2";
			// 
			// Cate2
			// 
			this.Cate2.HeaderText = "Loại";
			this.Cate2.MinimumWidth = 6;
			this.Cate2.Name = "Cate2";
			// 
			// Unit2
			// 
			this.Unit2.HeaderText = "Đơn vị";
			this.Unit2.MinimumWidth = 6;
			this.Unit2.Name = "Unit2";
			// 
			// SalePrice2
			// 
			this.SalePrice2.HeaderText = "Giá bán";
			this.SalePrice2.MinimumWidth = 6;
			this.SalePrice2.Name = "SalePrice2";
			// 
			// Number2
			// 
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
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.Find2Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FindCustomerTable)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
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
        private DataGridViewTextBoxColumn Barcode2;
        private DataGridViewTextBoxColumn Name2;
        private DataGridViewTextBoxColumn Cate2;
        private DataGridViewTextBoxColumn Unit2;
        private DataGridViewTextBoxColumn SalePrice2;
        private DataGridViewTextBoxColumn Number2;
        private DataGridViewTextBoxColumn Barcode1;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn Cate1;
        private DataGridViewTextBoxColumn Unit1;
        private DataGridViewTextBoxColumn SalePrice1;
        private DataGridViewTextBoxColumn Number1;
        private DataGridViewButtonColumn Plus1;
        private DataGridViewButtonColumn Minus1;
        private DataGridViewButtonColumn Delete1;
        private Panel Find2Panel;
        private DataGridView FindCustomerTable;
        private Button NewCustomerBtn;
        private Label ShowPhoneLabel;
        private DataGridViewTextBoxColumn Customer3;
        private DataGridViewTextBoxColumn Id;
		private ComboBox SaleCombobox;
	}
}