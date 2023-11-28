namespace GUI
{
    partial class FormPDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPDetails));
            this.save = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.impPrice = new System.Windows.Forms.TextBox();
            this.unit = new System.Windows.Forms.TextBox();
            this.inpCode = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.is_stopped = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exit = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stack = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.rUnit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.save.BackColor = System.Drawing.Color.PaleVioletRed;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumVioletRed;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(362, 740);
            this.save.Margin = new System.Windows.Forms.Padding(6);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(77, 39);
            this.save.TabIndex = 14;
            this.save.Text = "Lưu";
            this.save.UseVisualStyleBackColor = false;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.price.BackColor = System.Drawing.Color.SteelBlue;
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price.Cursor = System.Windows.Forms.Cursors.Default;
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(627, 362);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(140, 23);
            this.price.TabIndex = 59;
            this.price.Text = "...";
            // 
            // impPrice
            // 
            this.impPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.impPrice.BackColor = System.Drawing.Color.SteelBlue;
            this.impPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.impPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.impPrice.ForeColor = System.Drawing.Color.White;
            this.impPrice.Location = new System.Drawing.Point(132, 362);
            this.impPrice.Name = "impPrice";
            this.impPrice.ReadOnly = true;
            this.impPrice.Size = new System.Drawing.Size(140, 23);
            this.impPrice.TabIndex = 58;
            this.impPrice.Text = "...";
            // 
            // unit
            // 
            this.unit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unit.BackColor = System.Drawing.Color.SteelBlue;
            this.unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unit.Cursor = System.Windows.Forms.Cursors.Default;
            this.unit.ForeColor = System.Drawing.Color.White;
            this.unit.Location = new System.Drawing.Point(436, 362);
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Size = new System.Drawing.Size(63, 23);
            this.unit.TabIndex = 57;
            this.unit.Text = "...";
            // 
            // inpCode
            // 
            this.inpCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpCode.BackColor = System.Drawing.Color.SteelBlue;
            this.inpCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.inpCode.ForeColor = System.Drawing.Color.White;
            this.inpCode.Location = new System.Drawing.Point(436, 179);
            this.inpCode.Name = "inpCode";
            this.inpCode.ReadOnly = true;
            this.inpCode.Size = new System.Drawing.Size(331, 23);
            this.inpCode.TabIndex = 55;
            this.inpCode.Text = "...";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name.BackColor = System.Drawing.Color.SteelBlue;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Cursor = System.Windows.Forms.Cursors.Default;
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(436, 236);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(331, 23);
            this.name.TabIndex = 54;
            this.name.Text = "...";
            // 
            // is_stopped
            // 
            this.is_stopped.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.is_stopped.AutoSize = true;
            this.is_stopped.Enabled = false;
            this.is_stopped.ForeColor = System.Drawing.Color.White;
            this.is_stopped.Location = new System.Drawing.Point(640, 637);
            this.is_stopped.Name = "is_stopped";
            this.is_stopped.Size = new System.Drawing.Size(127, 29);
            this.is_stopped.TabIndex = 50;
            this.is_stopped.Text = "Ngừng bán";
            this.is_stopped.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 469);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Mô tả:";
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
            this.exit.Image = global::GUI.Properties.Resources.reject;
            this.exit.Location = new System.Drawing.Point(749, 15);
            this.exit.Margin = new System.Windows.Forms.Padding(6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 38);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 41;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(279, 36);
            this.title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(188, 46);
            this.title.TabIndex = 40;
            this.title.Text = "CHI TIẾT";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Giá nhập:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(286, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Đơn vị:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(286, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ngành hàng: *";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(286, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên: *";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã vạch: *";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(517, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Giá bán:";
            // 
            // stack
            // 
            this.stack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stack.BackColor = System.Drawing.Color.SteelBlue;
            this.stack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stack.Cursor = System.Windows.Forms.Cursors.Default;
            this.stack.ForeColor = System.Drawing.Color.White;
            this.stack.Location = new System.Drawing.Point(437, 118);
            this.stack.Name = "stack";
            this.stack.ReadOnly = true;
            this.stack.Size = new System.Drawing.Size(330, 23);
            this.stack.TabIndex = 63;
            this.stack.Text = "...";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(286, 116);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 25);
            this.label13.TabIndex = 62;
            this.label13.Text = "Ngăn chứa:";
            // 
            // category
            // 
            this.category.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.Enabled = false;
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Thuốc kê đơn",
            "Thuốc không kê đơn",
            "Thực phẩm chức năng",
            "Chăm sóc cá nhân",
            "Dụng cụ y tế",
            "Thiết bị y tế"});
            this.category.Location = new System.Drawing.Point(436, 293);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(331, 33);
            this.category.TabIndex = 121;
            // 
            // rUnit
            // 
            this.rUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rUnit.BackColor = System.Drawing.Color.SteelBlue;
            this.rUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.rUnit.ForeColor = System.Drawing.Color.White;
            this.rUnit.Location = new System.Drawing.Point(435, 396);
            this.rUnit.Name = "rUnit";
            this.rUnit.ReadOnly = true;
            this.rUnit.Size = new System.Drawing.Size(63, 23);
            this.rUnit.TabIndex = 123;
            this.rUnit.Text = "...";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(286, 396);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 25);
            this.label15.TabIndex = 122;
            this.label15.Text = "Đơn vị bán lẻ: *";
            // 
            // rPrice
            // 
            this.rPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rPrice.BackColor = System.Drawing.Color.SteelBlue;
            this.rPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.rPrice.ForeColor = System.Drawing.Color.White;
            this.rPrice.Location = new System.Drawing.Point(627, 396);
            this.rPrice.Name = "rPrice";
            this.rPrice.ReadOnly = true;
            this.rPrice.Size = new System.Drawing.Size(140, 23);
            this.rPrice.TabIndex = 125;
            this.rPrice.Text = "...";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(516, 396);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 25);
            this.label16.TabIndex = 124;
            this.label16.Text = "Giá bán lẻ:";
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Image = global::GUI.Properties.Resources.compose;
            this.edit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.edit.Location = new System.Drawing.Point(471, 36);
            this.edit.Margin = new System.Windows.Forms.Padding(5);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(50, 50);
            this.edit.TabIndex = 127;
            this.edit.Tag = "";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.RoyalBlue;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image.Enabled = false;
            this.image.Image = global::GUI.Properties.Resources.RXlogo;
            this.image.Location = new System.Drawing.Point(27, 116);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(208, 200);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 128;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // description
            // 
            this.description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.description.BackColor = System.Drawing.Color.SteelBlue;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Cursor = System.Windows.Forms.Cursors.Default;
            this.description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(133, 472);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(633, 150);
            this.description.TabIndex = 129;
            this.description.Text = "";
            // 
            // FormPDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 821);
            this.ControlBox = false;
            this.Controls.Add(this.image);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.rPrice);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.save);
            this.Controls.Add(this.rUnit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.category);
            this.Controls.Add(this.stack);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.price);
            this.Controls.Add(this.impPrice);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.inpCode);
            this.Controls.Add(this.name);
            this.Controls.Add(this.is_stopped);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.description);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPDetails";
            this.Load += new System.EventHandler(this.FormPDetails_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPDetails_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox impPrice;
        private System.Windows.Forms.TextBox unit;
        private System.Windows.Forms.TextBox inpCode;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.CheckBox is_stopped;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stack;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox rUnit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox rPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.RichTextBox description;
    }
}