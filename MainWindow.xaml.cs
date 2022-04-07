using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    class test
    {
        public string  ame { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ChartPayments.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("Main"));

            var currentSeries = new Series("Payments")
            {
                IsValueShownAsLabel = true
            };

            ChartPayments.Series.Add(currentSeries);
            Combo.ItemsSource = Enum.GetValues(typeof(SeriesChartType));

            var list = new List<int> { 1, 2, 39, 20, 48, 5 };
            var listx = new List<int> { 1, 2, 3, 4, 5, 6 };
            Series curent = ChartPayments.Series.FirstOrDefault();
            for (int i = 0; i < 6; i++)
            {
                curent.Points.AddXY(listx[i], list[i]);
            }

        }

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
            var list = new List<int> { 1, 2, 39, 20, 48, 5 };
            var listx = new List<int> { 1, 2, 3, 4, 5, 6 };
            Series curent = ChartPayments.Series.FirstOrDefault();
            curent.ChartType = (SeriesChartType) Combo.SelectedItem;
            curent.Points.Clear();
            for (int i = 0; i < 6; i++)
            {
                curent.Points.AddXY(listx[i], list[i]);
            }

        }
    }
}
