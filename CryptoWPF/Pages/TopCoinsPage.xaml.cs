
namespace CryptoWPF.Pages
{
    public partial class TopCoinsPage : Page
    {
        private ICoinSerivce _coinCapService;
        public TopCoinsPage()
        {
            _coinCapService = new CoinCapService();
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            try
            {
                DataContext = (await _coinCapService.GetTopCoins()).Take(10);
            }
            catch
            {
                MessageBox.Show("Problem with the network");
            }
        }
    }
}
