namespace GUI
{
	partial class SDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SDetailsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StaffTextbox = new System.Windows.Forms.TextBox();
            this.CustomerTextbox = new System.Windows.Forms.TextBox();
            this.BillTextbox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.SDetailsTable = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.STTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDetailsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffTextbox
            // 
            this.StaffTextbox.BackColor = System.Drawing.Color.SteelBlue;
            this.StaffTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.StaffTextbox.ForeColor = System.Drawing.Color.White;
            this.StaffTextbox.Location = new System.Drawing.Point(709, 204);
            this.StaffTextbox.Name = "StaffTextbox";
            this.StaffTextbox.ReadOnly = true;
            this.StaffTextbox.Size = new System.Drawing.Size(259, 29);
            this.StaffTextbox.TabIndex = 63;
            // 
            // CustomerTextbox
            // 
            this.CustomerTextbox.BackColor = System.Drawing.Color.SteelBlue;
            this.CustomerTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomerTextbox.ForeColor = System.Drawing.Color.White;
            this.CustomerTextbox.Location = new System.Drawing.Point(266, 204);
            this.CustomerTextbox.Name = "CustomerTextbox";
            this.CustomerTextbox.ReadOnly = true;
            this.CustomerTextbox.Size = new System.Drawing.Size(259, 29);
            this.CustomerTextbox.TabIndex = 61;
            // 
            // BillTextbox
            // 
            this.BillTextbox.BackColor = System.Drawing.Color.SteelBlue;
            this.BillTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.BillTextbox.ForeColor = System.Drawing.Color.White;
            this.BillTextbox.Location = new System.Drawing.Point(266, 119);
            this.BillTextbox.Name = "BillTextbox";
            this.BillTextbox.ReadOnly = true;
            this.BillTextbox.Size = new System.Drawing.Size(259, 29);
            this.BillTextbox.TabIndex = 60;
            // 
            // DateTextBox
            // 
            this.DateTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.DateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateTextBox.ForeColor = System.Drawing.Color.White;
            this.DateTextBox.Location = new System.Drawing.Point(709, 119);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.ReadOnly = true;
            this.DateTextBox.Size = new System.Drawing.Size(259, 29);
            this.DateTextBox.TabIndex = 62;
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(951, 41);
            this.exit.Margin = new System.Windows.Forms.Padding(6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 38);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 54;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // SDetailsTable
            // 
            this.SDetailsTable.AllowUserToAddRows = false;
            this.SDetailsTable.AllowUserToDeleteRows = false;
            this.SDetailsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SDetailsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SDetailsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SDetailsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SDetailsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SDetailsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTS,
            this.NameS,
            this.UnitS,
            this.UnitPriceS,
            this.NumberS});
            this.SDetailsTable.Location = new System.Drawing.Point(1, 286);
            this.SDetailsTable.Margin = new System.Windows.Forms.Padding(0);
            this.SDetailsTable.Name = "SDetailsTable";
            this.SDetailsTable.ReadOnly = true;
            this.SDetailsTable.RowHeadersVisible = false;
            this.SDetailsTable.RowHeadersWidth = 51;
            this.SDetailsTable.Size = new System.Drawing.Size(999, 292);
            this.SDetailsTable.TabIndex = 55;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(395, 53);
            this.title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(225, 57);
            this.title.TabIndex = 53;
            this.title.Text = "CHI TIẾT";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(523, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 29);
            this.label4.TabIndex = 59;
            this.label4.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(549, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 58;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // STTS
            // 
            this.STTS.HeaderText = "STT";
            this.STTS.MinimumWidth = 6;
            this.STTS.Name = "STTS";
            this.STTS.ReadOnly = true;
            // 
            // NameS
            // 
            this.NameS.HeaderText = "Tên sản phẩm";
            this.NameS.MinimumWidth = 6;
            this.NameS.Name = "NameS";
            this.NameS.ReadOnly = true;
            // 
            // UnitS
            // 
            this.UnitS.HeaderText = "Đơn vị";
            this.UnitS.MinimumWidth = 6;
            this.UnitS.Name = "UnitS";
            this.UnitS.ReadOnly = true;
            // 
            // UnitPriceS
            // 
            this.UnitPriceS.HeaderText = "Giá bán";
            this.UnitPriceS.MinimumWidth = 6;
            this.UnitPriceS.Name = "UnitPriceS";
            this.UnitPriceS.ReadOnly = true;
            // 
            // NumberS
            // 
            this.NumberS.HeaderText = "Số lượng";
            this.NumberS.MinimumWidth = 6;
            this.NumberS.Name = "NumberS";
            this.NumberS.ReadOnly = true;
            // 
            // SDetailsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1003, 608);
            this.ControlBox = false;
            this.Controls.Add(this.StaffTextbox);
            this.Controls.Add(this.CustomerTextbox);
            this.Controls.Add(this.BillTextbox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.SDetailsTable);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SDetailsForm";
            this.Text = "SDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDetailsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TextBox StaffTextbox;
        private System.Windows.Forms.TextBox CustomerTextbox;
        private System.Windows.Forms.TextBox BillTextbox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.DataGridView SDetailsTable;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameS;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitS;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberS;
    }
}
