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
            //int schet = Convert.ToInt32(perv.Text);
            //int upLine = Convert.ToInt32(vtor.Text);
            //int downLine = Convert.ToInt32(tret.Text);
            //MessageBox.Show($" N={schet}\n Нижний предел={upLine}\n Верхний предел ={downLine}");
            //MessageBox.Show(Convert.ToString(schet)+"!!");
        }
    }
}
