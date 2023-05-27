using Newtonsoft.Json;

namespace Notepad.Model
{
    public class Priority
    {
        [JsonProperty("idPriority")]
        public int IdPriority { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}