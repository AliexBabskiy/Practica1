using PrPract1.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace PrPract1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        ClientTableAdapter clients = new ClientTableAdapter();
        public Page2()
        {
            InitializeComponent();
            tablic.ItemsSource = clients.GetData();
        }

        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            clients.InsertQuery(Convert.ToString(text2.Text));
            tablic.ItemsSource = clients.GetData();
        }

        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            object id = (tablic.SelectedItem as DataRowView).Row[0];
            clients.UpdateQuery(Convert.ToString(text2.Text), Convert.ToInt32(id));
            tablic.ItemsSource = clients.GetData();
        }

        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            object id = (tablic.SelectedItem as DataRowView).Row[0];
            clients.DeleteQuery(Convert.ToInt32(id));
            tablic.ItemsSource = clients.GetData();
        }

        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                DataRowView row = tablic.SelectedItem as DataRowView;
                if (row != null)
                {
                    text1.Text = row.Row["ID_Client"].ToString();
                    text2.Text = row.Row["ClientName"].ToString();
                }
            }
        }
    }
}
