using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCodeSnippet;
using Newtonsoft.Json;

namespace UnitTest
{
    [TestClass]
    public class JsonCharSerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonCharSerializer j = new JsonCharSerializer();
            for (char i = char.MinValue; i < char.MaxValue; i++)
            {
                var my = j.Serialize(i);
                var newt = JsonConvert.SerializeObject(i);
                Assert.AreEqual(my, newt);
            }
        }
    }
}
