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
using System.Windows.Shapes;
using WpfAppЛРОПБД.Classes;

namespace WpfAppЛРОПБД
{
    /// <summary>
    /// Логика взаимодействия для WindowAddPt.xaml
    /// </summary>
    public partial class WindowAddPt : Window
    {
        private PriceList _currentPriceList = new PriceList();
        public WindowAddPt(PriceList PriceList)
        {
            InitializeComponent();

            if (PriceList != null)
                _currentPriceList = PriceList;

            DataContext = _currentPriceList;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPriceList.id_priceList == 0)
            {
                InternetEntities.GetContext().PriceLists.Add(_currentPriceList);
            }
            InternetEntities.GetContext().SaveChanges();
            WindowObama WindowObama = new WindowObama();
            WindowObama.Show();
            Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPriceList.id_priceList == 0)
                InternetEntities.GetContext().PriceLists.Add(_currentPriceList);

            InternetEntities.GetContext().SaveChanges();
            MessageBox.Show("Данные сохранены");
            WindowObama WindowObama = new WindowObama();
            WindowObama.Show();
            Close();
        }
    }
}
