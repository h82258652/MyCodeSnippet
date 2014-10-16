using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCodeSnippet.Json
{
    public class JsonDoubleSerializer
    {
        public string Serialize(double d)
        {
            return d.ToString("r");
        }
    }
}
