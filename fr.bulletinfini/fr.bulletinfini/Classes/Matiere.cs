using Newtonsoft.Json;
using System.Collections.Generic;

namespace fr.bulletinfini.Classes
{
    public class Matiere
    {

        public string Nom { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("promotion")]
        public Promotion Promotion{ get; set; }
        [JsonProperty("list_notes")]
        public List<Note> Notes { get; set; }
        public Matiere() {
            this.Notes = new List<Note>();
        }
        public Matiere(string nom, string type)
        {
            Nom = nom;
            Type = type;
        }
    }
}
