
namespace CryptoWPF.Pages
{
    /// <summary>
    /// Interaction logic for TopCoinsPage.xaml
    /// </summary>
    public partial class TopCoinsPage : Page
    {
        private CoinCapService _coinCapService;
        public TopCoinsPage()
        {
            _coinCapService = new CoinCapService();
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
          DataContext = (await _coinCapService.GetTopCoins()).Take(10);
        }
    }
}
