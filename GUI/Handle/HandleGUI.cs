using System.Drawing.Drawing2D;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI.Handle
{
    internal class HandleGUI
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void PaintButton(object sender)
        {
            int borderRadius = 75;

            Button button = (Button)sender;
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle rect = button.ClientRectangle;

            buttonPath.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90);
            buttonPath.AddArc(rect.Right - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90);
            buttonPath.AddArc(rect.Right - borderRadius, rect.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
            buttonPath.AddArc(rect.X, rect.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
            buttonPath.CloseAllFigures();

            button.Region = new Region(buttonPath);
        }

        public static void ChangeBtnToggle(TextBox inputPass, PictureBox btntoggle, Form f)
        {
            if (inputPass.PasswordChar == '●')
            {
                btntoggle.Image = Properties.Resources.hidden;
                inputPass.PasswordChar = '\0';
            }
            else
            {
                btntoggle.Image = Properties.Resources.view;
                inputPass.PasswordChar = '●';
            }
            inputPass.Focus();
            f.Focus();
        }
    }
}
