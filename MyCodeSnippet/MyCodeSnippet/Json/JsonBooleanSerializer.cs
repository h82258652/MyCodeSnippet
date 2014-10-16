namespace MyCodeSnippet.Json
{
    public class JsonBooleanSerializer
    {
        public string Serialize(bool b)
        {
            return b ? "true" : "false";
        }
    }
}