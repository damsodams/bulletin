using Newtonsoft.Json;

namespace fr.bulletinfini.Classes
{
    public class Matiere_Promotion
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("matiere")]
        public Matiere Matiere { get; set; }

        [JsonProperty("promotion")]
        public Promotion Promotion { get; set; }
        public Matiere_Promotion() { }
    }
}
