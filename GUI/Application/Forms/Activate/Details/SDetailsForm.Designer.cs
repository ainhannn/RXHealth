namespace GUI.Application.Forms.Activate.Details
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
			this.DetailsPanel = new System.Windows.Forms.Panel();
			this.DetailsTable = new System.Windows.Forms.DataGridView();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DetailsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DetailsTable)).BeginInit();
			this.SuspendLayout();
			// 
			// DetailsPanel
			// 
			this.DetailsPanel.Controls.Add(this.DetailsTable);
			this.DetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DetailsPanel.Location = new System.Drawing.Point(0, 0);
			this.DetailsPanel.Name = "DetailsPanel";
			this.DetailsPanel.Size = new System.Drawing.Size(800, 450);
			this.DetailsPanel.TabIndex = 0;
			// 
			// DetailsTable
			// 
			this.DetailsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DetailsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Barcode,
            this.Name,
            this.Unit,
            this.UnitPrice,
            this.Number});
			this.DetailsTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DetailsTable.Location = new System.Drawing.Point(0, 0);
			this.DetailsTable.Name = "DetailsTable";
			this.DetailsTable.RowHeadersWidth = 51;
			this.DetailsTable.RowTemplate.Height = 24;
			this.DetailsTable.Size = new System.Drawing.Size(800, 450);
			this.DetailsTable.TabIndex = 0;
			// 
			// STT
			// 
			this.STT.HeaderText = "STT";
			this.STT.MinimumWidth = 6;
			this.STT.Name = "STT";
			this.STT.Width = 125;
			// 
			// Barcode
			// 
			this.Barcode.HeaderText = "Mã sản phẩm";
			this.Barcode.MinimumWidth = 6;
			this.Barcode.Name = "Barcode";
			this.Barcode.Width = 125;
			// 
			// Name
			// 
			this.Name.FillWeight = 200F;
			this.Name.HeaderText = "Tên sản phẩm";
			this.Name.MinimumWidth = 6;
			this.Name.Name = "Name";
			this.Name.Width = 125;
			// 
			// Unit
			// 
			this.Unit.HeaderText = "Đơn vị";
			this.Unit.MinimumWidth = 6;
			this.Unit.Name = "Unit";
			this.Unit.Width = 125;
			// 
			// UnitPrice
			// 
			this.UnitPrice.HeaderText = "Giá";
			this.UnitPrice.MinimumWidth = 6;
			this.UnitPrice.Name = "UnitPrice";
			this.UnitPrice.Width = 125;
			// 
			// Number
			// 
			this.Number.HeaderText = "Số lượng";
			this.Number.MinimumWidth = 6;
			this.Number.Name = "Number";
			this.Number.Width = 125;
			// 
			// SDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DetailsPanel);
			this.Name = "SDetailsForm";
			this.Text = "SDetailsForm";
			this.DetailsPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DetailsTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel DetailsPanel;
		private System.Windows.Forms.DataGridView DetailsTable;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
	}
}