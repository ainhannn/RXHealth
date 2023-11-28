namespace GUI
{
    partial class FormCateDrug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCateDrug));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Button();
            this.inpSearch = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imp_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retail_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retail_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_stopped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.insert = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.RecycleBin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.upload = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.inpPriceMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inpPriceMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isStopped = new System.Windows.Forms.CheckBox();
            this.inpRUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inpUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inpCate = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.search);
            this.pnlSearch.Controls.Add(this.inpSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1444, 50);
            this.pnlSearch.TabIndex = 113;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.RoyalBlue;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Dock = System.Windows.Forms.DockStyle.Right;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search.Location = new System.Drawing.Point(1392, 0);
            this.search.Margin = new System.Windows.Forms.Padding(5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(50, 48);
            this.search.TabIndex = 22;
            this.search.Tag = "";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.UseVisualStyleBackColor = false;
            // 
            // inpSearch
            // 
            this.inpSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpSearch.Location = new System.Drawing.Point(8, 14);
            this.inpSearch.Margin = new System.Windows.Forms.Padding(0);
            this.inpSearch.Name = "inpSearch";
            this.inpSearch.Size = new System.Drawing.Size(1530, 23);
            this.inpSearch.TabIndex = 21;
            this.inpSearch.TextChanged += new System.EventHandler(this.inpSearch_TextChanged);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.stack,
            this.code,
            this.name,
            this.category,
            this.unit,
            this.imp_price,
            this.price,
            this.retail_unit,
            this.retail_price,
            this.is_stopped,
            this.selectDelete});
            this.table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Location = new System.Drawing.Point(0, 494);
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.table.Size = new System.Drawing.Size(1444, 400);
            this.table.TabIndex = 115;
            this.table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "STT";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // stack
            // 
            this.stack.HeaderText = "Ngăn chứa";
            this.stack.Name = "stack";
            this.stack.ReadOnly = true;
            // 
            // code
            // 
            this.code.HeaderText = "Mã vạch";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "Ngành hàng";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // imp_price
            // 
            this.imp_price.HeaderText = "Giá nhập";
            this.imp_price.Name = "imp_price";
            this.imp_price.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Giá bán";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // retail_unit
            // 
            this.retail_unit.HeaderText = "Đơn vị lẻ";
            this.retail_unit.Name = "retail_unit";
            this.retail_unit.ReadOnly = true;
            // 
            // retail_price
            // 
            this.retail_price.HeaderText = "Giá bán lẻ";
            this.retail_price.Name = "retail_price";
            this.retail_price.ReadOnly = true;
            // 
            // is_stopped
            // 
            this.is_stopped.HeaderText = "Ngừng bán";
            this.is_stopped.Name = "is_stopped";
            this.is_stopped.ReadOnly = true;
            this.is_stopped.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_stopped.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // selectDelete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            this.selectDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.selectDelete.HeaderText = "Xóa";
            this.selectDelete.MinimumWidth = 6;
            this.selectDelete.Name = "selectDelete";
            this.selectDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.insert);
            this.panel2.Controls.Add(this.refresh);
            this.panel2.Controls.Add(this.RecycleBin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1444, 50);
            this.panel2.TabIndex = 116;
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.MidnightBlue;
            this.insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.insert.FlatAppearance.BorderSize = 0;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.insert.Location = new System.Drawing.Point(1344, 0);
            this.insert.Margin = new System.Windows.Forms.Padding(5);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(50, 50);
            this.insert.TabIndex = 113;
            this.insert.Tag = "";
            this.insert.Text = "+";
            this.insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.MidnightBlue;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Image = global::GUI.Properties.Resources.save;
            this.refresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.refresh.Location = new System.Drawing.Point(1394, 0);
            this.refresh.Margin = new System.Windows.Forms.Padding(5);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(50, 50);
            this.refresh.TabIndex = 111;
            this.refresh.Tag = "";
            this.refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // RecycleBin
            // 
            this.RecycleBin.BackColor = System.Drawing.Color.MidnightBlue;
            this.RecycleBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecycleBin.Dock = System.Windows.Forms.DockStyle.Left;
            this.RecycleBin.FlatAppearance.BorderSize = 0;
            this.RecycleBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecycleBin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.RecycleBin.ForeColor = System.Drawing.Color.White;
            this.RecycleBin.Image = global::GUI.Properties.Resources.trash;
            this.RecycleBin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RecycleBin.Location = new System.Drawing.Point(0, 0);
            this.RecycleBin.Margin = new System.Windows.Forms.Padding(5);
            this.RecycleBin.Name = "RecycleBin";
            this.RecycleBin.Size = new System.Drawing.Size(50, 50);
            this.RecycleBin.TabIndex = 112;
            this.RecycleBin.Tag = "";
            this.RecycleBin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RecycleBin.UseVisualStyleBackColor = false;
            this.RecycleBin.Click += new System.EventHandler(this.RecycleBin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.upload);
            this.panel1.Controls.Add(this.download);
            this.panel1.Controls.Add(this.inpPriceMax);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.inpPriceMin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.isStopped);
            this.panel1.Controls.Add(this.inpRUnit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inpName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inpUnit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inpCate);
            this.panel1.Controls.Add(this.lblFilter);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 394);
            this.panel1.TabIndex = 117;
            // 
            // upload
            // 
            this.upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upload.BackColor = System.Drawing.Color.RoyalBlue;
            this.upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upload.FlatAppearance.BorderSize = 0;
            this.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.upload.ForeColor = System.Drawing.Color.White;
            this.upload.Image = ((System.Drawing.Image)(resources.GetObject("upload.Image")));
            this.upload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.upload.Location = new System.Drawing.Point(1393, 66);
            this.upload.Margin = new System.Windows.Forms.Padding(5);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(50, 50);
            this.upload.TabIndex = 133;
            this.upload.Tag = "";
            this.upload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // download
            // 
            this.download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.download.BackColor = System.Drawing.Color.RoyalBlue;
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.FlatAppearance.BorderSize = 0;
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.download.ForeColor = System.Drawing.Color.White;
            this.download.Image = ((System.Drawing.Image)(resources.GetObject("download.Image")));
            this.download.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.download.Location = new System.Drawing.Point(1393, 9);
            this.download.Margin = new System.Windows.Forms.Padding(5);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(50, 50);
            this.download.TabIndex = 118;
            this.download.Tag = "";
            this.download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // inpPriceMax
            // 
            this.inpPriceMax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpPriceMax.Location = new System.Drawing.Point(554, 205);
            this.inpPriceMax.Name = "inpPriceMax";
            this.inpPriceMax.Size = new System.Drawing.Size(112, 30);
            this.inpPriceMax.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(502, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 131;
            this.label5.Text = "đến";
            // 
            // inpPriceMin
            // 
            this.inpPriceMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpPriceMin.Location = new System.Drawing.Point(386, 205);
            this.inpPriceMin.Name = "inpPriceMin";
            this.inpPriceMin.Size = new System.Drawing.Size(112, 30);
            this.inpPriceMin.TabIndex = 130;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(230, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 129;
            this.label4.Text = "Khoảng giá từ";
            // 
            // isStopped
            // 
            this.isStopped.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.isStopped.AutoSize = true;
            this.isStopped.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isStopped.ForeColor = System.Drawing.Color.White;
            this.isStopped.Location = new System.Drawing.Point(827, 207);
            this.isStopped.Name = "isStopped";
            this.isStopped.Size = new System.Drawing.Size(136, 29);
            this.isStopped.TabIndex = 128;
            this.isStopped.Text = "Ngừng bán";
            this.isStopped.UseVisualStyleBackColor = true;
            // 
            // inpRUnit
            // 
            this.inpRUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpRUnit.Location = new System.Drawing.Point(984, 140);
            this.inpRUnit.Name = "inpRUnit";
            this.inpRUnit.Size = new System.Drawing.Size(230, 30);
            this.inpRUnit.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(822, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 126;
            this.label3.Text = "Đơn vị bán lẻ";
            // 
            // inpName
            // 
            this.inpName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpName.Location = new System.Drawing.Point(386, 73);
            this.inpName.Name = "inpName";
            this.inpName.Size = new System.Drawing.Size(230, 30);
            this.inpName.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 124;
            this.label2.Text = "Tên";
            // 
            // inpUnit
            // 
            this.inpUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpUnit.Location = new System.Drawing.Point(386, 140);
            this.inpUnit.Name = "inpUnit";
            this.inpUnit.Size = new System.Drawing.Size(230, 30);
            this.inpUnit.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 122;
            this.label1.Text = "Đơn vị";
            // 
            // inpCate
            // 
            this.inpCate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inpCate.FormattingEnabled = true;
            this.inpCate.Items.AddRange(new object[] {
            "",
            "Thuốc kê đơn",
            "Thuốc không kê đơn",
            "Thực phẩm chức năng",
            "Chăm sóc cá nhân",
            "Dụng cụ y tế",
            "Thiết bị y tế"});
            this.inpCate.Location = new System.Drawing.Point(984, 73);
            this.inpCate.Name = "inpCate";
            this.inpCate.Size = new System.Drawing.Size(230, 33);
            this.inpCate.TabIndex = 120;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(822, 76);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(129, 25);
            this.lblFilter.TabIndex = 121;
            this.lblFilter.Text = "Ngành hàng";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(660, 272);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 50);
            this.btnSearch.TabIndex = 107;
            this.btnSearch.Tag = "";
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormCateDrug
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1444, 894);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.table);
            this.Controls.Add(this.pnlSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCateDrug";
            this.Text = "FormCateDrug";
            this.Load += new System.EventHandler(this.FormCateDrug_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox inpSearch;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button RecycleBin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox inpCate;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox inpUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isStopped;
        private System.Windows.Forms.TextBox inpRUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpPriceMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inpPriceMin;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stack;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn imp_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn retail_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn retail_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_stopped;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDelete;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button upload;
    }
}