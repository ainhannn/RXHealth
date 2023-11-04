using System.Linq;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormStaff : Form
    {
        private void FormStaff_Resize(object sender, EventArgs e)
        {
            if (Width > 1300)
            {
                foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                    textBox.Width = 250;
                foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                    dateBox.Width = 250;
                inpTitle.Width = 250;
                if (Height > 910)
                {
                    table.Height = 450;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else if (Height > 820)
                {
                    table.Height = 350;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else if (Height > 770)
                {
                    table.Height = 300;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else
                {
                    form.Visible = false;
                    table.Dock = DockStyle.Fill;
                }
            }
            else if (Width > 1200)
            {
                lblFilter.Visible = true;
                comboBoxFilter.Visible = true;
                foreach (TextBox textBox in form.Controls.OfType<TextBox>())
                    textBox.Width = 200;
                foreach (DateTimePicker dateBox in form.Controls.OfType<DateTimePicker>())
                    dateBox.Width = 200;
                inpTitle.Width = 200;
                if (Height > 910)
                {
                    table.Height = 450;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else if (Height > 820)
                {
                    table.Height = 350;
                    form.Visible = true;
                    table.Dock = DockStyle.Bottom;
                }
                else if (Height > 770)
                {
                    table.Height = 300;
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
                lblFilter.Visible = false;
                comboBoxFilter.Visible = false;
                form.Visible = false;
                table.Dock = DockStyle.Fill;
            }
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            pnlSearch.Width = 300;
        }

        private void pnlSearch_MouseLeave(object sender, EventArgs e)
        {
            if (inpSearch.Text == "" && !inpSearch.Focused)
                pnlSearch.Width = 50;
        }
    }
}
