using GUI.Handle;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormChangePwdHandle : Form
    {
        private int idUser;
        public FormChangePwdHandle(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            HandleGUI.ReleaseCapture();
            HandleGUI.SendMessage(this.Handle, 0x112, 0xf012, 8);
        }

        private void exit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FormChangePwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.Enter)
                submit.PerformClick();
        }
    }
}
