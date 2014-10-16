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
    public class JsonSingleSerializerTest
    {
        [TestMethod]
        public void SerializeTest() {
            JsonSingleSerializer j = new JsonSingleSerializer();
            Assert.AreEqual(j.Serialize(float.MinValue), JsonConvert.SerializeObject(float.MinValue));
            Assert.AreEqual(j.Serialize(float.MaxValue), JsonConvert.SerializeObject(float.MaxValue));
            Assert.AreEqual(j.Serialize(0), JsonConvert.SerializeObject(0));
        }
    }
}
