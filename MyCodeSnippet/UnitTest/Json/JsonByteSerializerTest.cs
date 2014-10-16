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
    public class JsonByteSerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonByteSerializer j = new JsonByteSerializer();
            for (var i = byte.MinValue; i < byte.MaxValue; i++)
            {
                Assert.AreEqual(j.Serialize(i), JsonConvert.SerializeObject(i));
            }
            Assert.AreEqual(j.Serialize(byte.MaxValue), JsonConvert.SerializeObject(byte.MaxValue));
        }
    }
}
