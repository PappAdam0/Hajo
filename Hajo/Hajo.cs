using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hajo
{
    class Hajo
    {
        public int Regiszter { get; private set; }
        public string Nev { get; private set; }
        public string Tipus { get; private set; }
        public int Utas { get; private set; }
        public int Dij { get; private set; }
        public Hajo(string sor)
        {
            //"7;Durbincs;WIN-22;5;24000"
            string[] adat = sor.Split(';');
            Regiszter = int.Parse(adat[0]);
            Nev = adat[1];
            Tipus = adat[2];
            Utas = int.Parse(adat[3]);
            Dij = int.Parse(adat[4]);
        }
    }
}