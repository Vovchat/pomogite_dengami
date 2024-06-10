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
    /// Логика взаимодействия для WindowAddPL.xaml
    /// </summary>
    public partial class WindowAddPL : Window
    {
        private Klient _currentKlient = new Klient();
        public WindowAddPL(Klient Klient)
        {
            InitializeComponent();

            if (Klient != null)
                _currentKlient = Klient;

            DataContext = _currentKlient;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (_currentKlient.id_klient == 0)
            {
                InternetEntities.GetContext().Klients.Add(_currentKlient);
            }
            InternetEntities.GetContext().SaveChanges();
            WindowPlateji WindowPlateji = new WindowPlateji();
            WindowPlateji.Show();
            Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (_currentKlient.id_klient == 0)
                InternetEntities.GetContext().Klients.Add(_currentKlient);

            InternetEntities.GetContext().SaveChanges();
            MessageBox.Show("Данные сохранены");
            WindowPlateji WindowPlateji = new WindowPlateji();
            WindowPlateji.Show();
            Close();
        }
    }
}
