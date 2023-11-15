namespace GUI
{
    partial class FormCateProvi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCateProvi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.inpTitle = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.inpGenderFemale = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.inpGenderMale = new System.Windows.Forms.RadioButton();
            this.inpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnAccount = new System.Windows.Forms.Button();
            this.inpResignationDate = new System.Windows.Forms.DateTimePicker();
            this.upload = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.inpStartDate = new System.Windows.Forms.DateTimePicker();
            this.form = new System.Windows.Forms.Panel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.inpSearch = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.form.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 3;
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
            this.form.Size = new System.Drawing.Size(1600, 367);
            this.form.TabIndex = 6;
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
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 90;
            this.label9.Text = "SĐT";
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
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 86;
            this.label5.Text = "Tên";
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
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 84;
            this.label3.Text = "Công nợ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Địa chỉ";
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
            this.panel3.TabIndex = 4;
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
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.search);
            this.pnlSearch.Controls.Add(this.inpSearch);
            this.pnlSearch.Location = new System.Drawing.Point(29, 13);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(50, 50);
            this.pnlSearch.TabIndex = 112;
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
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.Id,
            this.Name,
            this.ContactNumber,
            this.Address,
            this.Debt,
            this.DateTimeCycle,
            this.selectDelete});
            this.table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Location = new System.Drawing.Point(0, 444);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 24;
            this.table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.table.Size = new System.Drawing.Size(1600, 450);
            this.table.TabIndex = 5;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "STT";
            this.Stt.Name = "Stt";
            this.Stt.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MaxInputLength = 16;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Tên";
            this.Name.MaxInputLength = 12;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "SĐT";
            this.ContactNumber.MaxInputLength = 50;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Debt
            // 
            this.Debt.HeaderText = "Công Nợ";
            this.Debt.Name = "Debt";
            this.Debt.ReadOnly = true;
            // 
            // DateTimeCycle
            // 
            this.DateTimeCycle.HeaderText = "Ngày Đáo Hạn";
            this.DateTimeCycle.MaxInputLength = 50;
            this.DateTimeCycle.Name = "DateTimeCycle";
            this.DateTimeCycle.ReadOnly = true;
            // 
            // selectDelete
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            this.selectDelete.DefaultCellStyle = dataGridViewCellStyle6;
            this.selectDelete.HeaderText = "Xóa";
            this.selectDelete.Name = "selectDelete";
            // 
            // FormCateProvi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1600, 894);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.form);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.table);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "FormCateProvi";
            this.panel1.ResumeLayout(false);
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox inpTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton inpGenderFemale;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RadioButton inpGenderMale;
        private System.Windows.Forms.DateTimePicker inpBirthday;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.DateTimePicker inpResignationDate;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DateTimePicker inpStartDate;
        private System.Windows.Forms.Panel form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inpAddress;
        private System.Windows.Forms.TextBox inpCitizenId;
        private System.Windows.Forms.TextBox inpContactNumber;
        private System.Windows.Forms.TextBox inpNickname;
        private System.Windows.Forms.TextBox inpAccount;
        private System.Windows.Forms.TextBox inpQualification;
        private System.Windows.Forms.TextBox inpFullName;
        private System.Windows.Forms.TextBox inpId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox inpSearch;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeCycle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectDelete;
    }
}