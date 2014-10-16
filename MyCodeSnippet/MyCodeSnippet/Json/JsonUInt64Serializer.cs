using System.Globalization;

namespace MyCodeSnippet.Json
{
    public class JsonUInt64Serializer
    {
        public string Serialize(ulong ul)
        {
            return ul.ToString(CultureInfo.InvariantCulture);
        }
    }
}