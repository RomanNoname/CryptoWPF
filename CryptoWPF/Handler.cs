
namespace CryptoWPF
{
    public static class Handler
    {
        public static bool ShowMessage(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show(message);
                return false;
            }
            return true;
        }
        public static void SwitchLanguage(this Page page, string language)
        {
            var mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            mergedDictionaries.Clear();

            var Dictionary = new ResourceDictionary();
            Dictionary.Source = new Uri("Resources/Resources."+language+".xaml", UriKind.RelativeOrAbsolute);
            mergedDictionaries.Add(Dictionary);

        }
    }
}

