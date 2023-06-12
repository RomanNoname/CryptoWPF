using CryptoWPF.Pages;
using System.IO;
using System.Text.Json;

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

        private async void SwitchUALang(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("ua");
            foreach (var page in _pages)
                page.SwitchLanguage("ua");
            await SetSettings("ua");
        }
        private async void SwitchENLang(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("en-US");
            foreach (var page in _pages)
                page.SwitchLanguage("en-US");
            await SetSettings("en-US");
        }
        private void SwitchLanguage(string language)
        {
            var mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            mergedDictionaries.Clear();
            var Dictionary = new ResourceDictionary();
            Dictionary.Source = new Uri("Resources/Resources." + language + ".xaml", UriKind.RelativeOrAbsolute);
            mergedDictionaries.Add(Dictionary);
        }
        private async void CustomInitialize()
        {
            MainFrame.Content = _pages[0];
            SwitchLanguage((await GetSettings()).Language);
        }
        private async Task<Settings> GetSettings(string language = "ua")
        {
            var settings = new Settings(language);
            if (File.Exists("settings.json"))
            {
                using var fs = new FileStream("settings.json", FileMode.Open);
                settings = await JsonSerializer.DeserializeAsync<Settings>(fs);
            }
            else
            {
                using var fs = new FileStream("settings.json", FileMode.Create);
                await JsonSerializer.SerializeAsync(fs, settings);
            }
            return settings;
        }
        private async Task SetSettings(string language)
        {
            var settings = new Settings(language);
            using var fs = new FileStream("settings.json", FileMode.Create);
            await JsonSerializer.SerializeAsync(fs,settings);

        }
        public record class Settings(string Language);

    }
}