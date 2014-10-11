using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCodeSnippet.JsonInt32Serializer j = new MyCodeSnippet.JsonInt32Serializer();

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
