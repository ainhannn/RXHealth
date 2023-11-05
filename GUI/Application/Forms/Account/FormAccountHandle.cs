using System.Drawing;
using System;
using System.Windows.Forms;
using System.IO;

namespace GUI
{
    public partial class FormAccount : Form
    {
        //lưu path image avt cho DTO
        private void avatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    string destinationPath = Path.Combine(@"../../../images/", Path.GetFileName(selectedFilePath));
                    File.Copy(selectedFilePath, destinationPath);
                    avatar.Image = new Bitmap(destinationPath);
                }
            }
        }

        // Sửa tên hiển thị: nickname
        private void editNickname_Click(object sender, System.EventArgs e)
        {
            if (editNickname.Text == "      Chỉnh sửa")
            {
                inpNickname.Visible = true;
                inpNickname.Text = lblNickname.Text;
                lblNickname.Visible = false;
                editNickname.Text = "      Lưu";
            }
            else
            {
                inpNickname.Visible = false;
                lblNickname.Text = inpNickname.Text;
                lblNickname.Location = new Point((456 - lblNickname.Width) / 2, 566);
                lblNickname.Visible = true;
                editNickname.Text = "      Chỉnh sửa";
            }
        }

        // sửa infomation
        private void update_Click(object sender, System.EventArgs e)
        {

        }

        //lưu sửa đổi trên form
        private void save_Click(object sender, System.EventArgs e)
        {

        }

        // Đổi mật khẩu
        private void btnAccount_Click(object sender, System.EventArgs e)
        {
            new FormChangePwd().Show();
        }
    }
}
