
namespace CryptoWPF.Pages
{
    /// <summary>
    /// Interaction logic for TopCoinsPage.xaml
    /// </summary>
    public partial class TopCoinsPage : Page
    {
        public TopCoinsPage()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            var a = new CoinCapService();

            DataContext = (await a.GetTopCoins()).Take(10);
        }
    }
}
