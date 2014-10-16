using System.Globalization;

namespace MyCodeSnippet.Json
{
    // TODO finish
    public class JsonCharSerializer
    {
        public string Serialize(char c)
        {
            switch (c)
            {
                case '\b':// 8
                    {
                        return "\"\\b\"";
                    }
                case '\t':// 9
                    {
                        return "\"\\t\"";
                    }
                case '\n':// 10
                    {
                        return "\"\\n\"";
                    }
                case '\f':// 12
                    {
                        return "\"\\f\"";
                    }
                case '\r':// 13
                    {
                        return "\"\\r\"";
                    }
                case '\"':// 34
                    {
                        return "\"\\\"\"";
                    }
                case '\\':// 92
                    {
                        return "\"\\\\\"";
                    }
                default:
                    {
                        if (c < 0x20 || c == '\u0085' || c == '\u2028' || c == '\u2029')
                        {
                            return "\"\\u" + ((int)c).ToString("x4", CultureInfo.InvariantCulture) + "\"";
                        }
                        return "\"" + c + "\"";
                    }
            }
        }
    }
}