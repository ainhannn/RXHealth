using System.Drawing;
using System;
using System.Windows.Forms;
using System.IO;
using DTO;
using BLL;
using System.Linq;
using GLB;

namespace GUI
{
    public partial class FormAccount : Form
    {
        private void FormAccount_Load(object sender, EventArgs e)
        {
            string path = AccountBLL.getAvatarAccount(idUser);
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
                avatar.Image = new Bitmap(path);
            inpNickname.Text = lblNickname.Text = StaffBLL.getNickName(idUser);
            inpAccount.Text = AccountBLL.getUsernameAccount(idUser);
            Staff staff = StaffBLL.getStaff(idUser);
            inpFullName.Text = staff.FullName;
            if (staff.GenderIsMale == true)
            {
                inpGenderMale.Checked = true;
            }
            else
            {
                inpGenderFemale.Checked = true;
            }
            inpCitizenId.Text = staff.CitizenId;
            inpAddress.Text = staff.Address;
            inpContactNumber.Text = staff.ContactNumber;
            inpQualification.Text = staff.Qualification;
            inpTitle.SelectedItem = StaffBLL.getRole(staff.Id);
        }
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
                    if (!File.Exists(destinationPath))
                        File.Copy(selectedFilePath, destinationPath);
                    avatar.Image = new Bitmap(destinationPath);
                    AccountBLL.updateAvatar(idUser, destinationPath);
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
                if (inpNickname.Text == "" || inpNickname.Text == " ")
                {
                    MessageBox.Show("Vui lòng điền thông tin");
                    return;
                }
                try
                {
                    MessageBox.Show(StaffBLL.ChangeNickname(idUser, inpNickname.Text));
                    Application.OpenForms.OfType<MainForm>().FirstOrDefault().username.Text = StaffBLL.getNickName(idUser);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

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
            inpAccount.Enabled = true;
            save.Visible = true;
        }

        //lưu sửa đổi trên form
        private void save_Click(object sender, System.EventArgs e)
        {
            if (inpAccount.Text.Length < 6 || HandleGlobal.checkIsEnglish(inpAccount.Text) == false)
            {
                MessageBox.Show("Vui lòng kiểm tra lại Tên đăng nhập ( A-Z,a-z,0-9,_ ) và >= 6 kí tự");
                return;
            }
            if (AccountBLL.updateUsername(idUser, inpAccount.Text))
            {
                MessageBox.Show("Cập nhật tên đăng nhập thành công");
                save.Visible = false;
                inpAccount.Enabled = false;
            }
            else
            {
                MessageBox.Show("Cập nhật tên đăng nhập thất bại, có thể nó đã tồn tại");
            }
        }

        // Đổi mật khẩu
        private void btnAccount_Click(object sender, System.EventArgs e)
        {
            new FormChangePwdHandle(idUser).ShowDialog();
        }
    }
}
