using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.bulletinfini.Classes
{
    public class Promotion
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("intitule")]
        public String Intitule { get; set; }

        [JsonProperty("date")]
        public String Date { get; set; }

        [JsonProperty("liste_eleve")]
        public List<Eleve> Eleve { get; set; }
    }
}
