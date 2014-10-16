using System;

namespace MyCodeSnippet.Json
{
    public class JsonGuidSerializer
    {
        public string Serialize(Guid guid)
        {
            return "\"" + guid + "\"";
        }
    }
}