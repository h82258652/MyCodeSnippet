using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCodeSnippet.JsonCharSerializer j = new MyCodeSnippet.JsonCharSerializer();
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                var c = (char)i;
                var my = j.Serializer(c);
                var newt = Newtonsoft.Json.JsonConvert.SerializeObject(c);
                var b = my == newt;
                if (b == false)
                {
                    Console.WriteLine(c);
                    break;
                }
            }
            Console.WriteLine("finish");
            Console.ReadKey();
        }
    }
}
