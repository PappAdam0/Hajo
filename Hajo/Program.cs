using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hajo
{
    class Program
    {
        /*Hány hajó van?
         * Melyik hajók a legdrágábbak?
         * Nevsorban a hajók neve "hajok.txt"be
         * Melyik hajóból (tipus) van a legtöbb*/
        static List<Hajo> hajok = new List<Hajo>();
        static List<string> nevek = new List<string>();
        static void beolvas()
        {
            StreamReader olvas = new StreamReader("hajo.csv");
            while (!olvas.EndOfStream)
            {
                //string[] sor = olvas.ReadLine().Split(';');
                hajok.Add(new Hajo(olvas.ReadLine()));
            }
            olvas.Close();
        }
        static void HajokSzama()
        {
            Console.WriteLine("Hajók száma: {0}", hajok.Count);
        }
        static void Legdragabb()
        {
            int max = 0;
            string nev = "";
            foreach (var i in hajok)
            {
                if (i.Dij > max)
                {
                    max = i.Dij;
                    nev = i.Nev;
                }
            }
            Console.Write("{0} {1}", nev, max);
        }
        static void Nevsor()
        {
            foreach (var i in hajok)
            {
                nevek.Add(i.Nev);
                nevek.Sort();
            }
            StreamWriter iro = new StreamWriter("hajok.txt");
            foreach (var u in nevek)
            {
                iro.WriteLine(u);
            }
            iro.Close();
        }
        static void LegtobbHajo()
        {

        }
        static void Main(string[] args)
        {
            var h = new Hajo("7;Durbincs;WIN-22;5;24000");
            //Console.Write(h.Nev + " " + h.Tipus);
            beolvas();
            HajokSzama();
            Legdragabb();
            Nevsor();
            LegtobbHajo();
            Console.ReadKey();
        }
    }
}