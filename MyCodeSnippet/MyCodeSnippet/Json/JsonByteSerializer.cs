using System.Globalization;

namespace MyCodeSnippet.Json
{
    public class JsonByteSerializer
    {
        public string Serialize(byte b)
        {
            return b.ToString(CultureInfo.InvariantCulture);
        }
    }
}