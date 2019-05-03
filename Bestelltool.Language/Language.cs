using Newtonsoft.Json.Linq;
using System.Text;

namespace Bestelltool.Language
{
    public static class Language
    {
        public static LangID LanguageID { get; set; }
        private static byte[] _file;
        private static string _translation;
        private static JObject _json;

        public static void Initialize(LangID id)
        {
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

        public static string GetText(string translationstring)
        {
            return (string)_json.SelectToken("translations." + translationstring);
        }
    }
}