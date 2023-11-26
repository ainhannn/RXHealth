namespace GUI
{
    partial class FormDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exit = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfg_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.avai = new System.Windows.Forms.CheckBox();
            this.rNum = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.inpCode = new System.Windows.Forms.TextBox();
            this.unit = new System.Windows.Forms.TextBox();
            this.iNum = new System.Windows.Forms.TextBox();
            this.eNum = new System.Windows.Forms.TextBox();
            this.currentNum = new System.Windows.Forms.TextBox();
            this.inpNum = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.speci = new System.Windows.Forms.Label();
            this.cate = new System.Windows.Forms.TextBox();
            this.rUnit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.exit.Location = new System.Drawing.Point(948, 15);
            this.exit.Margin = new System.Windows.Forms.Padding(6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 38);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 15;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExport.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(777, 13);
            this.btnExport.Margin = new System.Windows.Forms.Padding(6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(152, 39);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Xuất bán lẻ";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(394, 27);
            this.title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(188, 46);
            this.title.TabIndex = 13;
            this.title.Text = "CHI TIẾT";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.mfg_date,
            this.exp_date,
            this.number});
            this.table.Location = new System.Drawing.Point(31, 368);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(937, 292);
            this.table.TabIndex = 16;
            // 
            // id
            // 
            this.id.HeaderText = "STT";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // code
            // 
            this.code.HeaderText = "Mã sản phẩm";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // mfg_date
            // 
            this.mfg_date.HeaderText = "NSX";
            this.mfg_date.Name = "mfg_date";
            this.mfg_date.ReadOnly = true;
            // 
            // exp_date
            // 
            this.exp_date.HeaderText = "HSD";
            this.exp_date.Name = "exp_date";
            this.exp_date.ReadOnly = true;
            // 
            // number
            // 
            this.number.HeaderText = "Số lượng";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã vạch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngành hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(86, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Đơn vị:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(605, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số lượng xuất:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(605, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số lượng nhập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(605, 211);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tồn kho:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(605, 270);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Đang bán lẻ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(69, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Quy cách:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(486, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Số lượng:";
            // 
            // avai
            // 
            this.avai.AutoSize = true;
            this.avai.ForeColor = System.Drawing.Color.White;
            this.avai.Location = new System.Drawing.Point(851, 328);
            this.avai.Name = "avai";
            this.avai.Size = new System.Drawing.Size(94, 29);
            this.avai.TabIndex = 24;
            this.avai.Text = "Có sẵn";
            this.avai.UseVisualStyleBackColor = true;
            this.avai.CheckedChanged += new System.EventHandler(this.avai_CheckedChanged);
            // 
            // rNum
            // 
            this.rNum.BackColor = System.Drawing.Color.SteelBlue;
            this.rNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.rNum.ForeColor = System.Drawing.Color.White;
            this.rNum.Location = new System.Drawing.Point(783, 272);
            this.rNum.Name = "rNum";
            this.rNum.ReadOnly = true;
            this.rNum.Size = new System.Drawing.Size(63, 23);
            this.rNum.TabIndex = 29;
            this.rNum.Text = "0";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.SteelBlue;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Cursor = System.Windows.Forms.Cursors.Default;
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(236, 152);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(63, 23);
            this.name.TabIndex = 30;
            // 
            // inpCode
            // 
            this.inpCode.BackColor = System.Drawing.Color.SteelBlue;
            this.inpCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.inpCode.ForeColor = System.Drawing.Color.White;
            this.inpCode.Location = new System.Drawing.Point(236, 95);
            this.inpCode.Name = "inpCode";
            this.inpCode.ReadOnly = true;
            this.inpCode.Size = new System.Drawing.Size(63, 23);
            this.inpCode.TabIndex = 31;
            // 
            // unit
            // 
            this.unit.BackColor = System.Drawing.Color.SteelBlue;
            this.unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unit.Cursor = System.Windows.Forms.Cursors.Default;
            this.unit.ForeColor = System.Drawing.Color.White;
            this.unit.Location = new System.Drawing.Point(236, 270);
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Size = new System.Drawing.Size(63, 23);
            this.unit.TabIndex = 33;
            // 
            // iNum
            // 
            this.iNum.BackColor = System.Drawing.Color.SteelBlue;
            this.iNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.iNum.ForeColor = System.Drawing.Color.White;
            this.iNum.Location = new System.Drawing.Point(783, 95);
            this.iNum.Name = "iNum";
            this.iNum.ReadOnly = true;
            this.iNum.Size = new System.Drawing.Size(63, 23);
            this.iNum.TabIndex = 34;
            this.iNum.Text = "0";
            // 
            // eNum
            // 
            this.eNum.BackColor = System.Drawing.Color.SteelBlue;
            this.eNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.eNum.ForeColor = System.Drawing.Color.White;
            this.eNum.Location = new System.Drawing.Point(783, 152);
            this.eNum.Name = "eNum";
            this.eNum.ReadOnly = true;
            this.eNum.Size = new System.Drawing.Size(63, 23);
            this.eNum.TabIndex = 35;
            this.eNum.Text = "0";
            // 
            // currentNum
            // 
            this.currentNum.BackColor = System.Drawing.Color.SteelBlue;
            this.currentNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.currentNum.ForeColor = System.Drawing.Color.White;
            this.currentNum.Location = new System.Drawing.Point(783, 213);
            this.currentNum.Name = "currentNum";
            this.currentNum.ReadOnly = true;
            this.currentNum.Size = new System.Drawing.Size(63, 23);
            this.currentNum.TabIndex = 36;
            this.currentNum.Text = "0";
            // 
            // inpNum
            // 
            this.inpNum.BackColor = System.Drawing.Color.RoyalBlue;
            this.inpNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inpNum.ForeColor = System.Drawing.Color.White;
            this.inpNum.Location = new System.Drawing.Point(591, 22);
            this.inpNum.Name = "inpNum";
            this.inpNum.Size = new System.Drawing.Size(63, 23);
            this.inpNum.TabIndex = 37;
            this.inpNum.Text = "0";
            this.inpNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // capacity
            // 
            this.capacity.BackColor = System.Drawing.Color.RoyalBlue;
            this.capacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.capacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.capacity.ForeColor = System.Drawing.Color.White;
            this.capacity.Location = new System.Drawing.Point(180, 21);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(50, 23);
            this.capacity.TabIndex = 38;
            this.capacity.Text = "0";
            this.capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.speci);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.capacity);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.inpNum);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(0, 663);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 65);
            this.panel1.TabIndex = 39;
            // 
            // speci
            // 
            this.speci.AutoSize = true;
            this.speci.ForeColor = System.Drawing.Color.White;
            this.speci.Location = new System.Drawing.Point(236, 20);
            this.speci.Name = "speci";
            this.speci.Size = new System.Drawing.Size(0, 25);
            this.speci.TabIndex = 39;
            // 
            // cate
            // 
            this.cate.BackColor = System.Drawing.Color.SteelBlue;
            this.cate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cate.ForeColor = System.Drawing.Color.White;
            this.cate.Location = new System.Drawing.Point(236, 211);
            this.cate.Name = "cate";
            this.cate.ReadOnly = true;
            this.cate.Size = new System.Drawing.Size(259, 23);
            this.cate.TabIndex = 32;
            // 
            // rUnit
            // 
            this.rUnit.BackColor = System.Drawing.Color.SteelBlue;
            this.rUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.rUnit.ForeColor = System.Drawing.Color.White;
            this.rUnit.Location = new System.Drawing.Point(236, 321);
            this.rUnit.Name = "rUnit";
            this.rUnit.ReadOnly = true;
            this.rUnit.Size = new System.Drawing.Size(63, 23);
            this.rUnit.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(86, 319);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 25);
            this.label13.TabIndex = 40;
            this.label13.Text = "Đơn vị bán lẻ:";
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(999, 750);
            this.ControlBox = false;
            this.Controls.Add(this.rUnit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentNum);
            this.Controls.Add(this.eNum);
            this.Controls.Add(this.iNum);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.cate);
            this.Controls.Add(this.inpCode);
            this.Controls.Add(this.name);
            this.Controls.Add(this.rNum);
            this.Controls.Add(this.avai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetails";
            this.Load += new System.EventHandler(this.FormDetails_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDetails_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox avai;
        private System.Windows.Forms.TextBox currentNum;
        private System.Windows.Forms.TextBox eNum;
        private System.Windows.Forms.TextBox iNum;
        private System.Windows.Forms.TextBox unit;
        private System.Windows.Forms.TextBox inpCode;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox rNum;
        private System.Windows.Forms.TextBox capacity;
        private System.Windows.Forms.TextBox inpNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label speci;
        private System.Windows.Forms.TextBox cate;
        private System.Windows.Forms.TextBox rUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfg_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
    }
}