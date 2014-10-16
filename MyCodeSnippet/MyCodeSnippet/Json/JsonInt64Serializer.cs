using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCodeSnippet.Json
{
    public class JsonInt64Serializer
    {
        public string Serialize(long l)
        {
            return l.ToString();
        }
    }
}
