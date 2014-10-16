using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCodeSnippet.Json
{
    public class JsonGuidSerializer
    {
        public string Serialize(Guid guid) { return "\"" + guid + "\""; }
    }
}
