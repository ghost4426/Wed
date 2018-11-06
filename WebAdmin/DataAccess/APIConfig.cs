using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebAdmin.DataAccess
{
    public class APIConfig
    {
        public readonly static string IpAddress = "127.0.0.1";


        public static string CallApi(string url, string method)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = method;
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