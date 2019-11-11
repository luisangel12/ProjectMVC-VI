using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Services
{
    public class RestClient
    {
        public class Response
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
            public object Result { get; set; }
        }

        public enum Method
        {
            Get,
            Post,
            Put,
            Delete
        }

        /// <summary>
        /// RequestAPI
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="urlBase"></param>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public async Task<Response> RequestAPI<T>(string urlBase,
            string url,
            HttpContent content,
            Method method)
        {
            HttpClient cliente = new HttpClient();
            url = string.Format("{0}{1}", urlBase, url);

            //HttpContent content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8,"application/json");

            HttpResponseMessage response;

            if (method == Method.Get)
                response = await cliente.GetAsync(url);
            else if (method == Method.Post)
                response = await cliente.PostAsync(url, content);
            else if (method == Method.Put)
                response = await cliente.PutAsync(url, content);
            else
                response = await cliente.DeleteAsync(url);

            string responseText = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return new Response
                {
                    IsSuccess = true,
                    Result = JsonConvert.DeserializeObject<T>(responseText)
                };
            }
            else
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = responseText
                };
            }
        }
    }
}