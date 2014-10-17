using System.Globalization;

namespace MyCodeSnippet.Json
{
    public class JsonInt32Serializer
    {
        public string Serialize(int i)
        {
            return i.ToString(CultureInfo.InvariantCulture);
        }
    }
}