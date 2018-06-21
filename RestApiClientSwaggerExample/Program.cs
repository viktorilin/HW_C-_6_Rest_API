using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestApiClientSwaggerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = ConfigurationManager.AppSettings["path"];
            var client = new SwaggerClient();
            var str = client.PostUser();
            var user = client.GetUserDataByName("userNameUniqViktor");
            Console.WriteLine(str);
            Console.WriteLine("*************");
            Console.WriteLine(user);
            File.WriteAllText(path,user);

            Console.Read();
        }
    }
}