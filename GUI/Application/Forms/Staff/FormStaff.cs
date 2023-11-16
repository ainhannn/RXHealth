using System;
using System.Linq;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace GUI
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        private void FormStaff_Activated(object sender, EventArgs e)
        {
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
                textBox.Enabled = false;
            }
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
            {
                dateBox.Enabled = false;
                dateBox.Value = DateTime.Now;
            }
            foreach (RadioButton genderBox in form.Controls.OfType<RadioButton>())
            {
                genderBox.Enabled = false;
                genderBox.Checked = false;
            }
            inpTitle.Enabled = false;
            inpTitle.SelectedIndex = 0;
        }

        private void comboFilterGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}