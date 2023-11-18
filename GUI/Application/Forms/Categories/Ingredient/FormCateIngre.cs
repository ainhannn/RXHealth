using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCateIngre : Form
    {
        public FormCateIngre()
        {
            InitializeComponent();
        }

        private void FormCateIngre_Load(object sender, EventArgs e)
        {
            foreach (Control lbl in Controls)
                lbl.Text = "Ái Nhân"; //bỏ list dô
        }
    }
}
