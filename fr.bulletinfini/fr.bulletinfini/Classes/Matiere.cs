using Newtonsoft.Json;
using System.Collections.Generic;

namespace fr.bulletinfini.Classes
{
    public class Matiere
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nom")]
        public string Nom { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("matiere_promotions")]
        public List<Matiere_Promotion> Matiere_promotions { get; set; }
        public Matiere(int id, string nom, string type)
        {
            Id = id;
            Nom = nom;
            Type = type;
        }
    }
}
