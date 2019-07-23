using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartsGraphApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

        private void Button1_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var obj in data.Revenue)
                series.Add(new PieSeries() { Title = obj.Year.ToString(), Values = new ChartValues<int> { obj.Total }, DataLabels = true, LabelPoint = labelPoint });
            pieChart1.Series = series;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
}
