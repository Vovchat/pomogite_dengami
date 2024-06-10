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
    /// Логика взаимодействия для WindowAddPd.xaml
    /// </summary>
    public partial class WindowAddPd : Window
    {
        private Provider _currentProvider = new Provider();
        public WindowAddPd(Provider Provider)
        {
            InitializeComponent();

            if (Provider != null)
                _currentProvider = Provider;

            DataContext = _currentProvider;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (_currentProvider.id_provider == 0)
            {
                InternetEntities.GetContext().Providers.Add(_currentProvider);
            }
            InternetEntities.GetContext().SaveChanges();
            WindowObama WindowObama = new WindowObama();
            WindowObama.Show();
            Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (_currentProvider.id_provider == 0)
                InternetEntities.GetContext().Providers.Add(_currentProvider);

            InternetEntities.GetContext().SaveChanges();
            MessageBox.Show("Данные сохранены");
            WindowObama WindowObama = new WindowObama();
            WindowObama.Show();
            Close();
        }
    }
}
