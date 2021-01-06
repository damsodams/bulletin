using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.bulletinfini.Classes
{
    public class Eleve
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nom")]
        public String nom { get; set; }

        [JsonProperty("prenom")]
        public String prenom { get; set; }

        [JsonProperty("promotion_etudiant")]
        public Promotion Promotion { get; set; }

        [JsonProperty("notes_etudiant")]
        public List<Note> Notes { get; set; }
        public Eleve() { }

    }
}
