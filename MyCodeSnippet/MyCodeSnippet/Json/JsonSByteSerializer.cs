using System.Globalization;

namespace MyCodeSnippet.Json
{
    public class JsonSByteSerializer
    {
        public string Serialize(sbyte sb)
        {
            return sb.ToString(CultureInfo.InvariantCulture);
        }
    }
}