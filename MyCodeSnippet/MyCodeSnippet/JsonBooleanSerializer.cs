using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
