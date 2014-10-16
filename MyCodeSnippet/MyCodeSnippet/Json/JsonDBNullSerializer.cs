using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCodeSnippet.Json
{
    public class JsonDBNullSerializer
    {
        public string Serialize(DBNull dbnull)
        {
            return "null";
        }
    }
}
