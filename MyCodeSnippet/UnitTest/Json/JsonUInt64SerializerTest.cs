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
    public class JsonUInt64SerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonUInt64Serializer j = new JsonUInt64Serializer();
            Assert.AreEqual(j.Serialize(ulong.MinValue), JsonConvert.SerializeObject(ulong.MinValue));
            Assert.AreEqual(j.Serialize(ulong.MaxValue), JsonConvert.SerializeObject(ulong.MaxValue));
            Assert.AreEqual(j.Serialize(0), JsonConvert.SerializeObject(0));
            Assert.AreEqual(j.Serialize(1), JsonConvert.SerializeObject(1));
        }
    }
}
