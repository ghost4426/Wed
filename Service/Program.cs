using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Product
    {
        public int id { get; set; }
        public string ProductName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://192.168.1.21:3000/products-type/SD0001F01T01&1";
            string json = GetReleases(url);
           List<Product> products =  JsonConvert.DeserializeObject<List<Product>>(json);
            Console.ReadLine();
        }



        public static string GetReleases(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var content = string.Empty;

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadToEnd();
                    }
                }
            }

            return content;
        }
    }
}
