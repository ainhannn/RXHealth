namespace GUI
{
    partial class FormInvenChk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvenChk));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.download = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Button();
            this.inpSearch = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tên = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_imp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.download);
            this.panel3.Controls.Add(this.comboBoxFilter);
            this.panel3.Controls.Add(this.lblFilter);
            this.panel3.Controls.Add(this.pnlSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1600, 77);
            this.panel3.TabIndex = 2;
            // 
            // download
            // 
            this.download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.download.AutoSize = true;
            this.download.BackColor = System.Drawing.Color.RoyalBlue;
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.FlatAppearance.BorderSize = 0;
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.download.ForeColor = System.Drawing.Color.White;
            this.download.Image = ((System.Drawing.Image)(resources.GetObject("download.Image")));
            this.download.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.download.Location = new System.Drawing.Point(1536, 13);
            this.download.Margin = new System.Windows.Forms.Padding(5);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(50, 50);
            this.download.TabIndex = 120;
            this.download.Tag = "";
            this.download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "",
            "Thuốc kê đơn",
            "Thuốc không kê đơn",
            "Thực phẩm chức năng",
            "Chăm sóc cá nhân",
            "Dụng cụ y tế",
            "Thiết bị y tế"});
            this.comboBoxFilter.Location = new System.Drawing.Point(753, 24);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(230, 33);
            this.comboBoxFilter.TabIndex = 118;
            this.comboBoxFilter.SelectedValueChanged += new System.EventHandler(this.comboBoxFilter_SelectedValueChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(618, 27);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(129, 25);
            this.lblFilter.TabIndex = 119;
            this.lblFilter.Text = "Ngành hàng";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.search);
            this.pnlSearch.Controls.Add(this.inpSearch);
            this.pnlSearch.Location = new System.Drawing.Point(29, 13);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(50, 50);
            this.pnlSearch.TabIndex = 112;
            this.pnlSearch.MouseLeave += new System.EventHandler(this.pnlSearch_MouseLeave);
            this.pnlSearch.MouseHover += new System.EventHandler(this.search_MouseHover);
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
            this.search.Location = new System.Drawing.Point(0, 0);
            this.search.Margin = new System.Windows.Forms.Padding(5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(50, 50);
            this.search.TabIndex = 22;
            this.search.Tag = "";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.UseVisualStyleBackColor = false;
            this.search.MouseHover += new System.EventHandler(this.search_MouseHover);
            // 
            // inpSearch
            // 
            this.inpSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpSearch.Location = new System.Drawing.Point(8, 14);
            this.inpSearch.Margin = new System.Windows.Forms.Padding(0);
            this.inpSearch.Name = "inpSearch";
            this.inpSearch.Size = new System.Drawing.Size(237, 23);
            this.inpSearch.TabIndex = 21;
            this.inpSearch.TextChanged += new System.EventHandler(this.inpSearch_TextChanged);
            this.inpSearch.Enter += new System.EventHandler(this.search_MouseHover);
            this.inpSearch.Leave += new System.EventHandler(this.pnlSearch_MouseLeave);
            this.inpSearch.MouseHover += new System.EventHandler(this.search_MouseHover);
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
            this.code,
            this.Tên,
            this.category,
            this.unit,
            this.num_imp,
            this.num_exp,
            this.stock});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Location = new System.Drawing.Point(0, 77);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.table.Size = new System.Drawing.Size(1600, 817);
            this.table.TabIndex = 3;
            this.table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "STT";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // code
            // 
            this.code.HeaderText = "Mã vạch";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // Tên
            // 
            this.Tên.HeaderText = "Tên";
            this.Tên.Name = "Tên";
            this.Tên.ReadOnly = true;
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
            // num_imp
            // 
            this.num_imp.HeaderText = "Số lượng nhập";
            this.num_imp.Name = "num_imp";
            this.num_imp.ReadOnly = true;
            // 
            // num_exp
            // 
            this.num_exp.HeaderText = "Số lượng xuất";
            this.num_exp.Name = "num_exp";
            this.num_exp.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Tồn kho";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // FormInvenChk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1600, 894);
            this.ControlBox = false;
            this.Controls.Add(this.table);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInvenChk";
            this.Text = "FormInvenChk";
            this.Load += new System.EventHandler(this.FormInvenChk_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox inpSearch;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tên;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_imp;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_exp;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}