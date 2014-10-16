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
    public class JsonUInt32SerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonUInt32Serializer j = new JsonUInt32Serializer();
            Assert.AreEqual(j.Serialize(uint.MaxValue), JsonConvert.SerializeObject(uint.MaxValue));
            Assert.AreEqual(j.Serialize(uint.MinValue), JsonConvert.SerializeObject(uint.MinValue));
            Assert.AreEqual(j.Serialize(0), JsonConvert.SerializeObject(0));
            Assert.AreEqual(j.Serialize(1), JsonConvert.SerializeObject(1));
        }
    }
}
