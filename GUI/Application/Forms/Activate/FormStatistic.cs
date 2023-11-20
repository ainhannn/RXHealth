
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
            Series pieSeries = new Series("PieSeries");
            pieSeries.ChartType = SeriesChartType.Pie;
            pieSeries.Points.AddY(25);
            pieSeries.Points.AddY(75);
            pieSeries.Points[0].Color = Color.Red;
            pieSeries.Points[1].Color = Color.Green;
            chart1.Series.Add(pieSeries);
            pnl1.Controls.Add(chart1);

            // Biểu đồ đường có hai đường
            chart2 = CreateChart();
            Series lineSeries1 = new Series("LineSeries1");
            lineSeries1.ChartType = SeriesChartType.Line;
            lineSeries1.Points.AddY(20);
            lineSeries1.Points.AddY(40);
            lineSeries1.Color = Color.Blue;
            chart2.Series.Add(lineSeries1);

            Series lineSeries2 = new Series("LineSeries2");
            lineSeries2.ChartType = SeriesChartType.Line;
            lineSeries2.Points.AddY(60);
            lineSeries2.Points.AddY(80);
            lineSeries2.Color = Color.Orange;
            chart2.Series.Add(lineSeries2);

            pnl2.Controls.Add(chart2);

            // Biểu đồ cột với một thuộc tính
            chart3 = CreateChart();
            Series columnSeries = new Series("ColumnSeries");
            columnSeries.ChartType = SeriesChartType.Column;
            columnSeries.Points.AddY(50);
            columnSeries.Points[0].Color = Color.Purple;
            chart3.Series.Add(columnSeries);
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
