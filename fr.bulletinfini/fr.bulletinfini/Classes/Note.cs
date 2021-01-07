using Newtonsoft.Json;
using System.Collections.Generic;

namespace fr.bulletinfini.Classes
{
    public class Note
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("coefficient")]
        public string Coefficient { get; set; }

        [JsonProperty("note")]
        public float NoteEleve { get; set; }

        [JsonProperty("liste_matiere")]
        public List<Matiere> Matieres { get; set; }

        [JsonProperty("liste_promotion")]
        public List<Promotion> Promotions { get; set; }
        [JsonProperty("eleve")]
        public Eleve Eleve { get; set; }
        public Note() { }
    }

}
