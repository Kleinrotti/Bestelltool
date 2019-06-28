using Newtonsoft.Json.Linq;
using System;
using System.Text;

namespace Bestelltool.Language
{
    public class Lang
    {
        /// <summary>
        /// Stores the current selected language
        /// </summary>
        public static LangID LanguageID { get; set; }

        private static byte[] _file;
        private static string _translation;
        private static JObject _json;

        /// <summary>
        /// Triggers when the user selects another language
        /// </summary>
        public static event EventHandler LanguageChanged;

        public Lang()
        {
            Initialize();
        }

        private void Initialize()
        {
            var id = RegistryHelper.GetLanguage();
            switch (id)
            {
                case LangID.English:
                    _file = Resource.english;
                    break;

                case LangID.German:
                    _file = Resource.german;
                    break;
            }
            LanguageID = id;
            _translation = Encoding.Default.GetString(_file);
            _json = JObject.Parse(_translation);
        }

        private void LanguageChange(object sender, EventArgs e)
        {
            LanguageChanged?.Invoke(sender, e);
        }

        /// <summary>
        /// Change the language
        /// </summary>
        /// <param name="id"></param>
        public void ChangeLanguage(LangID id)
        {
            RegistryHelper.SetLanguage(id);
            Initialize();
            LanguageChange(this, EventArgs.Empty);
        }

        /// <summary>
        /// Get a translated text
        /// </summary>
        /// <param name="translationstring"></param>
        /// <returns></returns>
        public static string GetText(string translationstring)
        {
            return (string)_json.SelectToken("translations." + translationstring);
        }
    }
}