using GUI.Handle;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPDetails : Form
    {
        private void image_Click(object sender, System.EventArgs e)
        {
            string path = HandleGUI.ImageChange();
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                image.Image = new Bitmap(path);
                //viết lưu path
            }
        }

        private void edit_Click(object sender, System.EventArgs e)
        {
            save.Visible = true;
            foreach (TextBox inp in Controls.OfType<TextBox>())
            {
                inp.ReadOnly = false;
                inp.BackColor = Color.White;
                inp.ForeColor = Color.Black;
                inp.Cursor = Cursors.IBeam;
            }
            image.Enabled = is_on_sale.Enabled = description.Enabled = category.Enabled = true;
            description.ReadOnly = false;
            description.BackColor = Color.White;
            description.ForeColor = Color.Black;
            description.Cursor = Cursors.IBeam;
            //sửa CSDL
        }

        private void save_Click(object sender, System.EventArgs e)
        {
            //lưu thành công
            save.Visible = false;
            foreach (TextBox inp in Controls.OfType<TextBox>())
            {
                inp.ReadOnly = true;
                inp.BackColor = Color.SteelBlue;
                inp.ForeColor = Color.White;
                inp.Cursor = Cursors.Default;
            }
            image.Enabled = is_on_sale.Enabled = description.Enabled = category.Enabled = false;
            description.ReadOnly = true;
            description.BackColor = Color.SteelBlue;
            description.ForeColor = Color.White;
            description.Cursor = Cursors.Default;
        }
    }
}
