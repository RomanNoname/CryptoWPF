
using CryptoContracts;
using System.Diagnostics;

namespace CryptoWPF.Pages
{
    /// <summary>
    /// Interaction logic for SearchCoinPage.xaml
    /// </summary>
    public partial class SearchCoinPage : Page
    {
        private CoinCapService _coinCapService;
        public SearchCoinPage()
        {
            _coinCapService = new CoinCapService();
            InitializeComponent();
        }

        private async void SearchCoin(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameCoin.Text))
            {
                MessageBox.Show("Please, type name of coin");
                return;
            }
            var result = await _coinCapService.GetCoinByName(NameCoin.Text);
            DataContext = result;
        }
        private void GetInfoCoin(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                CoinCap selectedCoin = (CoinCap)e.AddedItems[0];

                if (!string.IsNullOrEmpty(selectedCoin.Explorer))
                {
                    MessageBoxResult result = MessageBox.Show("Will open "+selectedCoin.Explorer, "", MessageBoxButton.YesNo, MessageBoxImage.Question);

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
