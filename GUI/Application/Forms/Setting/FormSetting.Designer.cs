namespace GUI
{
    partial class FormSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.rate = new System.Windows.Forms.TextBox();
            this.vat = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(372, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 164;
            this.label1.Text = "Tỉ lệ lãi";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(594, 559);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 25);
            this.lblTitle.TabIndex = 161;
            this.lblTitle.Text = "Thành viên kim cương";
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
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.save.Location = new System.Drawing.Point(745, 789);
            this.save.Margin = new System.Windows.Forms.Padding(5);
            this.save.Name = "save";
            this.save.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.save.Size = new System.Drawing.Size(110, 50);
            this.save.TabIndex = 11;
            this.save.Tag = "";
            this.save.Text = "Lưu";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // rate
            // 
            this.rate.AcceptsReturn = true;
            this.rate.AcceptsTab = true;
            this.rate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rate.Location = new System.Drawing.Point(755, 221);
            this.rate.MaximumSize = new System.Drawing.Size(500, 30);
            this.rate.MinimumSize = new System.Drawing.Size(10, 30);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(100, 30);
            this.rate.TabIndex = 2;
            this.rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vat
            // 
            this.vat.AcceptsReturn = true;
            this.vat.AcceptsTab = true;
            this.vat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.vat.Location = new System.Drawing.Point(755, 154);
            this.vat.MaximumSize = new System.Drawing.Size(500, 30);
            this.vat.MinimumSize = new System.Drawing.Size(10, 30);
            this.vat.Name = "vat";
            this.vat.Size = new System.Drawing.Size(100, 30);
            this.vat.TabIndex = 1;
            this.vat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // price
            // 
            this.price.AcceptsReturn = true;
            this.price.AcceptsTab = true;
            this.price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.price.Location = new System.Drawing.Point(755, 288);
            this.price.MaximumSize = new System.Drawing.Size(500, 30);
            this.price.MinimumSize = new System.Drawing.Size(10, 30);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 30);
            this.price.TabIndex = 3;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(372, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 25);
            this.label11.TabIndex = 151;
            this.label11.Text = "Quyền lợi khách hàng";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(594, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 148;
            this.label7.Text = "Thành viên bạc";
            // 
            // lblVAT
            // 
            this.lblVAT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblVAT.Location = new System.Drawing.Point(372, 157);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(128, 25);
            this.lblVAT.TabIndex = 146;
            this.lblVAT.Text = "Thuế (VAT)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(594, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 145;
            this.label3.Text = "Thành viên vàng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(372, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 25);
            this.label2.TabIndex = 144;
            this.label2.Text = "Quy định tích điểm trên 1 hóa đơn";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(863, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 166;
            this.label4.Text = "đồng =";
            // 
            // point
            // 
            this.point.AcceptsReturn = true;
            this.point.AcceptsTab = true;
            this.point.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.point.Location = new System.Drawing.Point(944, 288);
            this.point.MaximumSize = new System.Drawing.Size(500, 30);
            this.point.MinimumSize = new System.Drawing.Size(10, 30);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(100, 30);
            this.point.TabIndex = 4;
            this.point.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1052, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 168;
            this.label5.Text = "điểm";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1135, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 172;
            this.label6.Text = "% giảm giá";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.AcceptsTab = true;
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox2.Location = new System.Drawing.Point(1027, 422);
            this.textBox2.MaximumSize = new System.Drawing.Size(500, 30);
            this.textBox2.MinimumSize = new System.Drawing.Size(10, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 30);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(946, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 170;
            this.label8.Text = "điểm =";
            // 
            // textBox3
            // 
            this.textBox3.AcceptsReturn = true;
            this.textBox3.AcceptsTab = true;
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox3.Location = new System.Drawing.Point(838, 422);
            this.textBox3.MaximumSize = new System.Drawing.Size(500, 30);
            this.textBox3.MinimumSize = new System.Drawing.Size(10, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 30);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(1135, 559);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 176;
            this.label9.Text = "% giảm giá";
            // 
            // textBox4
            // 
            this.textBox4.AcceptsReturn = true;
            this.textBox4.AcceptsTab = true;
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox4.Location = new System.Drawing.Point(1027, 556);
            this.textBox4.MaximumSize = new System.Drawing.Size(500, 30);
            this.textBox4.MinimumSize = new System.Drawing.Size(10, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 30);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(946, 559);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 174;
            this.label10.Text = "điểm =";
            // 
            // textBox5
            // 
            this.textBox5.AcceptsReturn = true;
            this.textBox5.AcceptsTab = true;
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox5.Location = new System.Drawing.Point(838, 556);
            this.textBox5.MaximumSize = new System.Drawing.Size(500, 30);
            this.textBox5.MinimumSize = new System.Drawing.Size(10, 30);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 30);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(1135, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 25);
            this.label12.TabIndex = 180;
            this.label12.Text = "% giảm giá";
            // 
            // textBox6
            // 
            this.textBox6.AcceptsReturn = true;
            this.textBox6.AcceptsTab = true;
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox6.Location = new System.Drawing.Point(1027, 489);
            this.textBox6.MaximumSize = new System.Drawing.Size(500, 30);
            this.textBox6.MinimumSize = new System.Drawing.Size(10, 30);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 30);
            this.textBox6.TabIndex = 8;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(946, 492);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 25);
            this.label13.TabIndex = 178;
            this.label13.Text = "điểm =";
            // 
            // textBox7
            // 
            this.textBox7.AcceptsReturn = true;
            this.textBox7.AcceptsTab = true;
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox7.Location = new System.Drawing.Point(838, 489);
            this.textBox7.MaximumSize = new System.Drawing.Size(500, 30);
            this.textBox7.MinimumSize = new System.Drawing.Size(10, 30);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 30);
            this.textBox7.TabIndex = 7;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1444, 894);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.point);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.save);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.vat);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox vat;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox point;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox7;
    }
}