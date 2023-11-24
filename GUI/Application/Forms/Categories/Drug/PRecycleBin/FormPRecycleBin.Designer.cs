namespace GUI
{
    partial class FormPRecycleBin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPRecycleBin));
            this.title = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.restore = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(256, 42);
            this.title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(209, 46);
            this.title.TabIndex = 66;
            this.title.Text = "THÙNG RÁC";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPRecycleBin_MouseDown);
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
            this.exit.Location = new System.Drawing.Point(669, 15);
            this.exit.Margin = new System.Windows.Forms.Padding(6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 38);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 67;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.table);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(28, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 584);
            this.panel2.TabIndex = 68;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.code,
            this.name,
            this.choose});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 50);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(665, 534);
            this.table.TabIndex = 49;
            // 
            // id
            // 
            this.id.HeaderText = "STT";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // code
            // 
            this.code.HeaderText = "Mã sản phẩm";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Tên sản phẩm";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // choose
            // 
            this.choose.HeaderText = "Chọn";
            this.choose.Name = "choose";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.restore);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 50);
            this.panel1.TabIndex = 47;
            // 
            // restore
            // 
            this.restore.BackColor = System.Drawing.Color.Transparent;
            this.restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restore.Dock = System.Windows.Forms.DockStyle.Right;
            this.restore.FlatAppearance.BorderSize = 0;
            this.restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restore.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.restore.ForeColor = System.Drawing.Color.White;
            this.restore.Image = global::GUI.Properties.Resources.refresh;
            this.restore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.restore.Location = new System.Drawing.Point(565, 0);
            this.restore.Margin = new System.Windows.Forms.Padding(5);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(50, 50);
            this.restore.TabIndex = 111;
            this.restore.Tag = "";
            this.restore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restore.UseVisualStyleBackColor = false;
            this.restore.Click += new System.EventHandler(this.restore_Click);
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
            this.delete.Location = new System.Drawing.Point(615, 0);
            this.delete.Margin = new System.Windows.Forms.Padding(5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(50, 50);
            this.delete.TabIndex = 112;
            this.delete.Tag = "";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // FormPRecycleBin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.exit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPRecycleBin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPRecycleBin";
            this.Load += new System.EventHandler(this.FormPRecycleBin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPRecycleBin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button restore;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn choose;
    }
}