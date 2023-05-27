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

        public static async Task<Response> Activate(User user)
        {
            string url = string.Concat(URL, "activate");
            Response response = new Response();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
                try
                {
                    HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
                    {
                        Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"),
                        Method = HttpMethod.Post,
                        RequestUri = new Uri(url)
                    };
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

        public static async Task<Response> Login(User user)
        {
            string url = string.Concat(URL, "login");
            Response response = new Response();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
                try
                {
                    HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
                    {
                        Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"),
                        Method = HttpMethod.Post,
                        RequestUri = new Uri(url)
                    };
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

        public static async Task<Response> SignUp(User user)
        {
            string url = string.Concat(URL, "login");
            Response response = new Response();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
                try
                {
                    HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
                    {
                        Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"),
                        Method = HttpMethod.Post,
                        RequestUri = new Uri(url)
                    };
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