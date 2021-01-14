using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace fr.bulletinfini.Classes
{
    public class Promotion
    {

        [JsonProperty("intitule")]
        public String Intitule { get; set; }

        [JsonProperty("date")]
        public String Date { get; set; }
        [JsonProperty("matiere_promotions")]
        public List<Matiere> Matieres { get; set; }

        [JsonProperty("liste_eleves")]
        public List<Eleve> Eleves { get; set; }


        public Promotion() {
            this.Eleves = new List<Eleve>();
            this.Matieres = new List<Matiere>();
        }
        public Boolean write()
        {
            return true;
        }
    }
}
