using Newtonsoft.Json;
using Notepad.Model;
using Notepad.Utilities;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System;
using System.Windows;

namespace Notepad.Services
{
    public class PriorityService
    {
        private static readonly string URL = string.Concat(Properties.Resources.BASE_URL, Properties.Resources.BEARER_AUTHENTICATION_SUFIX, "priorities/");

        public static async Task<Response> GetPriorities()
        {
            string url = string.Concat(URL, "get");
            Response response = new Response();
            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Credentials.ACCESS_TOKEN);
                    var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, new Uri(url));
                    httpRequestMessage.Headers.Add("Origin", Credentials.ORIGIN);
                    HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                    if (httpResponseMessage != null)
                    {
                        string content = await httpResponseMessage.Content.ReadAsStringAsync();
                        response = JsonConvert.DeserializeObject<Response>(content);
                    }
                    else
                    {
                        response.Error = true;
                        response.Code = (int)HttpStatusCode.BadGateway;
                        response.Message = Properties.Resources.NO_WEB_SERVICE_CONNECTION_MESSAGE;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            return response;
        }
    }
}