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
    /// Логика взаимодействия для WindowObama.xaml
    /// </summary>
    public partial class WindowObama : Window
    {
        public WindowObama()
        {
            InitializeComponent();
            dtgProviders.ItemsSource = InternetEntities.GetContext().Providers.ToList();
            dtgPriceLists.ItemsSource = InternetEntities.GetContext().PriceLists.ToList();
        }

        private void btnDo_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            Close();
        }

        private void btnEditPd_Click(object sender, RoutedEventArgs e)
        {
            WindowAddPd WindowAddPd = new WindowAddPd((sender as Button).DataContext as Provider);
            WindowAddPd.Show();
            Close();
        }

        private void DeletePd_Click(object sender, RoutedEventArgs e)
        {
            var DeleteProviders = dtgProviders.SelectedItems.Cast<Provider>().ToList();

            try
            {
                if (DeleteProviders.Count() > 0)
                {
                    if (MessageBox.Show($"Удалить {DeleteProviders.Count()} записей?",
                        "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                        MessageBoxResult.Yes)
                        InternetEntities.GetContext().Providers.RemoveRange(DeleteProviders);
                    InternetEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dtgProviders.ItemsSource = InternetEntities.GetContext().Providers.ToList();
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

        private void AddPd_Click(object sender, RoutedEventArgs e)
        {
            WindowAddPd WindowAddPd = new WindowAddPd(null);
            WindowAddPd.Show();
            Close();
        }

        private void btnEditPt_Click(object sender, RoutedEventArgs e)
        {
            WindowAddPt WindowAddPt = new WindowAddPt((sender as Button).DataContext as PriceList);
            WindowAddPt.Show();
            Close();
        }

        private void DeletePt_Click(object sender, RoutedEventArgs e)
        {
            var DeletePriceLists = dtgPriceLists.SelectedItems.Cast<PriceList>().ToList();

            try
            {
                if (DeletePriceLists.Count() > 0)
                {
                    if (MessageBox.Show($"Удалить {DeletePriceLists.Count()} записей?",
                        "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                        MessageBoxResult.Yes)
                        InternetEntities.GetContext().PriceLists.RemoveRange(DeletePriceLists);
                    InternetEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    dtgPriceLists.ItemsSource = InternetEntities.GetContext().PriceLists.ToList();
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

        private void AddPt_Click(object sender, RoutedEventArgs e)
        {
            WindowAddPt WindowAddPt = new WindowAddPt(null);
            WindowAddPt.Show();
            Close();
        }

        private void rbDownPd_Click(object sender, RoutedEventArgs e)
        {
            dtgProviders.ItemsSource = InternetEntities.GetContext().Providers.OrderByDescending(x => x.ProvidersName).ToList();
        }

        private void rbUpPd_Click(object sender, RoutedEventArgs e)
        {
            dtgProviders.ItemsSource = InternetEntities.GetContext().Providers.OrderBy(x => x.ProvidersName).ToList();
        }

        private void rbUpPt_Click(object sender, RoutedEventArgs e)
        {
            dtgPriceLists.ItemsSource = InternetEntities.GetContext().PriceLists.OrderBy(x => x.mincost).ToList();
        }

        private void rbDownPt_Click(object sender, RoutedEventArgs e)
        {
            dtgPriceLists.ItemsSource = InternetEntities.GetContext().PriceLists.OrderByDescending(x => x.mincost).ToList();
        }
    }
}
