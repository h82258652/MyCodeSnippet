using System;

namespace MyCodeSnippet.Json
{
    public class JsonTypeSerializer
    {
        public string Serialize(Type type)
        {
            return "\"" + type.AssemblyQualifiedName + "\"";
        }
    }
}