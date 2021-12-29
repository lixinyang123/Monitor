using LiveCharts;
using LiveCharts.Wpf;
using System.Windows;

namespace Monitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            chart1.Series = new SeriesCollection()
            {
                new LineSeries()
                {
                    Values = new ChartValues<int> { 1, 3, -7, 4, 6, -2, 10, 5 }
                }
            };

            chart2.Series = new SeriesCollection()
            {
                new LineSeries()
                {
                    Values = new ChartValues<int> { -1, 3, 7, -4, 6, -2, -10, 5 }
                }
            };

            chart3.Series = new SeriesCollection()
            {
                new LineSeries()
                {
                    Values = new ChartValues<int> { 1, -3, -7, 4, -6, 2, 10, 5 }
                }
            };
        }
    }
}
