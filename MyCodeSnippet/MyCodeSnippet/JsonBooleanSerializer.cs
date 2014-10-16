using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCodeSnippet
{
    public class JsonBooleanSerializer
    {
        public string Serialize(bool b)
        {
            return b ? "true" : "false";
        }
    }
}
