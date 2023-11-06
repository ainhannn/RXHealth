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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.download = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.Button();
            this.inpSearch = new System.Windows.Forms.TextBox();
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
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResignationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.form = new System.Windows.Forms.Panel();
            this.inpTitle = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.inpGenderFemale = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
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
            this.update = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            this.form.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.comboBoxFilter);
            this.panel3.Controls.Add(this.download);
            this.panel3.Controls.Add(this.lblFilter);
            this.panel3.Controls.Add(this.print);
            this.panel3.Controls.Add(this.upload);
            this.panel3.Controls.Add(this.pnlSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1600, 77);
            this.panel3.TabIndex = 1;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "",
            "Bán hàng",
            "Quản kho",
            "Kế toán"});
            this.comboBoxFilter.Location = new System.Drawing.Point(789, 22);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(120, 33);
            this.comboBoxFilter.TabIndex = 114;
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
            this.download.Location = new System.Drawing.Point(1410, 13);
            this.download.Margin = new System.Windows.Forms.Padding(5);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(50, 50);
            this.download.TabIndex = 18;
            this.download.Tag = "";
            this.download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblFilter.ForeColor = System.Drawing.Color.White;
            this.lblFilter.Location = new System.Drawing.Point(691, 26);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(92, 25);
            this.lblFilter.TabIndex = 117;
            this.lblFilter.Text = "Chức vụ";
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
            this.print.Location = new System.Drawing.Point(1530, 13);
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
            this.upload.Location = new System.Drawing.Point(1470, 13);
            this.upload.Margin = new System.Windows.Forms.Padding(5);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(50, 50);
            this.upload.TabIndex = 19;
            this.upload.Tag = "";
            this.upload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.search);
            this.pnlSearch.Controls.Add(this.inpSearch);
            this.pnlSearch.Location = new System.Drawing.Point(29, 13);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(50, 50);
            this.pnlSearch.TabIndex = 112;
            this.pnlSearch.MouseLeave += new System.EventHandler(this.pnlSearch_MouseLeave);
            this.pnlSearch.MouseHover += new System.EventHandler(this.search_MouseHover);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.RoyalBlue;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Dock = System.Windows.Forms.DockStyle.Right;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search.Location = new System.Drawing.Point(0, 0);
            this.search.Margin = new System.Windows.Forms.Padding(5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(50, 50);
            this.search.TabIndex = 22;
            this.search.Tag = "";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.UseVisualStyleBackColor = false;
            this.search.MouseHover += new System.EventHandler(this.search_MouseHover);
            // 
            // inpSearch
            // 
            this.inpSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpSearch.Location = new System.Drawing.Point(8, 14);
            this.inpSearch.Margin = new System.Windows.Forms.Padding(0);
            this.inpSearch.Name = "inpSearch";
            this.inpSearch.Size = new System.Drawing.Size(237, 23);
            this.inpSearch.TabIndex = 21;
            this.inpSearch.Enter += new System.EventHandler(this.search_MouseHover);
            this.inpSearch.Leave += new System.EventHandler(this.pnlSearch_MouseLeave);
            this.inpSearch.MouseHover += new System.EventHandler(this.search_MouseHover);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.Role,
            this.Account,
            this.StartDate,
            this.ResignationDate,
            this.selectDelete});
            this.table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Location = new System.Drawing.Point(0, 444);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 24;
            this.table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.table.Size = new System.Drawing.Size(1600, 450);
            this.table.TabIndex = 1;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nickname
            // 
            this.Nickname.HeaderText = "Tên Hiển Thị";
            this.Nickname.MaxInputLength = 16;
            this.Nickname.Name = "Nickname";
            this.Nickname.ReadOnly = true;
            // 
            // CitizenId
            // 
            this.CitizenId.HeaderText = "CMND /CCCD";
            this.CitizenId.MaxInputLength = 12;
            this.CitizenId.Name = "CitizenId";
            this.CitizenId.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ Và Tên";
            this.FullName.MaxInputLength = 50;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Ngày Sinh";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // GenderIsMale
            // 
            this.GenderIsMale.HeaderText = "Giới Tính";
            this.GenderIsMale.Name = "GenderIsMale";
            this.GenderIsMale.ReadOnly = true;
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Bằng Cấp";
            this.Qualification.MaxInputLength = 50;
            this.Qualification.Name = "Qualification";
            this.Qualification.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "SĐT";
            this.ContactNumber.MaxInputLength = 12;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.MaxInputLength = 100;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.HeaderText = "Chức Vụ";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Account
            // 
            this.Account.HeaderText = "Tài Khoản";
            this.Account.MaxInputLength = 16;
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Bắt Đầu";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // ResignationDate
            // 
            this.ResignationDate.HeaderText = "Nghỉ Việc";
            this.ResignationDate.Name = "ResignationDate";
            this.ResignationDate.ReadOnly = true;
            // 
            // selectDelete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            this.selectDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.selectDelete.HeaderText = "Xóa";
            this.selectDelete.Name = "selectDelete";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 50);
            this.panel1.TabIndex = 1;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Image = global::GUI.Properties.Resources.refresh;
            this.refresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.refresh.Location = new System.Drawing.Point(1500, 0);
            this.refresh.Margin = new System.Windows.Forms.Padding(5);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(50, 50);
            this.refresh.TabIndex = 111;
            this.refresh.Tag = "";
            this.refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Image = global::GUI.Properties.Resources.trash;
            this.delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.delete.Location = new System.Drawing.Point(1550, 0);
            this.delete.Margin = new System.Windows.Forms.Padding(5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(50, 50);
            this.delete.TabIndex = 112;
            this.delete.Tag = "";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // form
            // 
            this.form.Controls.Add(this.inpTitle);
            this.form.Controls.Add(this.lblTitle);
            this.form.Controls.Add(this.inpGenderFemale);
            this.form.Controls.Add(this.save);
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
            this.form.Controls.Add(this.update);
            this.form.Controls.Add(this.create);
            this.form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.Location = new System.Drawing.Point(0, 77);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(1600, 317);
            this.form.TabIndex = 2;
            // 
            // inpTitle
            // 
            this.inpTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inpTitle.FormattingEnabled = true;
            this.inpTitle.Items.AddRange(new object[] {
            "",
            "Bán hàng",
            "Quản kho",
            "Kế toán"});
            this.inpTitle.Location = new System.Drawing.Point(1307, 271);
            this.inpTitle.Name = "inpTitle";
            this.inpTitle.Size = new System.Drawing.Size(250, 33);
            this.inpTitle.TabIndex = 107;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(1144, 275);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 25);
            this.lblTitle.TabIndex = 114;
            this.lblTitle.Text = "Chức vụ";
            // 
            // inpGenderFemale
            // 
            this.inpGenderFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpGenderFemale.AutoSize = true;
            this.inpGenderFemale.Location = new System.Drawing.Point(1421, 110);
            this.inpGenderFemale.Name = "inpGenderFemale";
            this.inpGenderFemale.Size = new System.Drawing.Size(55, 29);
            this.inpGenderFemale.TabIndex = 99;
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
            this.save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.save.Location = new System.Drawing.Point(831, 236);
            this.save.Margin = new System.Windows.Forms.Padding(5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(50, 50);
            this.save.TabIndex = 110;
            this.save.Tag = "";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // inpGenderMale
            // 
            this.inpGenderMale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpGenderMale.AutoSize = true;
            this.inpGenderMale.Location = new System.Drawing.Point(1307, 110);
            this.inpGenderMale.Name = "inpGenderMale";
            this.inpGenderMale.Size = new System.Drawing.Size(71, 29);
            this.inpGenderMale.TabIndex = 98;
            this.inpGenderMale.TabStop = true;
            this.inpGenderMale.Text = "Nam";
            this.inpGenderMale.UseVisualStyleBackColor = true;
            // 
            // inpBirthday
            // 
            this.inpBirthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpBirthday.CustomFormat = "dd-MM-yyyy";
            this.inpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inpBirthday.Location = new System.Drawing.Point(722, 109);
            this.inpBirthday.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpBirthday.Name = "inpBirthday";
            this.inpBirthday.Size = new System.Drawing.Size(250, 30);
            this.inpBirthday.TabIndex = 97;
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
            this.btnAccount.Location = new System.Drawing.Point(48, 273);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(5);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(242, 50);
            this.btnAccount.TabIndex = 106;
            this.btnAccount.Tag = "";
            this.btnAccount.Text = "Cấp tài khoản";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // inpResignationDate
            // 
            this.inpResignationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpResignationDate.CustomFormat = "dd-MM-yyyy";
            this.inpResignationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inpResignationDate.Location = new System.Drawing.Point(1307, 218);
            this.inpResignationDate.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpResignationDate.Name = "inpResignationDate";
            this.inpResignationDate.Size = new System.Drawing.Size(250, 30);
            this.inpResignationDate.TabIndex = 105;
            // 
            // inpStartDate
            // 
            this.inpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpStartDate.CustomFormat = "dd-MM-yyyy";
            this.inpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inpStartDate.Location = new System.Drawing.Point(722, 218);
            this.inpStartDate.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpStartDate.Name = "inpStartDate";
            this.inpStartDate.Size = new System.Drawing.Size(250, 30);
            this.inpStartDate.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(1144, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 106;
            this.label1.Text = "Nghỉ việc";
            // 
            // inpAddress
            // 
            this.inpAddress.AcceptsReturn = true;
            this.inpAddress.AcceptsTab = true;
            this.inpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpAddress.Location = new System.Drawing.Point(1307, 164);
            this.inpAddress.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpAddress.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpAddress.Name = "inpAddress";
            this.inpAddress.Size = new System.Drawing.Size(250, 30);
            this.inpAddress.TabIndex = 102;
            // 
            // inpCitizenId
            // 
            this.inpCitizenId.AcceptsReturn = true;
            this.inpCitizenId.AcceptsTab = true;
            this.inpCitizenId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpCitizenId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpCitizenId.Location = new System.Drawing.Point(1307, 52);
            this.inpCitizenId.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpCitizenId.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpCitizenId.Name = "inpCitizenId";
            this.inpCitizenId.Size = new System.Drawing.Size(250, 30);
            this.inpCitizenId.TabIndex = 95;
            // 
            // inpContactNumber
            // 
            this.inpContactNumber.AcceptsReturn = true;
            this.inpContactNumber.AcceptsTab = true;
            this.inpContactNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpContactNumber.Location = new System.Drawing.Point(722, 164);
            this.inpContactNumber.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpContactNumber.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpContactNumber.Name = "inpContactNumber";
            this.inpContactNumber.Size = new System.Drawing.Size(250, 30);
            this.inpContactNumber.TabIndex = 101;
            // 
            // inpNickname
            // 
            this.inpNickname.AcceptsReturn = true;
            this.inpNickname.AcceptsTab = true;
            this.inpNickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inpNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpNickname.Location = new System.Drawing.Point(722, 52);
            this.inpNickname.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpNickname.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpNickname.Name = "inpNickname";
            this.inpNickname.Size = new System.Drawing.Size(250, 30);
            this.inpNickname.TabIndex = 94;
            // 
            // inpAccount
            // 
            this.inpAccount.AcceptsReturn = true;
            this.inpAccount.AcceptsTab = true;
            this.inpAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpAccount.Location = new System.Drawing.Point(159, 218);
            this.inpAccount.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpAccount.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpAccount.Name = "inpAccount";
            this.inpAccount.Size = new System.Drawing.Size(250, 30);
            this.inpAccount.TabIndex = 103;
            // 
            // inpQualification
            // 
            this.inpQualification.AcceptsReturn = true;
            this.inpQualification.AcceptsTab = true;
            this.inpQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpQualification.Location = new System.Drawing.Point(159, 164);
            this.inpQualification.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpQualification.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpQualification.Name = "inpQualification";
            this.inpQualification.Size = new System.Drawing.Size(250, 30);
            this.inpQualification.TabIndex = 100;
            // 
            // inpFullName
            // 
            this.inpFullName.AcceptsReturn = true;
            this.inpFullName.AcceptsTab = true;
            this.inpFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpFullName.Location = new System.Drawing.Point(159, 109);
            this.inpFullName.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpFullName.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpFullName.Name = "inpFullName";
            this.inpFullName.Size = new System.Drawing.Size(250, 30);
            this.inpFullName.TabIndex = 96;
            // 
            // inpId
            // 
            this.inpId.AcceptsReturn = true;
            this.inpId.AcceptsTab = true;
            this.inpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inpId.Location = new System.Drawing.Point(159, 52);
            this.inpId.MaximumSize = new System.Drawing.Size(500, 30);
            this.inpId.MinimumSize = new System.Drawing.Size(100, 30);
            this.inpId.Name = "inpId";
            this.inpId.Size = new System.Drawing.Size(250, 30);
            this.inpId.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(1144, 167);
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
            this.label10.Location = new System.Drawing.Point(1144, 112);
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
            this.label9.Location = new System.Drawing.Point(1144, 55);
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
            this.label8.Location = new System.Drawing.Point(587, 221);
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
            this.label7.Location = new System.Drawing.Point(587, 167);
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
            this.label6.Location = new System.Drawing.Point(587, 112);
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
            this.label5.Location = new System.Drawing.Point(587, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 86;
            this.label5.Text = "Tên hiển thị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(43, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 85;
            this.label4.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(43, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 84;
            this.label3.Text = "Bằng cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(43, 112);
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
            this.lblId.Location = new System.Drawing.Point(43, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 25);
            this.lblId.TabIndex = 82;
            this.lblId.Text = "ID";
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.update.BackColor = System.Drawing.Color.RoyalBlue;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Image = global::GUI.Properties.Resources.compose;
            this.update.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.update.Location = new System.Drawing.Point(679, 236);
            this.update.Margin = new System.Windows.Forms.Padding(5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(50, 50);
            this.update.TabIndex = 109;
            this.update.Tag = "";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // create
            // 
            this.create.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.create.BackColor = System.Drawing.Color.RoyalBlue;
            this.create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.create.ForeColor = System.Drawing.Color.White;
            this.create.Image = ((System.Drawing.Image)(resources.GetObject("create.Image")));
            this.create.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.create.Location = new System.Drawing.Point(527, 236);
            this.create.Margin = new System.Windows.Forms.Padding(5);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(50, 50);
            this.create.TabIndex = 108;
            this.create.Tag = "";
            this.create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // FormStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1600, 894);
            this.ControlBox = false;
            this.Controls.Add(this.form);
            this.Controls.Add(this.panel1);
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
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private Button search;
        private TextBox inpSearch;
        private Button download;
        private Button print;
        private Button upload;
        private DataGridView table;
        private Button delete;
        private Button refresh;
        private Panel panel1;
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
        private DataGridViewCheckBoxColumn selectDelete;
        private Panel form;
        private RadioButton inpGenderFemale;
        private Button save;
        private RadioButton inpGenderMale;
        private DateTimePicker inpBirthday;
        private Button btnAccount;
        private DateTimePicker inpResignationDate;
        private DateTimePicker inpStartDate;
        private Label label1;
        private TextBox inpAddress;
        private TextBox inpCitizenId;
        private TextBox inpContactNumber;
        private TextBox inpNickname;
        private TextBox inpAccount;
        private TextBox inpQualification;
        private TextBox inpFullName;
        private TextBox inpId;
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
        private Button update;
        private Button create;
        private ComboBox inpTitle;
        private Label lblTitle;
        private Panel pnlSearch;
        private DataGridViewTextBoxColumn Role;
        private ComboBox comboBoxFilter;
        private Label lblFilter;
    }
}