using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCodeSnippet.Json
{
    public class JsonUInt64Serializer
    {
        public string Serialize(ulong ul)
        {
            return ul.ToString();
        }
    }
}
