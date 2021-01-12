using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace fr.bulletinfini.Classes
{
    public class Eleve
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nom")]
        public String Nom { get; set; }

        [JsonProperty("prenom")]
        public String Prenom { get; set; }

        [JsonProperty("promotion_etudiant")]
        public Promotion Promotion { get; set; }

        [JsonProperty("notes_etudiant")]
        public List<Note> Notes { get; set; }
        public Eleve() { }

        public Eleve(int id, string nom, string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }
    }
}
