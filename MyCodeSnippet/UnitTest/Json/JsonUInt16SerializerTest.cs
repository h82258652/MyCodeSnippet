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
    public class JsonUInt16SerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonUInt16Serializer j = new JsonUInt16Serializer();
            Assert.AreEqual(j.Serialize(ushort.MinValue), JsonConvert.SerializeObject(ushort.MinValue));
            Assert.AreEqual(j.Serialize(ushort.MaxValue), JsonConvert.SerializeObject(ushort.MaxValue));
            Assert.AreEqual(j.Serialize(0), JsonConvert.SerializeObject(0));
            Assert.AreEqual(j.Serialize(1), JsonConvert.SerializeObject(1));
        }
    }
}
