using System.Windows.Forms;

namespace GUI
{
    public partial class FormChangePwd : Form
    {
        private void submit_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn có xác nhận thay đổi mật khẩu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
