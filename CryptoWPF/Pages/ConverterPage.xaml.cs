
using CryptoContracts;

namespace CryptoWPF.Pages
{
    /// <summary>
    /// Interaction logic for ConverterPage.xaml
    /// </summary>
    public partial class ConverterPage : Page
    {
        private CoinCapService _coinCapService;
        private decimal? _coinOut, _coinIn;
        public ConverterPage()
        {
            _coinCapService = new CoinCapService();
            InitializeComponent();
        }

        private async void SearchCoinIn(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ConvertIn.Text))
            {
                MessageBox.Show("Please, type name of coin");
                return;
            }
            CoinsIn.ItemsSource = await _coinCapService.GetCoinByName(ConvertIn.Text);
        }
        private async void SearchCoinOut(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ConvertOut.Text))
            {
                MessageBox.Show("Please, type name of coin");
                return;
            }
            CoinsOut.ItemsSource = await _coinCapService.GetCoinByName(ConvertOut.Text);
        }
        private void Convert(object sender, RoutedEventArgs e)
        {
            decimal count;
            if (!decimal.TryParse(CountCoin.Text, out count) || count < 0)
            {
                MessageBox.Show("Please, type count");
                return;
            }
            if (!_coinOut.HasValue || !_coinIn.HasValue)
                MessageBox.Show("Nothing to convert");
            else
                Converted.Content = count * _coinOut / _coinIn;
        }
        private void GetCoinIn(object sender, SelectionChangedEventArgs e)
        {

            if (e.AddedItems.Count > 0)
            {
                CoinCap selectedCoin = e.AddedItems[0] as CoinCap;
                NameCoinIn.Content = selectedCoin?.Name;
                _coinIn = selectedCoin?.PriceUsd;
                NameCoinIn.Visibility = Visibility.Visible;
               
            }
        }
        private void GetCoinOut(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                CoinCap selectedCoin = e.AddedItems[0] as CoinCap;
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
