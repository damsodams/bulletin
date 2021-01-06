using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.bulletinfini.Classes
{
    public class Promotion
    {
        public int id { get; set; }
        public String intitule { get; set; }
        public DateTime date { get; set; }

        public List<Eleve> eleves { get; set; }
    }
}
