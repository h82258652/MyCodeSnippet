using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCodeSnippet;
using Newtonsoft.Json;

namespace UnitTest
{
    [TestClass]
    public class JsonBooleanSerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonBooleanSerializer j = new JsonBooleanSerializer();
            Assert.AreEqual(j.Serialize(true), JsonConvert.SerializeObject(true));
            Assert.AreEqual(j.Serialize(false), JsonConvert.SerializeObject(false));
        }
    }
}
