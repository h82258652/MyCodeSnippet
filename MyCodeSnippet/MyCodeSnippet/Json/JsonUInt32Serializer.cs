using System.Globalization;

namespace MyCodeSnippet.Json
{
    public class JsonUInt32Serializer
    {
        public string Serialize(uint ui)
        {
            return ui.ToString(CultureInfo.InvariantCulture);
        }
    }
}