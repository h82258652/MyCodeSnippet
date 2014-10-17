using System.Globalization;

namespace MyCodeSnippet.Json
{
    public class JsonInt64Serializer
    {
        public string Serialize(long l)
        {
            return l.ToString(CultureInfo.InvariantCulture);
        }
    }
}