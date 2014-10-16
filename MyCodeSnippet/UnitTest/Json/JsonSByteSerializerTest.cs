using MyCodeSnippet.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;

namespace UnitTest.Json
{
    [TestClass]
    public class JsonSByteSerializerTest
    {
        [TestMethod()]
        public void SerializeTest()
        {
            JsonSByteSerializer j = new JsonSByteSerializer();
            Assert.AreEqual(j.Serialize(sbyte.MinValue), JsonConvert.SerializeObject(sbyte.MinValue));
            Assert.AreEqual(j.Serialize(sbyte.MaxValue), JsonConvert.SerializeObject(sbyte.MaxValue));
            Assert.AreEqual(j.Serialize(0), JsonConvert.SerializeObject(0));
            Assert.AreEqual(j.Serialize(1), JsonConvert.SerializeObject(1));
            Assert.AreEqual(j.Serialize(-1), JsonConvert.SerializeObject(-1));
        }
    }
}
