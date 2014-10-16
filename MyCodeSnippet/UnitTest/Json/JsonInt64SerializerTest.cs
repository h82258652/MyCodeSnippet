using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCodeSnippet.Json;
using Newtonsoft.Json;

namespace UnitTest.Json
{
    [TestClass]
    public class JsonInt64SerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonInt64Serializer j = new JsonInt64Serializer();
            Assert.AreEqual(j.Serialize(long.MaxValue), JsonConvert.SerializeObject(long.MaxValue));
            Assert.AreEqual(j.Serialize(long.MinValue), JsonConvert.SerializeObject(long.MinValue));
            Assert.AreEqual(j.Serialize(0), JsonConvert.SerializeObject(0));
            Assert.AreEqual(j.Serialize(-1), JsonConvert.SerializeObject(-1));
            Assert.AreEqual(j.Serialize(1), JsonConvert.SerializeObject(1));
        }
    }
}
