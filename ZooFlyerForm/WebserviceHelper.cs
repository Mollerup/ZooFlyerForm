using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ZooFlyerForm.Models;

namespace ZooFlyerForm
{
    public static class WebserviceHelper
    {
        private const string ServerUrl = "http://zooflyers1314.azurewebsites.net";

        public static User GetUser(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return client.GetAsync($"api/Users/{id}").Result.Content.ReadAsAsync<User>().Result;
            }
        }

        public static Image GetImage(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return client.GetAsync($"api/Images/{id}").Result.Content.ReadAsAsync<Image>().Result;
            }
        }

        public static void PostToDatabaseAsync<T>(string api, T obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.PostAsJsonAsync(api, obj);
            }
        }
    }
}
