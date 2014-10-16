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
    public class JsonGuidSerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonGuidSerializer j = new JsonGuidSerializer();
            var guid = Guid.NewGuid();
            Assert.AreEqual(j.Serialize(guid), JsonConvert.SerializeObject(guid));
        }
    }
}
