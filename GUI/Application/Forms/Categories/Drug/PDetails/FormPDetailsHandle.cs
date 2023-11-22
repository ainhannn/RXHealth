using BLL;
using DTO;
using GUI.Handle;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPDetails : Form
    {
        private CateProduct pd = null;

        private void Changable(bool input)
        {
            if (input)
            {
                save.Visible = true;
                foreach (TextBox inp in Controls.OfType<TextBox>())
                {
                    inp.ReadOnly = false;
                    inp.BackColor = Color.White;
                    inp.ForeColor = Color.Black;
                    inp.Cursor = Cursors.IBeam;
                }
                stack.Enabled = name.Enabled = image.Enabled = is_stopped.Enabled = description.Enabled = category.Enabled = true;
                description.ReadOnly = false;
                description.BackColor = Color.White;
                description.ForeColor = Color.Black;
                description.Cursor = Cursors.IBeam;
            } 
            else
            {
                save.Visible = false;
                foreach (TextBox inp in Controls.OfType<TextBox>())
                {
                    inp.ReadOnly = true;
                    inp.BackColor = Color.SteelBlue;
                    inp.ForeColor = Color.White;
                    inp.Cursor = Cursors.Default;
                }
                stack.Enabled = name.Enabled = image.Enabled = is_stopped.Enabled = description.Enabled = category.Enabled = false;
                description.ReadOnly = true;
                description.BackColor = Color.SteelBlue;
                description.ForeColor = Color.White;
                description.Cursor = Cursors.Default;
            }
        }

        private void FormPDetails_Load(object sender, EventArgs e)
        {
            if (pd != null)
            {
                stack.Text = pd.Stack;
                inpCode.Text = pd.Barcode;
                name.Text = pd.Name;
                category.Text = pd.Category.Name;
                unit.Text = pd.Unit;
                rUnit.Text = pd.RetailUnit;
                impPrice.Text = pd.CurrentImportPrice.ToString();
                price.Text = pd.Saleprice.ToString();
                rPrice.Text = pd.RetailSaleprice.ToString();
                description.Text = pd.ExtraInformation;
                is_stopped.Checked = !pd.IsOnSale;
                //image = ??
            }
        }

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
            Changable(true);
        }

        private void save_Click(object sender, System.EventArgs e)
        {
            double iPrc, sPrc, rPrc;
            iPrc = sPrc = rPrc = -1;
            if (!double.TryParse(impPrice.Text, out iPrc) ||
                !double.TryParse(price.Text, out sPrc) ||
                !double.TryParse(rPrice.Text, out rPrc))
            {
                MessageBox.Show("Sai định dạng tiền tệ!");
                return;
            }

            pd.Stack = stack.Text;
            pd.Barcode = inpCode.Text;
            pd.Name = name.Text;
            switch (category.Text)
            {
                case "Thuốc kê đơn":
                    pd.Category.Id = 1;
                    break;
                case "Thuốc không kê đơn":
                    pd.Category.Id = 2;
                    break;
                case "Thực phẩm chức năng":
                    pd.Category.Id = 3;
                    break;
                case "Chăm sóc cá nhân":
                    pd.Category.Id = 4;
                    break;
                case "Dụng cụ y tế":
                    pd.Category.Id = 5;
                    break;
                case "Thiết bị y tế":
                    pd.Category.Id = 6;
                    break;
                default:
                    break;
            }
            pd.Unit = unit.Text;
            pd.RetailUnit = rUnit.Text;
            pd.CurrentImportPrice = iPrc != -1 ? iPrc : pd.CurrentImportPrice;
            pd.Saleprice = sPrc != -1 ? sPrc : pd.Saleprice;
            pd.RetailSaleprice = rPrc != -1 ? rPrc : pd.RetailSaleprice;
            pd.ExtraInformation = description.Text;
            //pd.Image = ??;
            pd.IsOnSale = !is_stopped.Checked;

            if (ProductBUS.Update(pd))
            {
                Changable(false);
                MessageBox.Show("Cập nhật thành công!");
            }
            else
                MessageBox.Show("Cập nhật thất bại!");
        }
    }
}
