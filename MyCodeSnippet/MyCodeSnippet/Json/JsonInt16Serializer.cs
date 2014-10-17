using System.Globalization;

namespace MyCodeSnippet.Json
{
    public class JsonInt16Serializer
    {
        public string Serialize(short s)
        {
            return s.ToString(CultureInfo.InvariantCulture);
        }
    }
}