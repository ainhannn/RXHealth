using BLL;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class FormStatistic : Form
    {
        private Chart chart1;
        private Chart chart2;
        private Chart chart3;

        public FormStatistic()
        {
            InitializeComponent();
            InitializeCharts();
        }

        private void InitializeCharts()
        {
            chart1 = CreateChart();
            pnl1.Controls.Add(chart1);

            chart2 = CreateChart();
            pnl2.Controls.Add(chart2);

            chart3 = CreateChart();
            pnl3.Controls.Add(chart3);
        }

        private Chart CreateChart()
        {
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;
            chart.ChartAreas.Add(new ChartArea("Default"));
            return chart;
        }

        private void invoices_Click(object sender, System.EventArgs e)
        {
            new FormInvoice().ShowDialog();
        }
    }
}
