using Newtonsoft.Json;
using System;

namespace Notepad.Model
{
    public class User
    {
        [JsonProperty("idUser")]
        public int IdUser { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("paternalSurname")]
        public string PaternalSurname { get; set; }
        [JsonProperty("maternalSurname")]
        public string MaternalSurname { get; set; }
        [JsonProperty("registrationDate")]
        public DateTime RegistrationDate { get; set; }
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("cellphoneNumber")]
        public string CellphoneNumber { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("lastAccessToken")]
        public string LastAccessToken { get; set; }
        [JsonProperty("lastAccessDate")]
        public DateTime LastAccessDate { get; set; }
        [JsonProperty("oneTimePassword")]
        public string OneTimePassword { get; set; }
        [JsonProperty("activationDate")]
        public DateTime ActivationDate { get; set; }
    }
}