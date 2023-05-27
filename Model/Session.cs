using Newtonsoft.Json;

namespace Notepad.Model
{
    public class Session
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("paternalSurname")]
        public string PaternalSurname { get; set; }
        [JsonProperty("maternalSurname")]
        public string MaternalSurname { get; set; }
    }
}