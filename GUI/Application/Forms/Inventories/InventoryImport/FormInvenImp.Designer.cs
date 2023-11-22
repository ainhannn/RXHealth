namespace GUI
{
    partial class FormInvenImp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvenImp));
            this.table = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfg_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inpTotal = new System.Windows.Forms.Label();
            this.inpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.inpProvi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.upload = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.inpStaff = new System.Windows.Forms.TextBox();
            this.inpImpCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToOrderColumns = true;
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
            this.name,
            this.mfg_date,
            this.exp_date,
            this.unit,
            this.number,
            this.price});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(401, 0);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.table.Size = new System.Drawing.Size(1199, 894);
            this.table.TabIndex = 4;
            this.table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellValueChanged);
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
            // 
            // name
            // 
            this.name.HeaderText = "Tên";
            this.name.Name = "name";
            // 
            // mfg_date
            // 
            this.mfg_date.HeaderText = "NSX";
            this.mfg_date.Name = "mfg_date";
            // 
            // exp_date
            // 
            this.exp_date.HeaderText = "HSD";
            this.exp_date.Name = "exp_date";
            // 
            // unit
            // 
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            // 
            // number
            // 
            this.number.HeaderText = "Số lượng";
            this.number.Name = "number";
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.inpTotal);
            this.panel1.Controls.Add(this.inpDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inpProvi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.upload);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.inpStaff);
            this.panel1.Controls.Add(this.inpImpCode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 894);
            this.panel1.TabIndex = 3;
            // 
            // inpTotal
            // 
            this.inpTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpTotal.AutoSize = true;
            this.inpTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.inpTotal.ForeColor = System.Drawing.Color.White;
            this.inpTotal.Location = new System.Drawing.Point(169, 545);
            this.inpTotal.Name = "inpTotal";
            this.inpTotal.Size = new System.Drawing.Size(24, 25);
            this.inpTotal.TabIndex = 115;
            this.inpTotal.Tag = "Tổng tiền             0";
            this.inpTotal.Text = "0";
            // 
            // inpDate
            // 
            this.inpDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpDate.CustomFormat = "dd-MM-yyyy";
            this.inpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inpDate.Location = new System.Drawing.Point(174, 267);
            this.inpDate.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpDate.Name = "inpDate";
            this.inpDate.Size = new System.Drawing.Size(200, 30);
            this.inpDate.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 114;
            this.label2.Text = "Nhân viên";
            // 
            // inpProvi
            // 
            this.inpProvi.AcceptsReturn = true;
            this.inpProvi.AcceptsTab = true;
            this.inpProvi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpProvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpProvi.Location = new System.Drawing.Point(174, 451);
            this.inpProvi.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpProvi.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpProvi.Name = "inpProvi";
            this.inpProvi.Size = new System.Drawing.Size(200, 30);
            this.inpProvi.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 112;
            this.label1.Text = "Nhà cung cấp";
            // 
            // upload
            // 
            this.upload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.upload.BackColor = System.Drawing.Color.RoyalBlue;
            this.upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upload.FlatAppearance.BorderSize = 0;
            this.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.upload.ForeColor = System.Drawing.Color.White;
            this.upload.Image = ((System.Drawing.Image)(resources.GetObject("upload.Image")));
            this.upload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.upload.Location = new System.Drawing.Point(79, 50);
            this.upload.Margin = new System.Windows.Forms.Padding(5);
            this.upload.Name = "upload";
            this.upload.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.upload.Size = new System.Drawing.Size(240, 50);
            this.upload.TabIndex = 111;
            this.upload.Tag = "";
            this.upload.Text = "Nhập Danh sách";
            this.upload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save.BackColor = System.Drawing.Color.RoyalBlue;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Image = global::GUI.Properties.Resources.save;
            this.save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.save.Location = new System.Drawing.Point(174, 662);
            this.save.Margin = new System.Windows.Forms.Padding(5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(50, 50);
            this.save.TabIndex = 110;
            this.save.Tag = "";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 106;
            this.label8.Tag = "Tổng tiền             0";
            this.label8.Text = "Tổng tiền";
            // 
            // inpStaff
            // 
            this.inpStaff.AcceptsReturn = true;
            this.inpStaff.AcceptsTab = true;
            this.inpStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpStaff.Enabled = false;
            this.inpStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpStaff.Location = new System.Drawing.Point(174, 360);
            this.inpStaff.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpStaff.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpStaff.Name = "inpStaff";
            this.inpStaff.Size = new System.Drawing.Size(200, 30);
            this.inpStaff.TabIndex = 106;
            // 
            // inpImpCode
            // 
            this.inpImpCode.AcceptsReturn = true;
            this.inpImpCode.AcceptsTab = true;
            this.inpImpCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpImpCode.Enabled = false;
            this.inpImpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpImpCode.Location = new System.Drawing.Point(174, 178);
            this.inpImpCode.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpImpCode.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpImpCode.Name = "inpImpCode";
            this.inpImpCode.Size = new System.Drawing.Size(200, 30);
            this.inpImpCode.TabIndex = 104;
            this.inpImpCode.Text = "auto";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 103;
            this.label7.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 102;
            this.label5.Text = "Mã đơn nhập";
            // 
            // FormInvenImp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1600, 894);
            this.ControlBox = false;
            this.Controls.Add(this.table);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInvenImp";
            this.Text = "FormInvenImp";
            this.Load += new System.EventHandler(this.FormInvenImp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfg_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inpStaff;
        private System.Windows.Forms.TextBox inpImpCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inpProvi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker inpDate;
        private System.Windows.Forms.Label inpTotal;
    }
}