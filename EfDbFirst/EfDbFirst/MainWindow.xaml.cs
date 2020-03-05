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

namespace EfDbFirst
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

        NorthwindEntities context = new NorthwindEntities();

        private void Laden(object sender, RoutedEventArgs e)
        {
            myGrid.ItemsSource = context.Customers.ToList();
        }

        private void Speichern(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void GetCustOrdersDetail(object sender, RoutedEventArgs e)
        {
            myGrid.ItemsSource = context.GetCustOrdersDetail(10297);
        }
    }
}
