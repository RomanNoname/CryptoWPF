using CryptoWPF.Pages;
using System.Globalization;
using System.Threading;
using System.Windows.Markup;

namespace CryptoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Page> _pages;
        private Dictionary<string, ResourceDictionary> _languageDictionaries;

        public MainWindow()
        {
            _pages = new List<Page> { new TopCoinsPage(), new SearchCoinPage(), new ConverterPage() };
            _languageDictionaries = new Dictionary<string, ResourceDictionary>();
            InitializeComponent();
            CustomInitialize();
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

        private void SwitchUALang(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("uk-UA");
            _pages[1].Language = XmlLanguage.GetLanguage("uk-UA");
        }
        private void SwitchENLang(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("en-US");
            _pages[1].Language = XmlLanguage.GetLanguage("en-US");
        }
        private void SwitchLanguage(string culture)
        {
            if (_languageDictionaries.TryGetValue(culture, out ResourceDictionary dictionary))
            {
               
                var dictionariesToRemove = new List<ResourceDictionary>();
                foreach (var mergedDictionary in Resources.MergedDictionaries)
                {
                    if (mergedDictionary.Source != null && mergedDictionary.Source.OriginalString.StartsWith("Resources/Resources."))
                    {
                        dictionariesToRemove.Add(mergedDictionary);
                    }
                }
                foreach (var mergedDictionary in dictionariesToRemove)
                {
                    Resources.MergedDictionaries.Remove(mergedDictionary);
                }

                Resources.MergedDictionaries.Add(dictionary);

                Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            }
        }
        private void CustomInitialize()
        {
            MainFrame.Content = _pages[0];

            var enDictionary = new ResourceDictionary();
            enDictionary.Source = new Uri("Resources/Resources.en-US.xaml", UriKind.RelativeOrAbsolute);
            _languageDictionaries.Add("en-US", enDictionary);
            var uaDictionary = new ResourceDictionary();
            uaDictionary.Source = new Uri("Resources/Resources.ua.xaml", UriKind.RelativeOrAbsolute);
            _languageDictionaries.Add("uk-UA", uaDictionary);
            Resources.MergedDictionaries.Add(enDictionary);
        }
    }
}