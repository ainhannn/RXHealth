using BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class FormStatistic : Form
    {
        private List<Color> colors = new List<Color> 
        { Color.Red, Color.Green, Color.Purple, Color.Gold, Color.Plum, Color.Orange };

        private void FormStatistic_Load(object sender, System.EventArgs e)
        {
            LoadSales();
            LoadTrends();
            LoadApproach();
            LoadCount();
            LoadTopSelling();
        }


        // Pie chart in 1st panel
        private void LoadSales() 
        {
            chart1.Series.Clear();
            Series pieSeries = new Series("PieSeries")
            { ChartType = SeriesChartType.Pie };

            var data = ProductBUS.CountSalesByCate();
            int i = 0;
            foreach (var item in data)
            {
                pieSeries.Points.AddY(item.Value);
                pieSeries.Points[i].AxisLabel = item.Key; 
                pieSeries.Points[i].Color = colors[i%colors.Count];
                i++;
            }

            chart1.Series.Add(pieSeries);
        }

        // Line chart in 2nd panel
        private void LoadTrends()
        {
            chart2.Series.Clear();
            string[] name = { "Doanh thu", "Lợi nhuận", "Tổng chi" };
            var data = new List<Dictionary<int, double>>
            {
                SaleBUS.MonthsRevenue(),

            };
            
            
            for (var i = 0; i < data.Count; i++)
            {
                Series line = new Series()
                {
                    ChartType = SeriesChartType.Line,
                    Color = colors[i],
                    XValueType = ChartValueType.Auto,
                    YValueType = ChartValueType.Double
                };

                line.Points.DataBindXY(data[i].Keys, data[i].Values);
                //foreach (var item in data[i])
                //    line.Points.AddXY(Convert.ToInt16(item.Key), item.Value);
                line.Points.AddXY(28, 100000);
                line.Points.AddXY(30, 70000);

                line.Points[i].Label = name[i];
                chart2.Series.Add(line);
            }
        }

        // Column chart in 3 panel
        private void LoadApproach()
        {
            Series columnSeries = new Series("ColumnSeries");
            columnSeries.ChartType = SeriesChartType.Column;

            var data = ProductBUS.CountSalesByCate();
            int i = 0;
            foreach (var item in data)
            {
                columnSeries.Points.AddY(item.Value);
                columnSeries.Points[i].AxisLabel = item.Key;
                columnSeries.Points[i].Color = colors[i % colors.Count];
                i++;
            }

            chart3.Series.Add(columnSeries);
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
    }
}
