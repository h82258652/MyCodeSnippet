using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeSnippet
{
    // TODO finish
    public class JsonStringSerializer
    {
        public string Serialize(string s)
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append('\"');
            foreach (var c in s)
            {
                switch (c)
                {
                    case '\b':// 8
                        {
                            buffer.Append("\\b");
                            break;
                        }
                    case '\t':// 9
                        {
                            buffer.Append("\\t");
                            break;
                        }
                    case '\n':// 10
                        {
                            buffer.Append("\\n");
                            break;
                        }
                    case '\f':// 12
                        {
                            buffer.Append("\\f");
                            break;
                        }
                    case '\r':// 13
                        {
                            buffer.Append("\\r");
                            break;
                        }
                    case '\"':// 34
                        {
                            buffer.Append("\\\"");
                            break;
                        }
                    case '\\':// 92
                        {
                            buffer.Append("\\\\");
                            break;
                        }
                    default:
                        {
                            if (c < 0x20 || c == '\u0085' || c == '\u2028' || c == '\u2029')
                            {
                                buffer.Append("\\u" + ((int)c).ToString("x4", CultureInfo.InvariantCulture));
                                break;
                            }
                            else
                            {
                                buffer.Append(c);
                                break;
                            }
                        }
                }
            }
            buffer.Append('\"');
            return buffer.ToString();
        }
    }
}
