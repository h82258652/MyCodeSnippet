using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCodeSnippet.Json;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace UnitTest.Json
{
    [TestClass]
    public class JsonDoubleSerializerTest
    {
        [TestMethod]
        public void SerializeTest()
        {
            JsonDoubleSerializer j = new JsonDoubleSerializer();
            JavaScriptSerializer netj = new JavaScriptSerializer();

            Assert.AreEqual(j.Serialize(0.5), netj.Serialize(0.5));
            Assert.AreEqual(j.Serialize(0.5), JsonConvert.SerializeObject(0.5));

            Assert.AreEqual(j.Serialize(double.MinValue), JsonConvert.SerializeObject(double.MinValue));
            Assert.AreEqual(j.Serialize(double.MinValue), netj.Serialize(double.MinValue));

            Assert.AreEqual(j.Serialize(double.MaxValue), JsonConvert.SerializeObject(double.MaxValue));
            Assert.AreEqual(j.Serialize(double.MaxValue), netj.Serialize(double.MaxValue));

            Assert.AreEqual(j.Serialize(0), JsonConvert.SerializeObject(0));
            Assert.AreEqual(j.Serialize(0), netj.Serialize(0));

            Assert.AreEqual(j.Serialize(Math.PI), JsonConvert.SerializeObject(Math.PI));
            Assert.AreEqual(j.Serialize(Math.PI), netj.Serialize(Math.PI));

            Assert.AreEqual(j.Serialize(Math.E), JsonConvert.SerializeObject(Math.E));
            Assert.AreEqual(j.Serialize(Math.E), netj.Serialize(Math.E));
        }
    }
}
