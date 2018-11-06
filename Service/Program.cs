using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            var w = new WebClient();
            string clientID = "4b3c2fc5719236f";
            w.Headers.Add("Authorization", "Client-ID " + clientID);
            string url = "E:/Study/Project/WebAdmin/WebAdmin/images/mastercard.png";
            var values = new NameValueCollection
            {
                { "key", "433a1bf4743dd8d7845629b95b5ca1b4" },
                { "image", Convert.ToBase64String(File.ReadAllBytes(url)) }
             };

            byte[] response = w.UploadValues("https://api.imgur.com/3/image", values);
            string result = System.Text.Encoding.UTF8.GetString(response);
            var jObject = JsonConvert.DeserializeObject<JSONResult>(result);
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
