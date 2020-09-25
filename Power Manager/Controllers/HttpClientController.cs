using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PowerManager.Controllers
{
    class HttpClientController
    {
        private static HttpClient HttpClient = null;

        private static HttpClient getInstance()
        {
            if (HttpClient == null)
            {
                HttpClient = new HttpClient();
            }
            return HttpClient;
        }

        public static async Task<HttpResponseMessage> HttpClientGetAsync(string path)
        {
            try
            {
                HttpResponseMessage response = await getInstance().GetAsync(path);
                return response;
            } catch
            {
                return null;
            }
        }

        public static async Task<HttpResponseMessage> HttpClientPostAsync(string path,object data)
        {
            try
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await getInstance().PostAsync(path,content);
                return response;
            }
            catch
            {
                return null;
            }
        }
    }
}
