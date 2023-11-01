using System.Windows.Forms;

namespace GUI
{
    partial class FormStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaff));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.inpSearch = new System.Windows.Forms.TextBox();
            this.download = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitizenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderIsMale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResignationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form = new System.Windows.Forms.Panel();
            this.inpGenderFemale = new System.Windows.Forms.RadioButton();
            this.inpGenderMale = new System.Windows.Forms.RadioButton();
            this.inpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnAccount = new System.Windows.Forms.Button();
            this.inpResignationDate = new System.Windows.Forms.DateTimePicker();
            this.inpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.inpAddress = new System.Windows.Forms.TextBox();
            this.inpCitizenId = new System.Windows.Forms.TextBox();
            this.inpContactNumber = new System.Windows.Forms.TextBox();
            this.inpNickname = new System.Windows.Forms.TextBox();
            this.inpAccount = new System.Windows.Forms.TextBox();
            this.inpQualification = new System.Windows.Forms.TextBox();
            this.inpFullName = new System.Windows.Forms.TextBox();
            this.inpId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.form.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.inpSearch);
            this.panel3.Controls.Add(this.download);
            this.panel3.Controls.Add(this.print);
            this.panel3.Controls.Add(this.upload);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1256, 77);
            this.panel3.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.RoyalBlue;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(280, 13);
            this.button8.Margin = new System.Windows.Forms.Padding(5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 22;
            this.button8.Tag = "";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // inpSearch
            // 
            this.inpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpSearch.Location = new System.Drawing.Point(20, 23);
            this.inpSearch.Margin = new System.Windows.Forms.Padding(5);
            this.inpSearch.Name = "inpSearch";
            this.inpSearch.Size = new System.Drawing.Size(250, 30);
            this.inpSearch.TabIndex = 21;
            // 
            // download
            // 
            this.download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.download.AutoSize = true;
            this.download.BackColor = System.Drawing.Color.RoyalBlue;
            this.download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.download.FlatAppearance.BorderSize = 0;
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.download.ForeColor = System.Drawing.Color.White;
            this.download.Image = ((System.Drawing.Image)(resources.GetObject("download.Image")));
            this.download.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.download.Location = new System.Drawing.Point(1066, 13);
            this.download.Margin = new System.Windows.Forms.Padding(5);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(50, 50);
            this.download.TabIndex = 18;
            this.download.Tag = "";
            this.download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // print
            // 
            this.print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print.BackColor = System.Drawing.Color.RoyalBlue;
            this.print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print.FlatAppearance.BorderSize = 0;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.print.ForeColor = System.Drawing.Color.White;
            this.print.Image = ((System.Drawing.Image)(resources.GetObject("print.Image")));
            this.print.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.print.Location = new System.Drawing.Point(1186, 13);
            this.print.Margin = new System.Windows.Forms.Padding(5);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(50, 50);
            this.print.TabIndex = 20;
            this.print.Tag = "";
            this.print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // upload
            // 
            this.upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upload.BackColor = System.Drawing.Color.RoyalBlue;
            this.upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upload.FlatAppearance.BorderSize = 0;
            this.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.upload.ForeColor = System.Drawing.Color.White;
            this.upload.Image = ((System.Drawing.Image)(resources.GetObject("upload.Image")));
            this.upload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.upload.Location = new System.Drawing.Point(1126, 13);
            this.upload.Margin = new System.Windows.Forms.Padding(5);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(50, 50);
            this.upload.TabIndex = 19;
            this.upload.Tag = "";
            this.upload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nickname,
            this.CitizenId,
            this.FullName,
            this.Birthday,
            this.GenderIsMale,
            this.Qualification,
            this.ContactNumber,
            this.Address,
            this.Account,
            this.StartDate,
            this.ResignationDate});
            this.table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Location = new System.Drawing.Point(0, 494);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(1256, 400);
            this.table.TabIndex = 1;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Nickname
            // 
            this.Nickname.HeaderText = "Tên Hiển Thị";
            this.Nickname.MaxInputLength = 16;
            this.Nickname.Name = "Nickname";
            // 
            // CitizenId
            // 
            this.CitizenId.HeaderText = "CMND /CCCD";
            this.CitizenId.MaxInputLength = 12;
            this.CitizenId.Name = "CitizenId";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ Và Tên";
            this.FullName.MaxInputLength = 50;
            this.FullName.Name = "FullName";
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Ngày Sinh";
            this.Birthday.Name = "Birthday";
            // 
            // GenderIsMale
            // 
            this.GenderIsMale.HeaderText = "Giới Tính";
            this.GenderIsMale.Name = "GenderIsMale";
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Bằng Cấp";
            this.Qualification.MaxInputLength = 50;
            this.Qualification.Name = "Qualification";
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "SĐT";
            this.ContactNumber.MaxInputLength = 12;
            this.ContactNumber.Name = "ContactNumber";
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.MaxInputLength = 100;
            this.Address.Name = "Address";
            // 
            // Account
            // 
            this.Account.HeaderText = "Tài Khoản";
            this.Account.MaxInputLength = 16;
            this.Account.Name = "Account";
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Bắt Đầu";
            this.StartDate.Name = "StartDate";
            // 
            // ResignationDate
            // 
            this.ResignationDate.HeaderText = "Nghỉ Việc";
            this.ResignationDate.Name = "ResignationDate";
            // 
            // form
            // 
            this.form.Controls.Add(this.inpGenderFemale);
            this.form.Controls.Add(this.inpGenderMale);
            this.form.Controls.Add(this.inpBirthday);
            this.form.Controls.Add(this.btnAccount);
            this.form.Controls.Add(this.inpResignationDate);
            this.form.Controls.Add(this.inpStartDate);
            this.form.Controls.Add(this.label1);
            this.form.Controls.Add(this.inpAddress);
            this.form.Controls.Add(this.inpCitizenId);
            this.form.Controls.Add(this.inpContactNumber);
            this.form.Controls.Add(this.inpNickname);
            this.form.Controls.Add(this.inpAccount);
            this.form.Controls.Add(this.inpQualification);
            this.form.Controls.Add(this.inpFullName);
            this.form.Controls.Add(this.inpId);
            this.form.Controls.Add(this.label11);
            this.form.Controls.Add(this.label10);
            this.form.Controls.Add(this.label9);
            this.form.Controls.Add(this.label8);
            this.form.Controls.Add(this.label7);
            this.form.Controls.Add(this.label6);
            this.form.Controls.Add(this.label5);
            this.form.Controls.Add(this.label4);
            this.form.Controls.Add(this.label3);
            this.form.Controls.Add(this.label2);
            this.form.Controls.Add(this.lblId);
            this.form.Controls.Add(this.save);
            this.form.Controls.Add(this.delete);
            this.form.Controls.Add(this.update);
            this.form.Controls.Add(this.create);
            this.form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.Location = new System.Drawing.Point(0, 77);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(1256, 417);
            this.form.TabIndex = 1;
            // 
            // inpGenderFemale
            // 
            this.inpGenderFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpGenderFemale.AutoSize = true;
            this.inpGenderFemale.Location = new System.Drawing.Point(1077, 110);
            this.inpGenderFemale.Name = "inpGenderFemale";
            this.inpGenderFemale.Size = new System.Drawing.Size(55, 29);
            this.inpGenderFemale.TabIndex = 113;
            this.inpGenderFemale.TabStop = true;
            this.inpGenderFemale.Text = "Nữ";
            this.inpGenderFemale.UseVisualStyleBackColor = true;
            // 
            // inpGenderMale
            // 
            this.inpGenderMale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpGenderMale.AutoSize = true;
            this.inpGenderMale.Location = new System.Drawing.Point(988, 110);
            this.inpGenderMale.Name = "inpGenderMale";
            this.inpGenderMale.Size = new System.Drawing.Size(71, 29);
            this.inpGenderMale.TabIndex = 112;
            this.inpGenderMale.TabStop = true;
            this.inpGenderMale.Text = "Nam";
            this.inpGenderMale.UseVisualStyleBackColor = true;
            // 
            // inpBirthday
            // 
            this.inpBirthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inpBirthday.Location = new System.Drawing.Point(575, 109);
            this.inpBirthday.Name = "inpBirthday";
            this.inpBirthday.Size = new System.Drawing.Size(200, 30);
            this.inpBirthday.TabIndex = 111;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAccount.Location = new System.Drawing.Point(73, 273);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(5);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(242, 50);
            this.btnAccount.TabIndex = 110;
            this.btnAccount.Tag = "";
            this.btnAccount.Text = "Cấp tài khoản";
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // inpResignationDate
            // 
            this.inpResignationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpResignationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inpResignationDate.Location = new System.Drawing.Point(988, 218);
            this.inpResignationDate.Name = "inpResignationDate";
            this.inpResignationDate.Size = new System.Drawing.Size(200, 30);
            this.inpResignationDate.TabIndex = 109;
            // 
            // inpStartDate
            // 
            this.inpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inpStartDate.Location = new System.Drawing.Point(575, 218);
            this.inpStartDate.Name = "inpStartDate";
            this.inpStartDate.Size = new System.Drawing.Size(200, 30);
            this.inpStartDate.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(825, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 106;
            this.label1.Text = "Nghỉ việc";
            // 
            // inpAddress
            // 
            this.inpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpAddress.Location = new System.Drawing.Point(988, 164);
            this.inpAddress.MaximumSize = new System.Drawing.Size(200, 30);
            this.inpAddress.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpAddress.Name = "inpAddress";
            this.inpAddress.Size = new System.Drawing.Size(200, 30);
            this.inpAddress.TabIndex = 105;
            // 
            // inpCitizenId
            // 
            this.inpCitizenId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpCitizenId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpCitizenId.Location = new System.Drawing.Point(988, 52);
            this.inpCitizenId.MaximumSize = new System.Drawing.Size(200, 30);
            this.inpCitizenId.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpCitizenId.Name = "inpCitizenId";
            this.inpCitizenId.Size = new System.Drawing.Size(200, 30);
            this.inpCitizenId.TabIndex = 103;
            // 
            // inpContactNumber
            // 
            this.inpContactNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpContactNumber.Location = new System.Drawing.Point(575, 164);
            this.inpContactNumber.MaximumSize = new System.Drawing.Size(200, 30);
            this.inpContactNumber.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpContactNumber.Name = "inpContactNumber";
            this.inpContactNumber.Size = new System.Drawing.Size(200, 30);
            this.inpContactNumber.TabIndex = 101;
            // 
            // inpNickname
            // 
            this.inpNickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpNickname.Location = new System.Drawing.Point(575, 52);
            this.inpNickname.MaximumSize = new System.Drawing.Size(200, 30);
            this.inpNickname.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpNickname.Name = "inpNickname";
            this.inpNickname.Size = new System.Drawing.Size(200, 30);
            this.inpNickname.TabIndex = 99;
            // 
            // inpAccount
            // 
            this.inpAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpAccount.Location = new System.Drawing.Point(184, 218);
            this.inpAccount.MaximumSize = new System.Drawing.Size(200, 30);
            this.inpAccount.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpAccount.Name = "inpAccount";
            this.inpAccount.Size = new System.Drawing.Size(200, 30);
            this.inpAccount.TabIndex = 98;
            // 
            // inpQualification
            // 
            this.inpQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpQualification.Location = new System.Drawing.Point(184, 164);
            this.inpQualification.MaximumSize = new System.Drawing.Size(200, 30);
            this.inpQualification.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpQualification.Name = "inpQualification";
            this.inpQualification.Size = new System.Drawing.Size(200, 30);
            this.inpQualification.TabIndex = 97;
            // 
            // inpFullName
            // 
            this.inpFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpFullName.Location = new System.Drawing.Point(184, 109);
            this.inpFullName.MaximumSize = new System.Drawing.Size(200, 30);
            this.inpFullName.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpFullName.Name = "inpFullName";
            this.inpFullName.Size = new System.Drawing.Size(200, 30);
            this.inpFullName.TabIndex = 96;
            // 
            // inpId
            // 
            this.inpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpId.Location = new System.Drawing.Point(184, 52);
            this.inpId.MaximumSize = new System.Drawing.Size(200, 30);
            this.inpId.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpId.Name = "inpId";
            this.inpId.Size = new System.Drawing.Size(200, 30);
            this.inpId.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(825, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 92;
            this.label11.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(825, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 91;
            this.label10.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(825, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 90;
            this.label9.Text = "CMND/CCCD";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(440, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 89;
            this.label8.Text = "Bắt đầu";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(440, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 88;
            this.label7.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(440, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 87;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(440, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 86;
            this.label5.Text = "Tên hiển thị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(68, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 85;
            this.label4.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(68, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 84;
            this.label3.Text = "Bằng cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(68, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Họ và tên";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblId.Location = new System.Drawing.Point(68, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 25);
            this.lblId.TabIndex = 82;
            this.lblId.Text = "ID";
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
            this.save.Location = new System.Drawing.Point(923, 346);
            this.save.Margin = new System.Windows.Forms.Padding(5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(50, 50);
            this.save.TabIndex = 81;
            this.save.Tag = "";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Image = global::GUI.Properties.Resources.trash;
            this.delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.delete.Location = new System.Drawing.Point(710, 346);
            this.delete.Margin = new System.Windows.Forms.Padding(5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(50, 50);
            this.delete.TabIndex = 80;
            this.delete.Tag = "";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.update.BackColor = System.Drawing.Color.RoyalBlue;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Image = global::GUI.Properties.Resources.compose;
            this.update.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.update.Location = new System.Drawing.Point(497, 346);
            this.update.Margin = new System.Windows.Forms.Padding(5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(50, 50);
            this.update.TabIndex = 79;
            this.update.Tag = "";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // create
            // 
            this.create.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.create.BackColor = System.Drawing.Color.RoyalBlue;
            this.create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.create.ForeColor = System.Drawing.Color.White;
            this.create.Image = ((System.Drawing.Image)(resources.GetObject("create.Image")));
            this.create.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.create.Location = new System.Drawing.Point(284, 346);
            this.create.Margin = new System.Windows.Forms.Padding(5);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(50, 50);
            this.create.TabIndex = 78;
            this.create.Tag = "";
            this.create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // FormStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1256, 894);
            this.ControlBox = false;
            this.Controls.Add(this.form);
            this.Controls.Add(this.table);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStaff";
            this.Text = "FormStaff";
            this.Activated += new System.EventHandler(this.FormStaff_Activated);
            this.Resize += new System.EventHandler(this.FormStaff_Resize);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private Button button8;
        private TextBox inpSearch;
        private Button download;
        private Button print;
        private Button upload;
        private DataGridView table;
        private Panel form;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblId;
        private Button save;
        private Button delete;
        private Button update;
        private Button create;
        private TextBox inpAddress;
        private TextBox inpCitizenId;
        private TextBox inpContactNumber;
        private TextBox inpNickname;
        private TextBox inpAccount;
        private TextBox inpQualification;
        private TextBox inpFullName;
        private TextBox inpId;
        private Label label1;
        private DateTimePicker inpResignationDate;
        private DateTimePicker inpStartDate;
        private Button btnAccount;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nickname;
        private DataGridViewTextBoxColumn CitizenId;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn GenderIsMale;
        private DataGridViewTextBoxColumn Qualification;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Account;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn ResignationDate;
        private RadioButton inpGenderFemale;
        private RadioButton inpGenderMale;
        private DateTimePicker inpBirthday;
    }
}