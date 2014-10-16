using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeSnippet.Json
{
    public class JsonInt32Serializer
    {
        public string Serialize(int i)
        {
            return i.ToString();
        }
    }
}
