using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCodeSnippet.Json
{
    public class JsonTypeSerializer
    {
        public string Serialize(Type type) { return "\"" + type.AssemblyQualifiedName + "\""; }
    }
}
