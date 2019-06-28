using Microsoft.Win32;

namespace Bestelltool.Language
{
    internal static class RegistryHelper
    {
        public static void SetLanguage(LangID language)
        {
            using (var _registryKey = Registry.CurrentUser.OpenSubKey("Software\\Bestellsoftware", true))
            {
                _registryKey.SetValue("Language", language, RegistryValueKind.DWord);
            }
        }

        public static LangID GetLanguage()
        {
            using (var _registryKey = Registry.CurrentUser.OpenSubKey("Software\\Bestellsoftware", true))
            {
                var id = (LangID)_registryKey.GetValue("Language");
                return id;
            }
        }
    }
}