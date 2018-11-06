﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using WebAdmin.Models;

namespace WebAdmin.DataAccess
{
    public class ProductDataAcess
    {

        public static List<Product> GetListProductByStoreID(int StoreId)
        {
            string apiRoute = "/products-store/" + StoreId;
            string json = APIConfig.CallApi(apiRoute, "GET");
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products;
        }

        public static bool AddNewProduct(Product product, int storeId)
        {
            string imgKey = UploadImageToImgur(product.ImgPath);
            string apiRoute = "/addproduct/" + storeId + "&" + imgKey + "&" + product.ProductName + "&" + product.ProductPrice + "&" + product.TypeId;
            APIConfig.CallApi(apiRoute, "POST");
            return true;
        }

        public static string UploadImageToImgur(string url)
        {
            var w = new WebClient();
            string clientID = "4b3c2fc5719236f";
            w.Headers.Add("Authorization", "Client-ID " + clientID);
            var values = new NameValueCollection
            {
                { "key", "433a1bf4743dd8d7845629b95b5ca1b4" },
                { "image", Convert.ToBase64String(File.ReadAllBytes(url)) }
             };

            byte[] response = w.UploadValues("https://api.imgur.com/3/image", values);
            string result = System.Text.Encoding.UTF8.GetString(response);
            var data = JsonConvert.DeserializeObject<JSONResult>(result);
            return data.Data.id;
        }

    }
    class Data
    {
        public string link { get; set; }
        public string id { get; set; }
    }

    class JSONResult
    {
        public Data Data { get; set; }
    }
}