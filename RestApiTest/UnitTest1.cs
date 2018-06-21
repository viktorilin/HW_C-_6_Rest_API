using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestApiClientSwaggerExample;

namespace RestApiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetUserByNameTest()
        {
            var client = new SwaggerClient();
            var result = client.GetUserDataByName("userNameUniqViktor");
            JObject jObject = JObject.Parse(result);
            string displayEmail = (string)jObject.SelectToken("email");
            Assert.AreEqual("viktor@gmail.com", displayEmail);
        }
    }
}