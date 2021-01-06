using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.bulletinfini.Classes
{
    class Note
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("coefficient")]
        public string Coefficient { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("liste_matiere")]
        public List<Matiere> Matiere { get; set; }

        [JsonProperty("liste_promotion")]
        public List<Promotion> Promotion { get; set; }
        public Note()
        {

        }
    }
    
}
