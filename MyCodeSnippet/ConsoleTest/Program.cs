using MyCodeSnippet.Json;
using System;
using System.Threading.Tasks;

namespace ConsoleTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            JsonInt32Serializer j = new JsonInt32Serializer();

            bool g = true;

            Parallel.For(int.MinValue, int.MaxValue, i =>
            {
                if (g == true)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    var my = j.Serialize(i);
                    var newt = Newtonsoft.Json.JsonConvert.SerializeObject(i);
                    var b = my == newt;
                    if (b == false)
                    {
                        Console.WriteLine(i);
                        g = false;
                    }
                }
            });

            Console.WriteLine("finish");
            Console.ReadKey();
        }
    }
}