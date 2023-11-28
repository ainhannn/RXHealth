namespace GUI
{
    partial class IDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDetailsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exit = new System.Windows.Forms.PictureBox();
            this.IDetailsTable = new System.Windows.Forms.DataGridView();
            this.STTI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportPriceI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BillTextboxI = new System.Windows.Forms.TextBox();
            this.StaffTextboxI = new System.Windows.Forms.TextBox();
            this.DateTextBoxI = new System.Windows.Forms.TextBox();
            this.ProviderTextboxI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDetailsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1218, 19);
            this.exit.Margin = new System.Windows.Forms.Padding(6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 38);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 43;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // IDetailsTable
            // 
            this.IDetailsTable.AllowUserToAddRows = false;
            this.IDetailsTable.AllowUserToDeleteRows = false;
            this.IDetailsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IDetailsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.IDetailsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IDetailsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.IDetailsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IDetailsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTI,
            this.BarcodeI,
            this.NameI,
            this.CreateI,
            this.DateI,
            this.UnitI,
            this.NumberI,
            this.ImportPriceI});
            this.IDetailsTable.Location = new System.Drawing.Point(2, 262);
            this.IDetailsTable.Margin = new System.Windows.Forms.Padding(0);
            this.IDetailsTable.Name = "IDetailsTable";
            this.IDetailsTable.ReadOnly = true;
            this.IDetailsTable.RowHeadersVisible = false;
            this.IDetailsTable.RowHeadersWidth = 51;
            this.IDetailsTable.Size = new System.Drawing.Size(1267, 292);
            this.IDetailsTable.TabIndex = 44;
            // 
            // STTI
            // 
            this.STTI.HeaderText = "STT";
            this.STTI.MinimumWidth = 6;
            this.STTI.Name = "STTI";
            this.STTI.ReadOnly = true;
            // 
            // BarcodeI
            // 
            this.BarcodeI.HeaderText = "Mã sản phẩm";
            this.BarcodeI.MinimumWidth = 6;
            this.BarcodeI.Name = "BarcodeI";
            this.BarcodeI.ReadOnly = true;
            // 
            // NameI
            // 
            this.NameI.HeaderText = "Tên sản phẩm";
            this.NameI.MinimumWidth = 6;
            this.NameI.Name = "NameI";
            this.NameI.ReadOnly = true;
            // 
            // CreateI
            // 
            this.CreateI.HeaderText = "NSX";
            this.CreateI.MinimumWidth = 6;
            this.CreateI.Name = "CreateI";
            this.CreateI.ReadOnly = true;
            // 
            // DateI
            // 
            this.DateI.HeaderText = "HSD";
            this.DateI.MinimumWidth = 6;
            this.DateI.Name = "DateI";
            this.DateI.ReadOnly = true;
            // 
            // UnitI
            // 
            this.UnitI.HeaderText = "Đơn vị";
            this.UnitI.MinimumWidth = 6;
            this.UnitI.Name = "UnitI";
            this.UnitI.ReadOnly = true;
            // 
            // NumberI
            // 
            this.NumberI.HeaderText = "Số lượng";
            this.NumberI.MinimumWidth = 6;
            this.NumberI.Name = "NumberI";
            this.NumberI.ReadOnly = true;
            // 
            // ImportPriceI
            // 
            this.ImportPriceI.HeaderText = "Giá bán";
            this.ImportPriceI.MinimumWidth = 6;
            this.ImportPriceI.Name = "ImportPriceI";
            this.ImportPriceI.ReadOnly = true;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(529, 31);
            this.title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(225, 57);
            this.title.TabIndex = 42;
            this.title.Text = "CHI TIẾT";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(78, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(710, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(685, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // BillTextboxI
            // 
            this.BillTextboxI.BackColor = System.Drawing.Color.SteelBlue;
            this.BillTextboxI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillTextboxI.Cursor = System.Windows.Forms.Cursors.Default;
            this.BillTextboxI.ForeColor = System.Drawing.Color.White;
            this.BillTextboxI.Location = new System.Drawing.Point(267, 97);
            this.BillTextboxI.Name = "BillTextboxI";
            this.BillTextboxI.ReadOnly = true;
            this.BillTextboxI.Size = new System.Drawing.Size(259, 29);
            this.BillTextboxI.TabIndex = 49;
            // 
            // StaffTextboxI
            // 
            this.StaffTextboxI.BackColor = System.Drawing.Color.SteelBlue;
            this.StaffTextboxI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffTextboxI.Cursor = System.Windows.Forms.Cursors.Default;
            this.StaffTextboxI.ForeColor = System.Drawing.Color.White;
            this.StaffTextboxI.Location = new System.Drawing.Point(267, 182);
            this.StaffTextboxI.Name = "StaffTextboxI";
            this.StaffTextboxI.ReadOnly = true;
            this.StaffTextboxI.Size = new System.Drawing.Size(259, 29);
            this.StaffTextboxI.TabIndex = 50;
            // 
            // DateTextBoxI
            // 
            this.DateTextBoxI.BackColor = System.Drawing.Color.SteelBlue;
            this.DateTextBoxI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTextBoxI.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateTextBoxI.ForeColor = System.Drawing.Color.White;
            this.DateTextBoxI.Location = new System.Drawing.Point(870, 97);
            this.DateTextBoxI.Name = "DateTextBoxI";
            this.DateTextBoxI.ReadOnly = true;
            this.DateTextBoxI.Size = new System.Drawing.Size(353, 29);
            this.DateTextBoxI.TabIndex = 51;
            // 
            // ProviderTextboxI
            // 
            this.ProviderTextboxI.BackColor = System.Drawing.Color.SteelBlue;
            this.ProviderTextboxI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProviderTextboxI.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProviderTextboxI.ForeColor = System.Drawing.Color.White;
            this.ProviderTextboxI.Location = new System.Drawing.Point(870, 182);
            this.ProviderTextboxI.Name = "ProviderTextboxI";
            this.ProviderTextboxI.ReadOnly = true;
            this.ProviderTextboxI.Size = new System.Drawing.Size(353, 29);
            this.ProviderTextboxI.TabIndex = 52;
            // 
            // IDetailsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1269, 617);
            this.ControlBox = false;
            this.Controls.Add(this.ProviderTextboxI);
            this.Controls.Add(this.DateTextBoxI);
            this.Controls.Add(this.StaffTextboxI);
            this.Controls.Add(this.BillTextboxI);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.IDetailsTable);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IDetailsForm";
            this.Text = "IDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDetailsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.DataGridView IDetailsTable;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTI;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateI;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportPriceI;
        private System.Windows.Forms.TextBox ProviderTextboxI;
        private System.Windows.Forms.TextBox DateTextBoxI;
        private System.Windows.Forms.TextBox StaffTextboxI;
        private System.Windows.Forms.TextBox BillTextboxI;
    }
}