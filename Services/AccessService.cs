using Notepad.Model;
using Notepad.Utilities;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Headers;
using System.Net;

namespace Notepad.Services
{
    public class AccessService
    {
        private static readonly string URL = string.Concat(Properties.Resources.BASE_URL, Properties.Resources.BASIC_AUTHENTICATION_SUFIX);
        private static string credentials;

        AccessService()
        {
            string username = Credentials.USERNAME;
            string password = Credentials.PASSWORD;
            credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
        }

        public static async Task<Response> Activate(string cellphoneNumber, string oneTimePassword)
        {
            string url = string.Concat(URL, "activate");
            Response response = new Response();
            using (var httpClient = new HttpClient())
            {
                HttpRequestMessage httpRequestMessage;
                HttpResponseMessage httpResponseMessage;
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
                    var user = new User()
                    {
                        CellphoneNumber = cellphoneNumber,
                        OneTimePassword = oneTimePassword
                    };
                    string json = JsonConvert.SerializeObject(user);
                    StringContent body = new StringContent(json, Encoding.UTF8, "application/json");
                    httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, url);
                    httpRequestMessage.Headers.Add("Origin", Credentials.ORIGIN);
                    httpResponseMessage = await httpClient.PostAsync(url, body);
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
                            HttpStatusCode httpStatusCode = httpResponseMessage.StatusCode;
                            response.Code = (int)httpStatusCode;
                            response.Error = true;
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