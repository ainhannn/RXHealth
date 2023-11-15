namespace GUI
{
    partial class FormAccount
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
            this.avtForm = new System.Windows.Forms.Panel();
            this.inpNickname = new System.Windows.Forms.TextBox();
            this.editNickname = new System.Windows.Forms.Label();
            this.avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.form = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.inpTitle = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.inpGenderFemale = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.inpGenderMale = new System.Windows.Forms.RadioButton();
            this.inpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnAccount = new System.Windows.Forms.Button();
            this.inpAddress = new System.Windows.Forms.TextBox();
            this.inpCitizenId = new System.Windows.Forms.TextBox();
            this.inpContactNumber = new System.Windows.Forms.TextBox();
            this.inpAccount = new System.Windows.Forms.TextBox();
            this.inpQualification = new System.Windows.Forms.TextBox();
            this.inpFullName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.avtForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.form.SuspendLayout();
            this.SuspendLayout();
            // 
            // avtForm
            // 
            this.avtForm.BackColor = System.Drawing.SystemColors.Control;
            this.avtForm.Controls.Add(this.inpNickname);
            this.avtForm.Controls.Add(this.editNickname);
            this.avtForm.Controls.Add(this.avatar);
            this.avtForm.Controls.Add(this.lblNickname);
            this.avtForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.avtForm.Location = new System.Drawing.Point(0, 0);
            this.avtForm.Name = "avtForm";
            this.avtForm.Size = new System.Drawing.Size(456, 894);
            this.avtForm.TabIndex = 1;
            // 
            // inpNickname
            // 
            this.inpNickname.AcceptsReturn = true;
            this.inpNickname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpNickname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inpNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpNickname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inpNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 31F, System.Drawing.FontStyle.Bold);
            this.inpNickname.ForeColor = System.Drawing.Color.RoyalBlue;
            this.inpNickname.Location = new System.Drawing.Point(102, 566);
            this.inpNickname.MaximumSize = new System.Drawing.Size(500, 51);
            this.inpNickname.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpNickname.Name = "inpNickname";
            this.inpNickname.Size = new System.Drawing.Size(253, 51);
            this.inpNickname.TabIndex = 99;
            this.inpNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editNickname
            // 
            this.editNickname.AutoSize = true;
            this.editNickname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.editNickname.ForeColor = System.Drawing.Color.Navy;
            this.editNickname.Image = global::GUI.Properties.Resources.pencil;
            this.editNickname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editNickname.Location = new System.Drawing.Point(163, 625);
            this.editNickname.Name = "editNickname";
            this.editNickname.Size = new System.Drawing.Size(169, 29);
            this.editNickname.TabIndex = 120;
            this.editNickname.Text = "      Chỉnh sửa";
            this.editNickname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editNickname.Click += new System.EventHandler(this.editNickname_Click);
            // 
            // avatar
            // 
            this.avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatar.Image = global::GUI.Properties.Resources.user1;
            this.avatar.ImageRotate = 0F;
            this.avatar.Location = new System.Drawing.Point(78, 248);
            this.avatar.Name = "avatar";
            this.avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.avatar.Size = new System.Drawing.Size(300, 286);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // lblNickname
            // 
            this.lblNickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.lblNickname.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNickname.Location = new System.Drawing.Point(138, 566);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(223, 63);
            this.lblNickname.TabIndex = 121;
            this.lblNickname.Text = "abccddf";
            this.lblNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(456, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 894);
            this.panel2.TabIndex = 1;
            // 
            // form
            // 
            this.form.Controls.Add(this.label1);
            this.form.Controls.Add(this.inpTitle);
            this.form.Controls.Add(this.lblTitle);
            this.form.Controls.Add(this.inpGenderFemale);
            this.form.Controls.Add(this.save);
            this.form.Controls.Add(this.inpGenderMale);
            this.form.Controls.Add(this.inpBirthday);
            this.form.Controls.Add(this.btnAccount);
            this.form.Controls.Add(this.inpAddress);
            this.form.Controls.Add(this.inpCitizenId);
            this.form.Controls.Add(this.inpContactNumber);
            this.form.Controls.Add(this.inpAccount);
            this.form.Controls.Add(this.inpQualification);
            this.form.Controls.Add(this.inpFullName);
            this.form.Controls.Add(this.label11);
            this.form.Controls.Add(this.label10);
            this.form.Controls.Add(this.label9);
            this.form.Controls.Add(this.label7);
            this.form.Controls.Add(this.label6);
            this.form.Controls.Add(this.label4);
            this.form.Controls.Add(this.label3);
            this.form.Controls.Add(this.label2);
            this.form.Controls.Add(this.update);
            this.form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.Location = new System.Drawing.Point(461, 0);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(1139, 894);
            this.form.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(363, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 142;
            this.label1.Text = "Mật khẩu";
            // 
            // inpTitle
            // 
            this.inpTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inpTitle.FormattingEnabled = true;
            this.inpTitle.Items.AddRange(new object[] {
            "",
            "Bán hàng",
            "Quản kho",
            "Kế toán"});
            this.inpTitle.Location = new System.Drawing.Point(523, 658);
            this.inpTitle.Name = "inpTitle";
            this.inpTitle.Size = new System.Drawing.Size(350, 37);
            this.inpTitle.TabIndex = 142;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(363, 662);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 29);
            this.lblTitle.TabIndex = 140;
            this.lblTitle.Text = "Chức vụ";
            // 
            // inpGenderFemale
            // 
            this.inpGenderFemale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpGenderFemale.AutoSize = true;
            this.inpGenderFemale.Location = new System.Drawing.Point(640, 311);
            this.inpGenderFemale.Name = "inpGenderFemale";
            this.inpGenderFemale.Size = new System.Drawing.Size(66, 33);
            this.inpGenderFemale.TabIndex = 136;
            this.inpGenderFemale.TabStop = true;
            this.inpGenderFemale.Text = "Nữ";
            this.inpGenderFemale.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.save.BackColor = System.Drawing.Color.RoyalBlue;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Image = global::GUI.Properties.Resources.save;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.save.Location = new System.Drawing.Point(514, 780);
            this.save.Margin = new System.Windows.Forms.Padding(5);
            this.save.Name = "save";
            this.save.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.save.Size = new System.Drawing.Size(110, 50);
            this.save.TabIndex = 143;
            this.save.Tag = "";
            this.save.Text = "Lưu";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // inpGenderMale
            // 
            this.inpGenderMale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpGenderMale.AutoSize = true;
            this.inpGenderMale.Location = new System.Drawing.Point(526, 311);
            this.inpGenderMale.Name = "inpGenderMale";
            this.inpGenderMale.Size = new System.Drawing.Size(88, 33);
            this.inpGenderMale.TabIndex = 135;
            this.inpGenderMale.TabStop = true;
            this.inpGenderMale.Text = "Nam";
            this.inpGenderMale.UseVisualStyleBackColor = true;
            // 
            // inpBirthday
            // 
            this.inpBirthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpBirthday.CustomFormat = "dd-MM-yyyy";
            this.inpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inpBirthday.Location = new System.Drawing.Point(523, 368);
            this.inpBirthday.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpBirthday.Name = "inpBirthday";
            this.inpBirthday.Size = new System.Drawing.Size(350, 30);
            this.inpBirthday.TabIndex = 137;
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAccount.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAccount.Location = new System.Drawing.Point(526, 185);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(5);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(242, 50);
            this.btnAccount.TabIndex = 133;
            this.btnAccount.Tag = "";
            this.btnAccount.Text = "Đổi mật khẩu";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // inpAddress
            // 
            this.inpAddress.AcceptsReturn = true;
            this.inpAddress.AcceptsTab = true;
            this.inpAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpAddress.Location = new System.Drawing.Point(526, 484);
            this.inpAddress.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpAddress.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpAddress.Name = "inpAddress";
            this.inpAddress.Size = new System.Drawing.Size(350, 30);
            this.inpAddress.TabIndex = 139;
            // 
            // inpCitizenId
            // 
            this.inpCitizenId.AcceptsReturn = true;
            this.inpCitizenId.AcceptsTab = true;
            this.inpCitizenId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpCitizenId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpCitizenId.Location = new System.Drawing.Point(523, 426);
            this.inpCitizenId.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpCitizenId.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpCitizenId.Name = "inpCitizenId";
            this.inpCitizenId.Size = new System.Drawing.Size(350, 30);
            this.inpCitizenId.TabIndex = 138;
            // 
            // inpContactNumber
            // 
            this.inpContactNumber.AcceptsReturn = true;
            this.inpContactNumber.AcceptsTab = true;
            this.inpContactNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpContactNumber.Location = new System.Drawing.Point(523, 542);
            this.inpContactNumber.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpContactNumber.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpContactNumber.Name = "inpContactNumber";
            this.inpContactNumber.Size = new System.Drawing.Size(350, 30);
            this.inpContactNumber.TabIndex = 140;
            // 
            // inpAccount
            // 
            this.inpAccount.AcceptsReturn = true;
            this.inpAccount.AcceptsTab = true;
            this.inpAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpAccount.Location = new System.Drawing.Point(523, 137);
            this.inpAccount.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpAccount.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpAccount.Name = "inpAccount";
            this.inpAccount.Size = new System.Drawing.Size(350, 30);
            this.inpAccount.TabIndex = 132;
            // 
            // inpQualification
            // 
            this.inpQualification.AcceptsReturn = true;
            this.inpQualification.AcceptsTab = true;
            this.inpQualification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpQualification.Location = new System.Drawing.Point(523, 600);
            this.inpQualification.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpQualification.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpQualification.Name = "inpQualification";
            this.inpQualification.Size = new System.Drawing.Size(350, 30);
            this.inpQualification.TabIndex = 141;
            // 
            // inpFullName
            // 
            this.inpFullName.AcceptsReturn = true;
            this.inpFullName.AcceptsTab = true;
            this.inpFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpFullName.Location = new System.Drawing.Point(523, 253);
            this.inpFullName.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpFullName.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpFullName.Name = "inpFullName";
            this.inpFullName.Size = new System.Drawing.Size(350, 30);
            this.inpFullName.TabIndex = 134;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(363, 487);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 29);
            this.label11.TabIndex = 129;
            this.label11.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(363, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 29);
            this.label10.TabIndex = 128;
            this.label10.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(363, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 29);
            this.label9.TabIndex = 127;
            this.label9.Text = "CMND/CCCD";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(363, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 29);
            this.label7.TabIndex = 126;
            this.label7.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(363, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 125;
            this.label6.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(363, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 29);
            this.label4.TabIndex = 124;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(363, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 123;
            this.label3.Text = "Bằng cấp";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(363, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 122;
            this.label2.Text = "Họ và tên";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.RoyalBlue;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Image = global::GUI.Properties.Resources.compose;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.update.Location = new System.Drawing.Point(17, 14);
            this.update.Margin = new System.Windows.Forms.Padding(5);
            this.update.Name = "update";
            this.update.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.update.Size = new System.Drawing.Size(350, 50);
            this.update.TabIndex = 131;
            this.update.Tag = "";
            this.update.Text = "Chỉnh sửa thông tin cá nhân";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // FormAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1600, 894);
            this.ControlBox = false;
            this.Controls.Add(this.form);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.avtForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccount";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.Resize += new System.EventHandler(this.FormAccount_Resize);
            this.avtForm.ResumeLayout(false);
            this.avtForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel avtForm;
        private System.Windows.Forms.TextBox inpNickname;
        private System.Windows.Forms.Label editNickname;
        private Guna.UI2.WinForms.Guna2CirclePictureBox avatar;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inpTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton inpGenderFemale;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RadioButton inpGenderMale;
        private System.Windows.Forms.DateTimePicker inpBirthday;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.TextBox inpAddress;
        private System.Windows.Forms.TextBox inpCitizenId;
        private System.Windows.Forms.TextBox inpContactNumber;
        private System.Windows.Forms.TextBox inpAccount;
        private System.Windows.Forms.TextBox inpQualification;
        private System.Windows.Forms.TextBox inpFullName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update;
    }
}