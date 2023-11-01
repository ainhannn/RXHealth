using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        private void FormStaff_Activated(object sender, System.EventArgs e)
        {
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                textBox.Enabled = false;
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = false;
        }

        private void FormStaff_Resize(object sender, System.EventArgs e)
        {
            if (Width > 1150)
            {
                foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                    textBox.Width = 200;
                foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                    dateBox.Width = 200;
                if (Height > 850)
                {
                    table.Height = 400;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else if (Height > 730)
                {
                    table.Height = 250;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else
                {
                    form.Visible = false;
                    table.Dock = DockStyle.Fill;
                }
            }
            else if (Width > 930)
            {
                foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                    textBox.Width = 100;
                foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                    dateBox.Width = 100;
                if (Height > 850)
                {
                    table.Height = 400;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else if (Height > 730)
                {
                    table.Height = 250;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else
                {
                    form.Visible = false;
                    table.Dock = DockStyle.Fill;
                }
            }
            else
            {
                form.Visible = false;
                table.Dock = DockStyle.Fill;
            }
        }

        private void create_Click(object sender, System.EventArgs e)
        {
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                textBox.Enabled = true;
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = true;
        }

        private void update_Click(object sender, System.EventArgs e)
        {
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                textBox.Enabled = true;
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = true;
        }

        private void delete_Click(object sender, System.EventArgs e)
        {
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                textBox.Enabled = false;
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = false;
        }

        private void save_Click(object sender, System.EventArgs e)
        {
            foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                textBox.Enabled = false;
            foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                dateBox.Enabled = false;
        }
    }
}
