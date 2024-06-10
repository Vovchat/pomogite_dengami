using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Логика взаимодействия для Dobavlenie.xaml
    /// </summary>
    public partial class Dobavlenie : Window
    {
        private Service _currentService = new Service();
        public Dobavlenie(Service Service)
        {
            InitializeComponent();

            if (Service != null)
                _currentService = Service;

            DataContext = _currentService;

            cmbName.ItemsSource = InternetEntities.GetContext().Klients.ToList();
            cmbName.SelectedValuePath = "id_klient";
            cmbName.DisplayMemberPath = "Name";
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (_currentService.id_klient == 0)
            {
                InternetEntities.GetContext().Services.Add(_currentService);
            }
            InternetEntities.GetContext().SaveChanges();
            WindowKlientiki WindowKlientiki = new WindowKlientiki();    
            WindowKlientiki.Show();
            Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (_currentService.id_klient == 0)
                InternetEntities.GetContext().Services.Add(_currentService);

            InternetEntities.GetContext().SaveChanges();
            MessageBox.Show("Данные сохранены");
            WindowKlientiki WindowKlientiki = new WindowKlientiki();
            WindowKlientiki.Show();
            Close();
        }
    }
}
