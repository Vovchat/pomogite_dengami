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
    /// Логика взаимодействия для WindowPlateji.xaml
    /// </summary>
    public partial class WindowPlateji : Window
    {
        public WindowPlateji()
        {
            InitializeComponent();
            dtgPlateji.ItemsSource = InternetEntities.GetContext().Klients.ToList();
        }

        private void btnKlientiki_Click(object sender, RoutedEventArgs e)
        {
            WindowKlientiki WindowKlientiki = new WindowKlientiki();
            WindowKlientiki.Show();
            Close();
        }

        private void btnDomoi_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            Close();
        }

        private void DobavitPL_Click(object sender, RoutedEventArgs e)
        {
            WindowAddPL WindowAddPL = new WindowAddPL(null);
            WindowAddPL.Show();
            Close();
        }

        private void btnEditPJ_Click(object sender, RoutedEventArgs e)
        {

            WindowAddPL WindowAddPL = new WindowAddPL((sender as Button).DataContext as Klient);
            WindowAddPL.Show();
            Close();
        }

        private void DeletePL_Click(object sender, RoutedEventArgs e)
        {
            var DeleteKlients = dtgPlateji.SelectedItems.Cast<Klient>().ToList();

            try
            {
                if (DeleteKlients.Count() > 0)
                {
                    if (MessageBox.Show($"Удалить {DeleteKlients.Count()} записей?",
                        "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                        MessageBoxResult.Yes)
                        InternetEntities.GetContext().Klients.RemoveRange(DeleteKlients);
                    InternetEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dtgPlateji.ItemsSource = InternetEntities.GetContext().Klients.ToList();
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

        private void txtSearchPL_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = txtSearchPL.Text;
            dtgPlateji.ItemsSource = InternetEntities.GetContext().Klients.Where(x => x.Name.ToString().Contains(searchText)).ToList();
        }

        private void rbDownN_Click(object sender, RoutedEventArgs e)
        {
            dtgPlateji.ItemsSource = InternetEntities.GetContext().Klients.OrderByDescending(x => x.Name).ToList();
        }
        
        private void rbUpN_Click(object sender, RoutedEventArgs e)
        {
            dtgPlateji.ItemsSource = InternetEntities.GetContext().Klients.OrderBy(x => x.Name).ToList();
        }
    }
}
