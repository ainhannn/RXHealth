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
        private CateProduct pd = new CateProduct();
        private string currentPath = "";

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
                inpCode.ReadOnly = impPrice.ReadOnly = true;
                image.Enabled = is_stopped.Enabled = category.Enabled = true;
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
                image.Enabled = is_stopped.Enabled = category.Enabled = false;
                description.ReadOnly = true;
                description.BackColor = Color.SteelBlue;
                description.ForeColor = Color.White;
                description.Cursor = Cursors.Default;
            }
        }

        private void FormPDetails_Load(object sender, EventArgs e)
        {
            if (pd != null) // Read Update
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
                if (!string.IsNullOrEmpty(pd.Image))
                {
                    try { image.Image = Image.FromFile(pd.Image); }
                    catch { }
                }
            }
            else // Create
            {
                pd = new CateProduct();
                foreach (TextBox inp in Controls.OfType<TextBox>())
                    inp.Text = string.Empty;
                
                Changable(true); 
                edit.Visible = is_stopped.Visible = false;
                inpCode.ReadOnly = impPrice.ReadOnly = false;
            }
        }

        private void image_Click(object sender, System.EventArgs e)
        {
            string path = HandleGUI.ImageChange();
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                image.Image = new Bitmap(path);
                currentPath = path;
            }
        }

        private void edit_Click(object sender, System.EventArgs e)
        {
            Changable(true);
        }

        private void save_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(inpCode.Text) ||
                string.IsNullOrEmpty(name.Text) ||
                string.IsNullOrEmpty(category.Text) ||
                string.IsNullOrEmpty(rUnit.Text))
            {
                MessageBox.Show("Nhập đủ thông tin bắt buộc!");
                return;
            }


            double iPrc, sPrc, rPrc;
            iPrc = sPrc = rPrc = -1;
            if ((!double.TryParse(impPrice.Text, out rPrc) && !string.IsNullOrEmpty(impPrice.Text)) ||
                (!double.TryParse(price.Text, out rPrc) && !string.IsNullOrEmpty(price.Text)) ||
                (!double.TryParse(rPrice.Text, out rPrc) && !string.IsNullOrEmpty(rPrice.Text)))
            {
                MessageBox.Show("Sai định dạng tiền tệ!");
                return;
            }
            
            pd.Stack = stack.Text;
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
            pd.Image = !string.IsNullOrEmpty(currentPath) ? currentPath : pd.Image;
            pd.IsOnSale = !is_stopped.Checked;

            if (inpCode.ReadOnly)
            {
                switch (ProductBUS.Update(pd))
                {
                    case 1:
                        Changable(false);
                        MessageBox.Show("Cập nhật thành công!");
                        //cap nhat lai parent table
                        for (int i = 0; i < FormCateDrug.list.Count; i++)
                        {
                            if (FormCateDrug.list[i].Id == pd.Id)
                            {
                                FormCateDrug.list[i] = pd;
                                break;
                            }
                        }
                        break;

                    case 0:
                        MessageBox.Show("Không thể nhập trùng thông tin!");
                        break;

                    default:
                        MessageBox.Show("Đã có lỗi xảy ra. Cập nhật thất bại!");
                        break;
                }
            }
            else
            {
                pd.Barcode = inpCode.Text;

                switch (ProductBUS.Insert(pd))
                {
                    case 1:
                        Changable(false);
                        MessageBox.Show("Thêm thành công!");
                        //cap nhat lai parent table
                        pd.Id = ProductBUS.GetId(pd.Barcode);
                        FormCateDrug.list.Add(pd);
                        break;

                    case 0:
                        MessageBox.Show("Mã vạch đã tồn tại!");
                        break;

                    default:
                        MessageBox.Show("Đã có lỗi xảy ra. Thêm thất bại!");
                        break;
                }
            }
        }
    }
}
