using System;

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