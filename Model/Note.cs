using Newtonsoft.Json;
using System;

namespace Notepad.Model
{
    public class Note
    {
        [JsonProperty("idNote")]
        public int IdNote { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("content")]
        public string Content { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
        [JsonProperty("idNotebook")]
        public int IdNotebook { get; set; }
        [JsonProperty("idPriority")]
        public int IdPriority { get; set; }
        [JsonProperty("idUser")]
        public int IdUser { get; set; }
    }
}