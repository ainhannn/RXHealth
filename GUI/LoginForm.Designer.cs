namespace GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btntoggle = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.Button();
            this.forgot = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pwdicon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputPass = new ZBobb.AlphaBlendTextBox();
            this.usericon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputName = new ZBobb.AlphaBlendTextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btntoggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usericon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btntoggle);
            this.bunifuGradientPanel1.Controls.Add(this.exit);
            this.bunifuGradientPanel1.Controls.Add(this.login);
            this.bunifuGradientPanel1.Controls.Add(this.forgot);
            this.bunifuGradientPanel1.Controls.Add(this.title);
            this.bunifuGradientPanel1.Controls.Add(this.logo);
            this.bunifuGradientPanel1.Controls.Add(this.pwdicon);
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.inputPass);
            this.bunifuGradientPanel1.Controls.Add(this.usericon);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.inputName);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.BlueViolet;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(500, 700);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btntoggle
            // 
            this.btntoggle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btntoggle.BackColor = System.Drawing.Color.Transparent;
            this.btntoggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntoggle.Image = global::GUI.Properties.Resources.view;
            this.btntoggle.Location = new System.Drawing.Point(417, 401);
            this.btntoggle.Name = "btntoggle";
            this.btntoggle.Size = new System.Drawing.Size(28, 34);
            this.btntoggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btntoggle.TabIndex = 13;
            this.btntoggle.TabStop = false;
            this.btntoggle.Click += new System.EventHandler(this.btntoggle_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = global::GUI.Properties.Resources.reject;
            this.exit.Location = new System.Drawing.Point(446, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(42, 37);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 12;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login.BackColor = System.Drawing.Color.Orchid;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumVioletRed;
            this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(130, 534);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(240, 75);
            this.login.TabIndex = 11;
            this.login.Text = "Đăng nhập";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            this.login.Paint += new System.Windows.Forms.PaintEventHandler(this.login_Paint);
            // 
            // forgot
            // 
            this.forgot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.forgot.AutoSize = true;
            this.forgot.BackColor = System.Drawing.Color.Transparent;
            this.forgot.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot.ForeColor = System.Drawing.Color.White;
            this.forgot.Location = new System.Drawing.Point(328, 460);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(150, 22);
            this.forgot.TabIndex = 10;
            this.forgot.Text = "Quên mật khẩu?";
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Cascadia Code", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(125, 194);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(250, 57);
            this.title.TabIndex = 8;
            this.title.Text = "ĐĂNG NHẬP";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::GUI.Properties.Resources.RXlogo;
            this.logo.Location = new System.Drawing.Point(170, 32);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(160, 160);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // pwdicon
            // 
            this.pwdicon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwdicon.BackColor = System.Drawing.Color.Transparent;
            this.pwdicon.Image = global::GUI.Properties.Resources.padlock;
            this.pwdicon.Location = new System.Drawing.Point(59, 401);
            this.pwdicon.Name = "pwdicon";
            this.pwdicon.Size = new System.Drawing.Size(28, 34);
            this.pwdicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pwdicon.TabIndex = 6;
            this.pwdicon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(59, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 3);
            this.panel2.TabIndex = 5;
            // 
            // inputPass
            // 
            this.inputPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPass.BackAlpha = 0;
            this.inputPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.inputPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPass.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPass.ForeColor = System.Drawing.Color.White;
            this.inputPass.Location = new System.Drawing.Point(93, 407);
            this.inputPass.Multiline = true;
            this.inputPass.Name = "inputPass";
            this.inputPass.Size = new System.Drawing.Size(351, 47);
            this.inputPass.TabIndex = 4;
            this.inputPass.Text = "Mật khẩu";
            this.inputPass.TextChanged += new System.EventHandler(this.input_Onchange);
            this.inputPass.Enter += new System.EventHandler(this.password_Enter);
            this.inputPass.Leave += new System.EventHandler(this.password_Leave);
            // 
            // usericon
            // 
            this.usericon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usericon.BackColor = System.Drawing.Color.Transparent;
            this.usericon.Image = global::GUI.Properties.Resources.user;
            this.usericon.Location = new System.Drawing.Point(60, 282);
            this.usericon.Name = "usericon";
            this.usericon.Size = new System.Drawing.Size(28, 34);
            this.usericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usericon.TabIndex = 3;
            this.usericon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(60, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 3);
            this.panel1.TabIndex = 2;
            // 
            // inputName
            // 
            this.inputName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputName.BackAlpha = 0;
            this.inputName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputName.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputName.ForeColor = System.Drawing.Color.White;
            this.inputName.Location = new System.Drawing.Point(94, 288);
            this.inputName.Multiline = true;
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(351, 47);
            this.inputName.TabIndex = 1;
            this.inputName.Text = "Tên đăng nhập";
            this.inputName.TextChanged += new System.EventHandler(this.input_Onchange);
            this.inputName.Enter += new System.EventHandler(this.username_Enter);
            this.inputName.Leave += new System.EventHandler(this.username_Leave);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btntoggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usericon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ZBobb.AlphaBlendTextBox inputName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox usericon;
        private System.Windows.Forms.PictureBox pwdicon;
        private System.Windows.Forms.Panel panel2;
        private ZBobb.AlphaBlendTextBox inputPass;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label forgot;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox btntoggle;
    }
}

