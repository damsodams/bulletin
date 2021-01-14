using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace fr.bulletinfini.Classes
{
    public class Eleve
    {

        [JsonProperty("nom")]
        public String Nom { get; set; }

        [JsonProperty("prenom")]
        public String Prenom { get; set; }

        [JsonProperty("promotion_etudiant")]
        public Promotion Promotion { get; set; }

        [JsonProperty("notes_etudiant")]
        public List<Note> Notes { get; set; }
        public Eleve() {
            this.Notes = new List<Note>();
        }

        public Eleve( string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
    }
}
