using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormStatistic : Form
    {
        private void LoadSales()
        {
            //code here
        }

        private void LoadTrends()
        {

        }

        private void LoadApproach()
        {

        }

        private void LoadCount()
        {
            countCus.Text = CustomerBUS.Count.ToString();
            countProvi.Text = SupplierBUS.Count.ToString();
            countPd.Text = ProductBUS.Count.ToString();
        }

        private void LoadTopSelling() 
        {
            Dictionary<string, int> rs = ProductBUS.GetBestSelling(5);
            var c = rs.Count;
            sp1.Text = c >= 1 ? "1. " + rs.ElementAt(0).Key + " - " + rs.ElementAt(0).Value : "";
            sp2.Text = c >= 2 ? "2. " + rs.ElementAt(1).Key + " - " + rs.ElementAt(1).Value : "";
            sp3.Text = c >= 3 ? "3. " + rs.ElementAt(2).Key + " - " + rs.ElementAt(2).Value : "";
            sp4.Text = c >= 4 ? "4. " + rs.ElementAt(3).Key + " - " + rs.ElementAt(3).Value : "";
            sp5.Text = c >= 5 ? "5. " + rs.ElementAt(4).Key + " - " + rs.ElementAt(4).Value : "";
        }

        private void FormStatistic_Load(object sender, System.EventArgs e)
        {
            LoadSales();
            LoadTrends();
            LoadApproach();
            LoadCount();
            LoadTopSelling();
        }
    }
}
