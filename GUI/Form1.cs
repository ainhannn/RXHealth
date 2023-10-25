using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //thông báo lỗi chưa viết
            MessageBox.Show("");
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
                alphaBlendTextBox2.Text = "Mật khẩu";
        }

        private void alphaBlendTextBox2_Enter(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.Text == "Mật khẩu")
                alphaBlendTextBox2.Text = "";
        }
    }
}
