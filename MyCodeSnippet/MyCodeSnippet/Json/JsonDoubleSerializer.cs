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