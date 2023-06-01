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
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("cellphoneNumber")]
        public string CellphoneNumber { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("oneTimePassword")]
        public string OneTimePassword { get; set; }

        public override string ToString()
        {
            return string.Concat(Name, " ", PaternalSurname, " ", MaternalSurname);
        }
    }
}