using Newtonsoft.Json;
using Notepad.Model;
using Notepad.Utilities;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Text;
using System;
using System.Threading.Tasks;

namespace Notepad.Services
{
    public class NoteService
    {
        private static readonly string URL = string.Concat(Properties.Resources.BASE_URL, Properties.Resources.BEARER_AUTHENTICATION_SUFIX, "notes/");

        public static async Task<Response> Delete(Note note)
        {
            string url = string.Concat(URL, "delete");
            Response response = new Response();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Credentials.ACCESS_TOKEN);
                try
                {
                    HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
                    {
                        Content = new StringContent(JsonConvert.SerializeObject(note), Encoding.UTF8, "application/json"),
                        Method = HttpMethod.Delete,
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

        public static async Task<Response> GetNotesByUser(int idUser)
        {
            string url = string.Concat(URL, "get/", idUser);
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

        public static async Task<Response> GetNotesByUser(int idUser, int idNotebook)
        {
            string url = string.Concat(URL, "get/", idUser, "/", idNotebook);
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

        public static async Task<Response> GetNotesByUser(int idUser, int idNotebook, int idPriority)
        {
            string url = string.Concat(URL, "get/", idUser, "/", idNotebook, "/", idPriority);
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

        public static async Task<Response> Log(Note note)
        {
            string url = string.Concat(URL, "log");
            Response response = new Response();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Credentials.ACCESS_TOKEN);
                try
                {
                    HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
                    {
                        Content = new StringContent(JsonConvert.SerializeObject(note), Encoding.UTF8, "application/json"),
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

        public static async Task<Response> Update(Note note)
        {
            string url = string.Concat(URL, "update");
            Response response = new Response();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Credentials.ACCESS_TOKEN);
                try
                {
                    HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
                    {
                        Content = new StringContent(JsonConvert.SerializeObject(note), Encoding.UTF8, "application/json"),
                        Method = HttpMethod.Put,
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