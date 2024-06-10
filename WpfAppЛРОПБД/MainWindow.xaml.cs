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
using WpfAppЛРОПБД.Classes;

namespace WpfAppЛРОПБД
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
        private void btnKlientiki_Click(object sender, RoutedEventArgs e)
        {
            //btnKlientiki.Content = new PageKlientiki();
            WindowKlientiki WindowKlientiki = new WindowKlientiki();
            WindowKlientiki.Show();
            Close();
        }

        private void btnPlateji_Click(object sender, RoutedEventArgs e)
        {
            WindowPlateji WindowPlateji = new WindowPlateji();
            WindowPlateji.Show();
            Close();
        }

        private void btnObama_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
