using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT.Models
{
    class Tuote
    {
        public int Id { get; set; }
        public string Nimi { get; set; }
        public string Kuvaus { get; set; }
        public double Hita { get; set; }
        public Tuotetyypit Tyyppi { get; set; }
        public int TuottajaId { get; set; }

        
        public string TuottajaNimi { get; set; }

        public Tuote()
        {

        }
    }
}
