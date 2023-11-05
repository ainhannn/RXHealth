using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, System.EventArgs e)
        {
            lblNickname.Text = LoginForm.username;
            inpNickname.Visible = false;
            lblNickname.Location = new Point((456 - lblNickname.Width) / 2, 566);
        }
    }
}
