using System.Drawing;
using System;
using System.Windows.Forms;
using System.IO;

namespace GUI
{
    public partial class FormAccount : Form
    {
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

        private void editNickname_Click(object sender, System.EventArgs e)
        {
            if (editNickname.Text == "      Chỉnh sửa")
            {
                inpNickname.Visible = true;
                editNickname.Text = "      Lưu";
            }
            else
            {
                inpNickname.Visible = false;
                lblNickname.Text = inpNickname.Text;
                editNickname.Text = "      Chỉnh sửa";
            }
        }
    }
}
