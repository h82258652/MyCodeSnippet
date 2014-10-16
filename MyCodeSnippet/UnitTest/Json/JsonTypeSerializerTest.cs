using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using MyCodeSnippet.Json;

namespace UnitTest.Json
{
    [TestClass]
    public class JsonTypeSerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonTypeSerializer j = new JsonTypeSerializer();
            Assert.AreEqual(j.Serialize(typeof(int)), JsonConvert.SerializeObject(typeof(int)));
        }
    }
}
