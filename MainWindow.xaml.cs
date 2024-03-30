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
using PrPract1.DataSet1TableAdapters;

namespace PrPract1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EMPTableAdapter emp = new EMPTableAdapter();
        ClientsTableAdapter clients = new ClientsTableAdapter();
        CoffeeTableAdapter coffee = new CoffeeTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bt1_Cl(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new Page1();
        }

        private void Bt2_Cl(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new Page2();
        }

        private void Bt3_Cl(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new Page3();
        }
    }
}
