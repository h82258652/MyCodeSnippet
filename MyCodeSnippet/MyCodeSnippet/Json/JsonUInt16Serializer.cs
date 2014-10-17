using System.Globalization;

namespace MyCodeSnippet.Json
{
    public class JsonUInt16Serializer
    {
        public string Serialize(ushort us)
        {
            return us.ToString(CultureInfo.InvariantCulture);
        }
    }
}