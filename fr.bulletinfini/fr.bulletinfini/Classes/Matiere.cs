using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.bulletinfini.Classes
{
    class Matiere
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Type { get; set; }

        public Test(int id, string nom, string type)
        {
            Id = id;
            Nom = nom;
            Type = type;
        }
    }
}
