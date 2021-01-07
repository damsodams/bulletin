using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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
        [JsonProperty("matiere_promotions")]
        public List<Matiere_Promotion> Matiere_Promotions { get; set; }

        [JsonProperty("liste_eleves")]
        public List<Eleve> Eleves { get; set; }

        public Promotion() { }

        public Promotion(int id, string intitule, string date)
        {
            Id = id;
            Intitule = intitule;
            Date = date;
        }
    }
}
