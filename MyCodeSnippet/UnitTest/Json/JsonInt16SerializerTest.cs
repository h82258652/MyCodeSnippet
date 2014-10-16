using MyCodeSnippet.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;

namespace UnitTest.Json
{
    [TestClass]
    public class JsonInt16SerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonInt16Serializer j = new JsonInt16Serializer();
            Assert.AreEqual(j.Serialize(short.MinValue), JsonConvert.SerializeObject(short.MinValue));
            Assert.AreEqual(j.Serialize(short.MaxValue), JsonConvert.SerializeObject(short.MaxValue));
            Assert.AreEqual(j.Serialize(0), JsonConvert.SerializeObject(0));
            Assert.AreEqual(j.Serialize(-1), JsonConvert.SerializeObject(-1));
            Assert.AreEqual(j.Serialize(1), JsonConvert.SerializeObject(1));
        }
    }
}
