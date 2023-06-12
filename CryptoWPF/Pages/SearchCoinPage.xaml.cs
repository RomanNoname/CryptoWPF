
using CryptoContracts;
using System.Diagnostics;

namespace CryptoWPF.Pages
{
    /// <summary>
    /// Interaction logic for SearchCoinPage.xaml
    /// </summary>
    public partial class SearchCoinPage : Page
    {
        private ICoinSerivce _coinCapService;
        public SearchCoinPage()
        {
            _coinCapService = new CoinCapService();

            InitializeComponent();
           
        }

        private async void SearchCoin(object sender, RoutedEventArgs e)
        {
            if (!Handler.ShowMessage(NameCoin.Text, (string)Application.Current.Resources["InvalidNameCoin"]))
                return;

            try
            {
                var result = await _coinCapService.GetCoinByName(NameCoin.Text);
                DataContext = result;
            }
            catch
            {
                MessageBox.Show("Problem with the network");
            }
           
            
        }
        private void GetInfoCoin(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                Coin selectedCoin = (Coin)e.AddedItems[0];

                if (!string.IsNullOrEmpty(selectedCoin.Explorer))
                {
                    MessageBoxResult result = MessageBox.Show((string)Application.Current.Resources["Link"]+ " " + selectedCoin.Explorer, "", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = selectedCoin.Explorer,
                            UseShellExecute = true
                        });
                    }
                }
            }
        }
    }
}
