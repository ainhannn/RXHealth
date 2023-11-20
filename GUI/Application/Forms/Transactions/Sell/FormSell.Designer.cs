﻿using System.Drawing;
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
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.CusIDLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusNameLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SellBtn = new System.Windows.Forms.Button();
            this.TextBoxNote = new System.Windows.Forms.TextBox();
            this.TextBoxCustomer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.AcceptsReturn = true;
            this.TextBoxSearch.AcceptsTab = true;
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextBoxSearch.Location = new System.Drawing.Point(2, 47);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxSearch.MaximumSize = new System.Drawing.Size(901, 30);
            this.TextBoxSearch.MinimumSize = new System.Drawing.Size(76, 30);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(785, 30);
            this.TextBoxSearch.TabIndex = 94;
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusIDLabel,
            this.CusNameLabel,
            this.UnitLabel,
            this.UnitPriceLabel,
            this.NumberLabel});
            this.table.Location = new System.Drawing.Point(2, 119);
            this.table.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(786, 411);
            this.table.TabIndex = 0;
            // 
            // CusIDLabel
            // 
            this.CusIDLabel.HeaderText = "ID";
            this.CusIDLabel.MinimumWidth = 6;
            this.CusIDLabel.Name = "CusIDLabel";
            // 
            // CusNameLabel
            // 
            this.CusNameLabel.HeaderText = "Tên sản phẩm";
            this.CusNameLabel.MinimumWidth = 6;
            this.CusNameLabel.Name = "CusNameLabel";
            // 
            // UnitLabel
            // 
            this.UnitLabel.HeaderText = "Loại";
            this.UnitLabel.MinimumWidth = 6;
            this.UnitLabel.Name = "UnitLabel";
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.HeaderText = "Giá bán";
            this.UnitPriceLabel.MinimumWidth = 6;
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            // 
            // NumberLabel
            // 
            this.NumberLabel.HeaderText = "Số lượng";
            this.NumberLabel.MinimumWidth = 6;
            this.NumberLabel.Name = "NumberLabel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SellBtn);
            this.panel1.Controls.Add(this.TextBoxNote);
            this.panel1.Controls.Add(this.TextBoxCustomer);
            this.panel1.Controls.Add(this.table);
            this.panel1.Controls.Add(this.TextBoxSearch);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 540);
            this.panel1.TabIndex = 103;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(1006, 306);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.MaximumSize = new System.Drawing.Size(376, 30);
            this.textBox1.MinimumSize = new System.Drawing.Size(76, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 30);
            this.textBox1.TabIndex = 116;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label10.Location = new System.Drawing.Point(1040, 344);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 115;
            this.label10.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label8.Location = new System.Drawing.Point(1040, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 113;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label7.Location = new System.Drawing.Point(1040, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 112;
            this.label7.Text = "label7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label1.Location = new System.Drawing.Point(1040, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 111;
            this.label1.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label6.Location = new System.Drawing.Point(832, 344);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 24);
            this.label6.TabIndex = 110;
            this.label6.Text = "Tiền thừa khách trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label5.Location = new System.Drawing.Point(832, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 109;
            this.label5.Text = "Tiền khách đưa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label4.Location = new System.Drawing.Point(832, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 108;
            this.label4.Text = "Khách cần trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label3.Location = new System.Drawing.Point(831, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 107;
            this.label3.Text = "Khuyến mãi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label2.Location = new System.Drawing.Point(830, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 106;
            this.label2.Text = "Tổng tiền hàng";
            // 
            // SellBtn
            // 
            this.SellBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.SellBtn.Location = new System.Drawing.Point(847, 461);
            this.SellBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SellBtn.Name = "SellBtn";
            this.SellBtn.Size = new System.Drawing.Size(308, 45);
            this.SellBtn.TabIndex = 105;
            this.SellBtn.Text = "Thanh toán";
            this.SellBtn.UseVisualStyleBackColor = true;
            // 
            // TextBoxNote
            // 
            this.TextBoxNote.AcceptsReturn = true;
            this.TextBoxNote.AcceptsTab = true;
            this.TextBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextBoxNote.Location = new System.Drawing.Point(830, 407);
            this.TextBoxNote.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxNote.MaximumSize = new System.Drawing.Size(376, 30);
            this.TextBoxNote.MinimumSize = new System.Drawing.Size(76, 30);
            this.TextBoxNote.Name = "TextBoxNote";
            this.TextBoxNote.Size = new System.Drawing.Size(346, 30);
            this.TextBoxNote.TabIndex = 104;
            // 
            // TextBoxCustomer
            // 
            this.TextBoxCustomer.AcceptsReturn = true;
            this.TextBoxCustomer.AcceptsTab = true;
            this.TextBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextBoxCustomer.Location = new System.Drawing.Point(817, 88);
            this.TextBoxCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxCustomer.MaximumSize = new System.Drawing.Size(376, 30);
            this.TextBoxCustomer.MinimumSize = new System.Drawing.Size(76, 30);
            this.TextBoxCustomer.Name = "TextBoxCustomer";
            this.TextBoxCustomer.Size = new System.Drawing.Size(346, 30);
            this.TextBoxCustomer.TabIndex = 103;
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 540);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSell";
            this.Text = "SaleForm";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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