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

            // viết tiếp ở đây
            count.Text = "Lượt mua: " + str;
            p1.Text = "1." + str;
            p2.Text = "2." + str;
            p3.Text = "3." + str;
        }

        private void btnCate1_Click(object sender, System.EventArgs e) => selectMenu(btnCate1, "Thuốc kê đơn");
        private void btnCate2_Click(object sender, System.EventArgs e) => selectMenu(btnCate2, "Thuốc không kê đơn");
        private void btnCate3_Click(object sender, System.EventArgs e) => selectMenu(btnCate3, "Thực phẩm chức năng");
        private void btnCate4_Click(object sender, System.EventArgs e) => selectMenu(btnCate4, "Chăm sóc cá nhân");
        private void btnCate5_Click(object sender, System.EventArgs e) => selectMenu(btnCate5, "Dụng cụ y tế");
        private void btnCate6_Click(object sender, System.EventArgs e) => selectMenu(btnCate6, "Thiết bị y tế");
        private void btn_Click(object sender, System.EventArgs e) => Application.OpenForms.OfType<MainForm>().FirstOrDefault().cateDrug_Click(sender, e);
    }
}
