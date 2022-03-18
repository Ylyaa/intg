using intg.Intrrr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Series;

namespace intg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoCalculete();
            //int schet = Convert.ToInt32(perv.Text);
            //int upLine = Convert.ToInt32(vtor.Text);
            //int downLine = Convert.ToInt32(tret.Text);
            //MessageBox.Show($" N={schet}\n Нижний предел={upLine}\n Верхний предел ={downLine}");
            //MessageBox.Show(Convert.ToString(schet)+"!!");
        }

        private void btGraph_Click(object sender, RoutedEventArgs e)
        {
            var plot = new PlotModel()
            {
                Title = "11x - log(11x) - 2"
            };
            var lineSeries = new LineSeries();

            int upLim = Convert.ToInt32(tret.Text);
            int downLim = Convert.ToInt32(vtor.Text);
            ICalcult calcultGraph = new Primog();

            for (int i = 0; i < 1000; i++)
            {
                double time = 0;
                double result = calcultGraph.Calcul(i, upLim, downLim, x => (11 * x) - Math.Log(11 * x) - 2, out time);
                lineSeries.Points.Add(new DataPoint(i, time));
            }

            plot.Series.Add(lineSeries);
            Graph.Model = plot;
        }

        private ICalcult GetCalcult()
        {
            switch(metod.SelectedIndex)
            {
                case 0: return new Primog();
                case 1: return new Trapec();
                default: throw new NotImplementedException();

            }
        }

        private void DoCalculete()
        {
            int schet = Convert.ToInt32(perv.Text);
            double upLine = Convert.ToDouble(tret.Text);
            double downLine = Convert.ToDouble(vtor.Text);
            double time = 0;

            ICalcult calcult = GetCalcult();
            double result = calcult.Calcul(schet, upLine, downLine, x => (11 * x) - Math.Log(11 * x) - 2, out time);
            MessageBox.Show(result.ToString());
        }
    }
}
