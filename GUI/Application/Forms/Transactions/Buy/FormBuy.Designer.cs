namespace GUI
{
    partial class FormBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Button();
            this.inpSearch = new System.Windows.Forms.TextBox();
            this.chosen = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.download = new System.Windows.Forms.Button();
            this.empty = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imp_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.print = new System.Windows.Forms.Button();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
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
            this.pnlSearch.TabIndex = 118;
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
            // chosen
            // 
            this.chosen.AllowUserToAddRows = false;
            this.chosen.AllowUserToDeleteRows = false;
            this.chosen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chosen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.chosen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.chosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chosen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cCode,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.number,
            this.remove});
            this.chosen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chosen.EnableHeadersVisualStyles = false;
            this.chosen.Location = new System.Drawing.Point(0, 494);
            this.chosen.Name = "chosen";
            this.chosen.RowHeadersVisible = false;
            this.chosen.RowHeadersWidth = 51;
            this.chosen.RowTemplate.Height = 24;
            this.chosen.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chosen.Size = new System.Drawing.Size(1444, 400);
            this.chosen.TabIndex = 124;
            this.chosen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chosen_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cCode
            // 
            this.cCode.HeaderText = "Mã vạch";
            this.cCode.Name = "cCode";
            this.cCode.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngành hàng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Đơn vị";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // number
            // 
            this.number.HeaderText = "Số lượng";
            this.number.Name = "number";
            // 
            // remove
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            this.remove.DefaultCellStyle = dataGridViewCellStyle5;
            this.remove.HeaderText = "Xóa";
            this.remove.MinimumWidth = 6;
            this.remove.Name = "remove";
            this.remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.download);
            this.panel2.Controls.Add(this.print);
            this.panel2.Controls.Add(this.empty);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1444, 50);
            this.panel2.TabIndex = 125;
            // 
            // download
            // 
            this.download.BackColor = System.Drawing.Color.Transparent;
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.Dock = System.Windows.Forms.DockStyle.Right;
            this.download.FlatAppearance.BorderSize = 0;
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.download.ForeColor = System.Drawing.Color.White;
            this.download.Image = global::GUI.Properties.Resources.download;
            this.download.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.download.Location = new System.Drawing.Point(1292, 0);
            this.download.Margin = new System.Windows.Forms.Padding(5);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(50, 48);
            this.download.TabIndex = 113;
            this.download.Tag = "";
            this.download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // empty
            // 
            this.empty.BackColor = System.Drawing.Color.Transparent;
            this.empty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empty.Dock = System.Windows.Forms.DockStyle.Right;
            this.empty.FlatAppearance.BorderSize = 0;
            this.empty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empty.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.empty.ForeColor = System.Drawing.Color.White;
            this.empty.Image = global::GUI.Properties.Resources.trash;
            this.empty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.empty.Location = new System.Drawing.Point(1392, 0);
            this.empty.Margin = new System.Windows.Forms.Padding(5);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(50, 48);
            this.empty.TabIndex = 112;
            this.empty.Tag = "";
            this.empty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empty.UseVisualStyleBackColor = false;
            this.empty.Click += new System.EventHandler(this.empty_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.code,
            this.name,
            this.category,
            this.unit,
            this.imp_price,
            this.stock});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Location = new System.Drawing.Point(0, 50);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.table.Size = new System.Drawing.Size(1444, 394);
            this.table.TabIndex = 126;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
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
            this.imp_price.HeaderText = "Giá nhập cũ";
            this.imp_price.Name = "imp_price";
            this.imp_price.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Tồn kho";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.Transparent;
            this.print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print.Dock = System.Windows.Forms.DockStyle.Right;
            this.print.FlatAppearance.BorderSize = 0;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.print.ForeColor = System.Drawing.Color.White;
            this.print.Image = global::GUI.Properties.Resources.printing;
            this.print.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.print.Location = new System.Drawing.Point(1342, 0);
            this.print.Margin = new System.Windows.Forms.Padding(5);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(50, 48);
            this.print.TabIndex = 111;
            this.print.Tag = "";
            this.print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // FormBuy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1444, 894);
            this.ControlBox = false;
            this.Controls.Add(this.table);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chosen);
            this.Controls.Add(this.pnlSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuy";
            this.Text = "FormBuy";
            this.Load += new System.EventHandler(this.FormBuy_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosen)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox inpSearch;
        private System.Windows.Forms.DataGridView chosen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button empty;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn imp_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button print;
    }
}