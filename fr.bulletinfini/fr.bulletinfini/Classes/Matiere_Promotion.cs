﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace fr.bulletinfini.Classes
{
    public class Matiere_Promotion
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("matiere")]
        public Matiere Matiere { get; set; }
        [JsonProperty("promotion")]
        public Promotion Promotion { get; set; }
        public Matiere_Promotion() { }
    }
}