using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "Tên đăng nhập")
                if(alphaBlendTextBox2.Text == "Mật khẩu")
                    MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(alphaBlendTextBox2.Text == "Mật khẩu")
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Thực hiện xác thực và đăng nhập
                // Nếu thành công, chuyển đến giao diện chính
                // Ví dụ: MainForm mainForm = new MainForm();
                // mainForm.Show();
                // this.Close();
                // không thành công báo message lỗi
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. Bạn có muốn thử lại?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alphaBlendTextBox1_Leave(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "")
                alphaBlendTextBox1.Text = "Tên đăng nhập";
        }

        private void alphaBlendTextBox1_Enter(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "Tên đăng nhập")
                alphaBlendTextBox1.Text = "";
        }

        private void alphaBlendTextBox2_Leave(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.Text == "")
            {
                alphaBlendTextBox2.Text = "Mật khẩu";
                alphaBlendTextBox2.PasswordChar = '\0';
            }
        }

        private void alphaBlendTextBox2_Enter(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.Text == "Mật khẩu")
            {
                alphaBlendTextBox2.Text = "";
                alphaBlendTextBox2.PasswordChar = '●';
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.PasswordChar == '●')
            {
                pictureBox5.Image = Properties.Resources.hidden;
                alphaBlendTextBox2.PasswordChar = '\0';
            }
            else
            {
                pictureBox5.Image = Properties.Resources.view;
                alphaBlendTextBox2.PasswordChar = '●';
            }
            this.Focus();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 70;

            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle rect = button.ClientRectangle;

            buttonPath.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90);
            buttonPath.AddArc(rect.Right - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90);
            buttonPath.AddArc(rect.Right - borderRadius, rect.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
            buttonPath.AddArc(rect.X, rect.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
            buttonPath.CloseAllFigures();

            button.Region = new Region(buttonPath);
        }
    }
}
