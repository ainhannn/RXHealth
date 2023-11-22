namespace GUI
{
	partial class SaleForm
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
			TextBoxSearch = new TextBox();
			table = new DataGridView();
			CusIDLabel = new DataGridViewTextBoxColumn();
			CusNameLabel = new DataGridViewTextBoxColumn();
			UnitLabel = new DataGridViewTextBoxColumn();
			UnitPriceLabel = new DataGridViewTextBoxColumn();
			NumberLabel = new DataGridViewTextBoxColumn();
			panel1 = new Panel();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			SellBtn = new Button();
			TextBoxNote = new TextBox();
			TextBoxCustomer = new TextBox();
			label10 = new Label();
			label7 = new Label();
			label8 = new Label();
			label1 = new Label();
			textBox1 = new TextBox();
			((System.ComponentModel.ISupportInitialize)table).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// TextBoxSearch
			// 
			TextBoxSearch.AcceptsReturn = true;
			TextBoxSearch.AcceptsTab = true;
			TextBoxSearch.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
			TextBoxSearch.Location = new Point(3, 72);
			TextBoxSearch.Margin = new Padding(3, 4, 3, 4);
			TextBoxSearch.MaximumSize = new Size(1200, 30);
			TextBoxSearch.MinimumSize = new Size(100, 30);
			TextBoxSearch.Name = "TextBoxSearch";
			TextBoxSearch.Size = new Size(1045, 30);
			TextBoxSearch.TabIndex = 94;
			TextBoxSearch.TextChanged += TextBoxSearch_TextChanged_1;
			// 
			// table
			// 
			table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			table.Columns.AddRange(new DataGridViewColumn[] { CusIDLabel, CusNameLabel, UnitLabel, UnitPriceLabel, NumberLabel });
			table.Location = new Point(3, 183);
			table.Margin = new Padding(3, 4, 3, 4);
			table.Name = "table";
			table.RowHeadersWidth = 51;
			table.RowTemplate.Height = 24;
			table.Size = new Size(1048, 632);
			table.TabIndex = 0;
			table.CellContentClick += dataGridView1_CellContentClick;
			// 
			// CusIDLabel
			// 
			CusIDLabel.HeaderText = "ID";
			CusIDLabel.MinimumWidth = 6;
			CusIDLabel.Name = "CusIDLabel";
			// 
			// CusNameLabel
			// 
			CusNameLabel.HeaderText = "Tên sản phẩm";
			CusNameLabel.MinimumWidth = 6;
			CusNameLabel.Name = "CusNameLabel";
			// 
			// UnitLabel
			// 
			UnitLabel.HeaderText = "Loại";
			UnitLabel.MinimumWidth = 6;
			UnitLabel.Name = "UnitLabel";
			// 
			// UnitPriceLabel
			// 
			UnitPriceLabel.HeaderText = "Giá bán";
			UnitPriceLabel.MinimumWidth = 6;
			UnitPriceLabel.Name = "UnitPriceLabel";
			// 
			// NumberLabel
			// 
			NumberLabel.HeaderText = "Số lượng";
			NumberLabel.MinimumWidth = 6;
			NumberLabel.Name = "NumberLabel";
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(label10);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(SellBtn);
			panel1.Controls.Add(TextBoxNote);
			panel1.Controls.Add(TextBoxCustomer);
			panel1.Controls.Add(table);
			panel1.Controls.Add(TextBoxSearch);
			panel1.ForeColor = SystemColors.ActiveCaptionText;
			panel1.Location = new Point(3, 3);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(1580, 830);
			panel1.TabIndex = 103;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(1110, 529);
			label6.Name = "label6";
			label6.Size = new Size(215, 29);
			label6.TabIndex = 110;
			label6.Text = "Tiền thừa khách trả";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(1110, 471);
			label5.Name = "label5";
			label5.Size = new Size(177, 29);
			label5.TabIndex = 109;
			label5.Text = "Tiền khách đưa";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(1110, 363);
			label4.Name = "label4";
			label4.Size = new Size(157, 29);
			label4.TabIndex = 108;
			label4.Text = "Khách cần trả";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(1108, 303);
			label3.Name = "label3";
			label3.Size = new Size(138, 29);
			label3.TabIndex = 107;
			label3.Text = "Khuyến mãi";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(1107, 239);
			label2.Name = "label2";
			label2.Size = new Size(174, 29);
			label2.TabIndex = 106;
			label2.Text = "Tổng tiền hàng";
			// 
			// SellBtn
			// 
			SellBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			SellBtn.Location = new Point(1129, 710);
			SellBtn.Margin = new Padding(3, 4, 3, 4);
			SellBtn.Name = "SellBtn";
			SellBtn.Size = new Size(411, 69);
			SellBtn.TabIndex = 105;
			SellBtn.Text = "Thanh toán";
			SellBtn.UseVisualStyleBackColor = true;
			SellBtn.Click += button1_Click;
			// 
			// TextBoxNote
			// 
			TextBoxNote.AcceptsReturn = true;
			TextBoxNote.AcceptsTab = true;
			TextBoxNote.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
			TextBoxNote.Location = new Point(1107, 626);
			TextBoxNote.Margin = new Padding(3, 4, 3, 4);
			TextBoxNote.MaximumSize = new Size(500, 30);
			TextBoxNote.MinimumSize = new Size(100, 30);
			TextBoxNote.Name = "TextBoxNote";
			TextBoxNote.Size = new Size(460, 30);
			TextBoxNote.TabIndex = 104;
			// 
			// TextBoxCustomer
			// 
			TextBoxCustomer.AcceptsReturn = true;
			TextBoxCustomer.AcceptsTab = true;
			TextBoxCustomer.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
			TextBoxCustomer.Location = new Point(1089, 136);
			TextBoxCustomer.Margin = new Padding(3, 4, 3, 4);
			TextBoxCustomer.MaximumSize = new Size(500, 30);
			TextBoxCustomer.MinimumSize = new Size(100, 30);
			TextBoxCustomer.Name = "TextBoxCustomer";
			TextBoxCustomer.Size = new Size(460, 30);
			TextBoxCustomer.TabIndex = 103;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(1386, 530);
			label10.Name = "label10";
			label10.Size = new Size(88, 31);
			label10.TabIndex = 115;
			label10.Text = "label10";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(1386, 302);
			label7.Name = "label7";
			label7.Size = new Size(76, 31);
			label7.TabIndex = 112;
			label7.Text = "label7";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(1386, 364);
			label8.Name = "label8";
			label8.Size = new Size(76, 31);
			label8.TabIndex = 113;
			label8.Text = "label8";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(1386, 237);
			label1.Name = "label1";
			label1.Size = new Size(76, 31);
			label1.TabIndex = 111;
			label1.Text = "label1";
			// 
			// textBox1
			// 
			textBox1.AcceptsReturn = true;
			textBox1.AcceptsTab = true;
			textBox1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(1342, 471);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.MaximumSize = new Size(500, 30);
			textBox1.MinimumSize = new Size(100, 30);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(207, 30);
			textBox1.TabIndex = 116;
			// 
			// SaleForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1584, 831);
			ControlBox = false;
			Controls.Add(panel1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "SaleForm";
			Text = "SaleForm";
			Load += SaleForm_Load;
			((System.ComponentModel.ISupportInitialize)table).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.TextBox TextBoxSearch;
		private System.Windows.Forms.DataGridView table;
		private System.Windows.Forms.DataGridViewTextBoxColumn CusIDLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn CusNameLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumberLabel;
		private System.Windows.Forms.Panel panel1;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Button SellBtn;
		private TextBox TextBoxNote;
		private TextBox TextBoxCustomer;
		private TextBox textBox1;
		private Label label10;
		private Label label8;
		private Label label7;
		private Label label1;
	}
}