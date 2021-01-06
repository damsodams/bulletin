using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.bulletinfini.Classes
{
    public class Note
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("coefficient")]
        public string Coefficient { get; set; }

        [JsonProperty("liste_matiere")]
        public List<Matiere> Matieres { get; set; }

        [JsonProperty("liste_promotion")]
        public List<Promotion> Promotions { get; set; }
        [JsonProperty("eleve")]
        public Eleve Eleve { get; set; }
        public Note(){ }
    }
    
}
