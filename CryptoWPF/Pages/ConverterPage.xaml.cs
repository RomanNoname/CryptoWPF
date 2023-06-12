
using CryptoContracts;

namespace CryptoWPF.Pages
{
    /// <summary>
    /// Interaction logic for ConverterPage.xaml
    /// </summary>
    public partial class ConverterPage : Page
    {
        private ICoinSerivce _coinCapService;
        private decimal? _coinOut, _coinIn;
        public ConverterPage()
        {
            _coinCapService = new CoinCapService();
            InitializeComponent();
        }

        private async void SearchCoinIn(object sender, RoutedEventArgs e)
        {
            if (Handler.ShowMessage(ConvertIn.Text, (string)Application.Current.Resources["InvalidNameCoin"]))
                try
                {
                    CoinsIn.ItemsSource = await _coinCapService.GetCoinByName(ConvertIn.Text);
                }
                catch
                {
                    MessageBox.Show("Problem with the network");
                }
        }
        private async void SearchCoinOut(object sender, RoutedEventArgs e)
        {
            if (Handler.ShowMessage(ConvertOut.Text, (string)Application.Current.Resources["InvalidNameCoin"]))
                try
                {
                    CoinsOut.ItemsSource = await _coinCapService.GetCoinByName(ConvertOut.Text);
                }
                catch
                {
                    MessageBox.Show("Problem with the network");
                }
        }
        private void Convert(object sender, RoutedEventArgs e)
        {
            decimal count;
            if (!decimal.TryParse(CountCoin.Text, out count) || count < 0)
            {
                MessageBox.Show((string)Application.Current.Resources["InvalidCount"]);
                return;
            }
            if (!_coinOut.HasValue || !_coinIn.HasValue)
                MessageBox.Show((string)Application.Current.Resources["NothingToConvert"]);
            else
                Converted.Content = count * _coinOut / _coinIn;
        }
        private void GetCoinIn(object sender, SelectionChangedEventArgs e)
        {

            if (e.AddedItems.Count > 0)
            {
                Coin selectedCoin = e.AddedItems[0] as Coin;
                NameCoinIn.Content = selectedCoin?.Name;
                _coinIn = selectedCoin?.PriceUsd;

                NameCoinIn.Visibility = Visibility.Visible;

            }
        }
        private void GetCoinOut(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                Coin selectedCoin = e.AddedItems[0] as Coin;
                NameCoinOut.Content = selectedCoin?.Name;
                _coinOut = selectedCoin?.PriceUsd;

                NameCoinOut.Visibility = Visibility.Visible;
                IN.Visibility = Visibility.Visible;
            }
        }
        private void NumberOnly(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c))
                {
                    e.Handled = true;
                    break;
                }
            }
        }
    }
}
