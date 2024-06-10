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
    /// Логика взаимодействия для WindowKlientiki.xaml
    /// </summary>
    public partial class WindowKlientiki : Window
    {
        public WindowKlientiki()
        {
            InitializeComponent();
            dtgKlientiki.ItemsSource = InternetEntities.GetContext().Services.ToList();
            
            cmbName.ItemsSource = InternetEntities.GetContext().Klients.ToList();
            cmbName.SelectedValuePath = "id_klient";
            cmbName.DisplayMemberPath = "Name";
        }

        private void window_TouchMove(object sender, TouchEventArgs e)
        {

        }

        private void btnPlateji_Click(object sender, RoutedEventArgs e)
        {
            WindowPlateji WindowPlateji = new WindowPlateji();
            WindowPlateji.Show();
            Close();
        }

        private void btnDomoi_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            Close();
        }

        private void cmbName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idklient = int.Parse(cmbName.SelectedValue.ToString());
            dtgKlientiki.ItemsSource = InternetEntities.GetContext().Services.Where(x => x.id_klient == idklient).ToList();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = txtSearch.Text;
            dtgKlientiki.ItemsSource = InternetEntities.GetContext().Services.Where(x => x.Result.ToString().Contains(searchText)).ToList();
        }

        private void rbUp_Click(object sender, RoutedEventArgs e)
        {
            dtgKlientiki.ItemsSource = InternetEntities.GetContext().Services.OrderBy(x => x.Result).ToList();
        }

        private void rbDown_Click(object sender, RoutedEventArgs e)
        {
            dtgKlientiki.ItemsSource = InternetEntities.GetContext().Services.OrderByDescending(x => x.Result).ToList();
        }

        private void Dobavit_Click(object sender, RoutedEventArgs e)
        {
            Dobavlenie Dobavlenie = new Dobavlenie(null);
            Dobavlenie.Show();
            Close();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Dobavlenie Dobavlenie = new Dobavlenie((sender as Button).DataContext as Service);
            Dobavlenie.Show();
            Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var DeleteServices = dtgKlientiki.SelectedItems.Cast<Service>().ToList();

            try
            {
                if (DeleteServices.Count() > 0)
                {
                    if (MessageBox.Show($"Удалить {DeleteServices.Count()} записей?",
                        "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                        MessageBoxResult.Yes)
                        InternetEntities.GetContext().Services.RemoveRange(DeleteServices);
                    InternetEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dtgKlientiki.ItemsSource = InternetEntities.GetContext().Services.ToList();
                }
                else
                    MessageBox.Show("Записи не указаны", "Внимание", MessageBoxButton.OK,
                        MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
