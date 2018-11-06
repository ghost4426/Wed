using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebAdmin.Models;

namespace Service
{

    class UserDataAccess
    {
        static void Main(string[] args)
        {
            string url = "http://127.0.0.1:3000/products-type/SD0001F01T01&1";
            string json = GetReleases(url);
           List<Bill> products =  JsonConvert.DeserializeObject<List<Bill>>(json);
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
