using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.bulletinfini.Classes
{
    class Matiere
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nom")]
        public string Nom { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }

        public Matiere(int id, string nom, string type)
        {
            Id = id;
            Nom = nom;
            Type = type;
        }
    }
}
