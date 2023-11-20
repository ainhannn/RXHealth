using BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCateIngre : Form
    {
        private void FormCateIngre_Load(object sender, EventArgs e)
        {
            List<string> substance = SubstanceBUS.SelectAll();
            int i = 0;
            foreach (Control lbl in Controls)
                lbl.Text = substance[i++];
        }
    }
}
