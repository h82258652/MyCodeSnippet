using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCodeSnippet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCodeSnippet.Json;

namespace UnitTest.Json
{
    [TestClass]
    public class JsonStringSerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonStringSerializer j = new JsonStringSerializer();
            for (char i = char.MinValue; i < char.MaxValue; i++)
            {
                var my = j.Serialize(i.ToString());
                var newt = JsonConvert.SerializeObject(i);
                Assert.AreEqual(my, newt);
            }
        }
    }
}
