using Notepad.Model;
using Notepad.Utilities;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Headers;
using System.Net;
using System.Windows;
using System.Collections.Generic;

namespace Notepad.Services
{
    public class AccessService
    {
        private static readonly string URL = string.Concat(Properties.Resources.BASE_URL, Properties.Resources.BASIC_AUTHENTICATION_SUFIX);
        private static readonly string CREDENTIALS = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Credentials.USERNAME}:{Credentials.PASSWORD}"));

        public static async Task<Response> Activate(User user)
        {
            string url = string.Concat(URL, "activate");
            Response response = new Response();
            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", CREDENTIALS);
                    var httpRequestMessage = new HttpRequestMessage()
                    {
                        Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"),
                        Method = HttpMethod.Post,
                        RequestUri = new Uri(url)
                    };
                    httpRequestMessage.Headers.Add("Origin", Credentials.ORIGIN);
                    HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                    if (httpResponseMessage != null)
                    {
                        string content = await httpResponseMessage.Content.ReadAsStringAsync();
                        response = JsonConvert.DeserializeObject<Response>(content);
                    }
                }
                catch (Exception)
                {
                    response.Error = true;
                    response.Code = (int)HttpStatusCode.BadGateway;
                    response.Message = Properties.Resources.NO_WEB_SERVICE_CONNECTION_MESSAGE;
                }
            }
            return response;
        }

        public static async Task<Response> Login(User user)
        {
            string url = string.Concat(URL, "login");
            Response response = new Response();
            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", CREDENTIALS);
                    var httpRequestMessage = new HttpRequestMessage()
                    {
                        Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"),
                        Method = HttpMethod.Post,
                        RequestUri = new Uri(url)
                    };
                    httpRequestMessage.Headers.Add("Origin", Credentials.ORIGIN);
                    HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                    if (httpResponseMessage != null)
                    {
                        string content = await httpResponseMessage.Content.ReadAsStringAsync();
                        response = JsonConvert.DeserializeObject<Response>(content);
                    }
                }
                catch (Exception)
                {
                    response.Error = true;
                    response.Code = (int)HttpStatusCode.BadGateway;
                    response.Message = Properties.Resources.NO_WEB_SERVICE_CONNECTION_MESSAGE;
                }
            }
            return response;
        }

        public static async Task<Response> SignUp(User user)
        {
            string url = string.Concat(URL, "signup");
            Response response = new Response();
            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", CREDENTIALS);
                    var httpRequestMessage = new HttpRequestMessage()
                    {
                        Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"),
                        Method = HttpMethod.Post,
                        RequestUri = new Uri(url)
                    };
                    httpRequestMessage.Headers.Add("Origin", Credentials.ORIGIN);
                    HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                    if (httpResponseMessage != null)
                    {
                        string content = await httpResponseMessage.Content.ReadAsStringAsync();
                        response = JsonConvert.DeserializeObject<Response>(content);
                    }
                }
                catch (Exception)
                {
                    response.Error = true;
                    response.Code = (int)HttpStatusCode.BadGateway;
                    response.Message = Properties.Resources.NO_WEB_SERVICE_CONNECTION_MESSAGE;
                }
            }
            return response;
        }
    }
}