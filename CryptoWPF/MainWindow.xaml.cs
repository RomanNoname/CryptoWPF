using CryptoWPF.Pages;

namespace CryptoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Page> _pages;
        public MainWindow()
        {
            _pages = new List<Page> { new TopCoinsPage(), new SearchCoinPage(), new ConverterPage() };
            InitializeComponent();
            MainFrame.Content = _pages[0];
        }
        private void LoadTopCoinsPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = _pages[0];
            Title = "Crypto - Top 10";
        }
        private void LoadSearchCoinPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = _pages[1];
            Title = "Crypto - Search";
        }

        private void LoadConverter(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = _pages[2];
            Title = "Crypto - Converter";
        }
    }
}