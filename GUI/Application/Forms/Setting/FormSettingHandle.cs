using BLL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSetting : Form
    {
        private void Reload()
        {
            vat.Text = Retreat.ToPercentage(Convert.ToDecimal(Retreat.GetSetting("vat")));
            rate.Text = Retreat.ToPercentage(Convert.ToDecimal(Retreat.GetSetting("rate")));
            price.Text = Retreat.GetSetting("price").ToString();
            point.Text = Retreat.GetSetting("point").ToString();
        }

        private void FormSetting_Load(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void save_Click(object sender, System.EventArgs e)
        {
            if (Retreat.IsPercentage(vat.Text))
                Retreat.Setting("vat", Retreat.Percentage(vat.Text));
            if (Retreat.IsPercentage(rate.Text))
                Retreat.Setting("rate", Retreat.Percentage(rate.Text));
            if (double.TryParse(price.Text, out var prc))
                Retreat.Setting("price", prc);
            if (int.TryParse(point.Text, out var p))
                Retreat.Setting("point", p);

            MessageBox.Show("Tải lại trang để kiểm tra thay đổi!");
            Reload();
        }
    }
}
