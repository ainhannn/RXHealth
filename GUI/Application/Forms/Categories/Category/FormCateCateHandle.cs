using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCateCate : Form
    {
        private void selectMenu(PictureBox btn, string str)
        {
            resetMenu();
            if (!panel1.Visible)
            {
                panel2.Dock = DockStyle.Bottom;
                panel1.Visible = true;
                panel3.Visible = true;
            }
            btn.SizeMode = PictureBoxSizeMode.Zoom;
            btn.Padding = new Padding(10, 10, 10, 10);
            btn.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Image = img.Image = btn.Image;
            title.Text = str;

            count.Text = "Lượt mua: " + ProductBUS.CountSalesByCate(str).ToString();
            Dictionary<string,int> rs = ProductBUS.GetBestSellingByCate(str, 3);
            var c = rs.Count;
            p1.Text = c >= 1 ? "1. " + rs.ElementAt(0).Key + " - " + rs.ElementAt(0).Value : "";
            p2.Text = c >= 2 ? "2. " + rs.ElementAt(1).Key + " - " + rs.ElementAt(1).Value : "";
            p3.Text = c >= 3 ? "3. " + rs.ElementAt(2).Key + " - " + rs.ElementAt(2).Value : "";
        }

        private void btnCate1_Click(object sender, System.EventArgs e) => selectMenu(btnCate1, "Thuốc kê đơn");
        private void btnCate2_Click(object sender, System.EventArgs e) => selectMenu(btnCate2, "Thuốc không kê đơn");
        private void btnCate3_Click(object sender, System.EventArgs e) => selectMenu(btnCate3, "Thực phẩm chức năng");
        private void btnCate4_Click(object sender, System.EventArgs e) => selectMenu(btnCate4, "Chăm sóc cá nhân");
        private void btnCate5_Click(object sender, System.EventArgs e) => selectMenu(btnCate5, "Dụng cụ y tế");
        private void btnCate6_Click(object sender, System.EventArgs e) => selectMenu(btnCate6, "Thiết bị y tế");
        private void btn_Click(object sender, System.EventArgs e) => Application.OpenForms.OfType<MainForm>().FirstOrDefault().cateDrug_Click(sender, e);
    }
}
