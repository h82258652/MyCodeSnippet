using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCodeSnippet;
using Newtonsoft.Json;
using MyCodeSnippet.Json;

namespace UnitTest.Json
{
    [TestClass]
    public class JsonInt32SerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonInt32Serializer j = new JsonInt32Serializer();
            Assert.AreEqual(j.Serialize(int.MinValue), JsonConvert.SerializeObject(int.MinValue));
            Assert.AreEqual(j.Serialize(int.MaxValue), JsonConvert.SerializeObject(int.MaxValue));
            Assert.AreEqual(j.Serialize(0), JsonConvert.SerializeObject(0));
            Assert.AreEqual(j.Serialize(1), JsonConvert.SerializeObject(1));
            Assert.AreEqual(j.Serialize(-1), JsonConvert.SerializeObject(-1));
        }
    }
}
