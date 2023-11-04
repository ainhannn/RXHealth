using System.Windows.Forms;

namespace GUI.Components
{
    internal class Navigate
    {
        private static Form form;

        public static void Form (Label formTitle, string title, Form f, Form frm, Form MainForm)
        {
            formTitle.Text = title;
            form = f;
            if (form == null)
            {
                form = frm;
                form.FormClosed += Form_FormClosed;
                form.MdiParent = MainForm;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private static void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            form = null;
        }
    }
}
