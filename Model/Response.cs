using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Notepad.Model
{
    public class Response
    {
        [JsonProperty("error")]
        public bool Error { get; set; }
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("note")]
        public Note Note { get; set; }
        [JsonProperty("notes")]
        public List<Note> Notes { get; set; }
        [JsonProperty("notebook")]
        public Notebook Notebook { get; set; }
        [JsonProperty("notebooks")]
        public List<Notebook> Notebooks { get; set; }
        [JsonProperty("priority")]
        public Priority Priority { get; set; }
        [JsonProperty("priorities")]
        public List<Priority> Priorities { get; set; }
        [JsonProperty("session")]
        public Session Session { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }


        public override string ToString()
        {
            return string.Concat(Code, " - ", Message);
        }
    }
}