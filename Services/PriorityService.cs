using Newtonsoft.Json;
using Notepad.Model;
using Notepad.Utilities;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System;

namespace Notepad.Services
{
    public class PriorityService
    {
        private static readonly string URL = string.Concat(Properties.Resources.BASE_URL, Properties.Resources.BEARER_AUTHENTICATION_SUFIX, "priorities/");

        public static async Task<Response> GetPriorities()
        {
            string url = string.Concat(URL, "get");
            Response response = new Response();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Credentials.ACCESS_TOKEN);
                try
                {
                    HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);
                    httpRequestMessage.Headers.Add("Origin", Credentials.ORIGIN);
                    HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                    if (httpResponseMessage != null)
                    {
                        if (httpResponseMessage.IsSuccessStatusCode)
                        {
                            string content = await httpResponseMessage.Content.ReadAsStringAsync();
                            response = JsonConvert.DeserializeObject<Response>(content);
                            if (response == null)
                            {
                                response.Error = true;
                                response.Message = Properties.Resources.JSON_DESERIALIZE_ERROR_MESSAGE;
                            }
                        }
                        else
                        {
                            response.Error = true;
                            HttpStatusCode httpStatusCode = httpResponseMessage.StatusCode;
                            response.Code = (int)httpStatusCode;
                            response.Message = httpStatusCode.ToString();
                        }
                    }
                    else
                    {
                        response.Error = true;
                        response.Message = Properties.Resources.NO_WEB_SERVICE_CONNECTION_MESSAGE;
                    }
                }
                catch (Exception exception)
                {
                    response.Error = true;
                    response.Message = exception.Message;
                }
            }
            return response;
        }
    }
}