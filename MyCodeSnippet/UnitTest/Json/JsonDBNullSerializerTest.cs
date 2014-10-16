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
    public class JsonDBNullSerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonDBNullSerializer j = new JsonDBNullSerializer();
            Assert.AreEqual(j.Serialize(DBNull.Value), JsonConvert.SerializeObject(DBNull.Value));
        }
    }
}
