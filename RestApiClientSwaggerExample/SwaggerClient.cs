using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace RestApiClientSwaggerExample
{
    public class SwaggerClient
    {
        RestClient client = new RestClient("https://petstore.swagger.io/v2");

        public string PostUser()
        {
            var userRequest = new RestRequest("/user", Method.POST);
            userRequest.AddHeader("content-type", "application/json");

            string json = @"{
  ""id"": 0,
            ""username"": ""userNameUniqViktor"",
            ""firstName"": ""Ilin"",
            ""lastName"": ""Viktor"",
            ""email"": ""viktor@gmail.com"",
            ""password"": ""qwerty"",
            ""phone"": ""+380501234567"",
            ""userStatus"": 1
        }";
            var body = userRequest.AddParameter("text/json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(userRequest);
            return response.Content;
        }

        public string GetUserDataByName(string name)
        {
            var request = new RestRequest($"/user/{name}", Method.GET);

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

      
    }
}