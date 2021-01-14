using Newtonsoft.Json;
using System.Collections.Generic;

namespace fr.bulletinfini.Classes
{
    public class Note
    {

        public string Coefficient { get; set; }

        [JsonProperty("note")]
        public float NoteEleve { get; set; }

        [JsonProperty("matiere")]
        public Matiere Matiere { get; set; }

        [JsonProperty("eleve")]
        public Eleve Eleve { get; set; }
        public Note() { }
    }

}
