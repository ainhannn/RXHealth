using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormAccount : Form
    {
        private int idUser;
        public FormAccount(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }
        //private void FormAccount_Load(object sender, System.EventArgs e)
        //{
        //    lblNickname.Text = LoginForm.username;
        //    inpNickname.Visible = false;
        //    lblNickname.Location = new Point((456 - lblNickname.Width) / 2, 566);
        //}
    }
}
