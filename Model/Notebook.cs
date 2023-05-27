using Newtonsoft.Json;

namespace Notepad.Model
{
    public class Notebook
    {
        [JsonProperty("idNotebook")]
        public int IdNotebook { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("hexadecimalColor")]
        public string HexadecimalColor { get; set; }
        [JsonProperty("idUser")]
        public int IdUser { get; set; }
    }
}