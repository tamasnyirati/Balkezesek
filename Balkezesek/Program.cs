using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class Program
    {
        public Program()
        {
            programIndito();
        }

        private void programIndito()
        {
            string[] adatok = File.ReadAllLines("balkezesek.csv");
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (string sor in adatok.Skip(1))
            {
                Versenyzo versenyzo = new Versenyzo(sor);
                versenyzok.Add(versenyzo);
            }

            //1. feladat
            int N = versenyzok.Count;
            Console.WriteLine($"1. feladat: versenyzők száma: {N}");

            //2. feladat
            List<Versenyzo> elsoPalyaraLepes1980 = new List<Versenyzo>();
            for (int i = 1; i < N; i++)
            {
                if (versenyzok[i].elso.Contains("1980-"))
                {
                    elsoPalyaraLepes1980.Add(versenyzok[i]);
                }
            }
            int M = elsoPalyaraLepes1980.Count;
            Console.WriteLine("2. feladat: 1980-ban először pályára lépett játékosok: ");
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine($"\t{elsoPalyaraLepes1980[i].nev}");
            }

            //3. feladat
            Console.WriteLine();
            Console.Write("Kérek egy nevet: ");
            string felhBeker = Console.ReadLine();

            for (int i = 0; i < M; i++)
            {

            if(felhBeker == elsoPalyaraLepes1980[i].nev)
                {
                    Console.WriteLine($"{elsoPalyaraLepes1980[i].nev} magassága: {elsoPalyaraLepes1980[i].magassag*2,54:N1} cm");
                }
            }

            //4. feladat
            int minEvszam = 1900;
            int maxEvszam = 1999;
            int evszamBeker;
            bool igaz = false;
            do
            {
                Console.Write("Kérek egy évszámot 1900 és 1999 között: ");
                evszamBeker = int.Parse(Console.ReadLine());
                igaz = evszamBeker >= minEvszam && evszamBeker <= maxEvszam;
            } while (!igaz);
            List<Versenyzo> valasztottEvbenEloszorPalyaraLepok = new List<Versenyzo>();
            for (int i = 0; i < N; i++)
            {
                if (versenyzok[i].elso.Contains(Convert.ToString(evszamBeker)) )
                {
                    valasztottEvbenEloszorPalyaraLepok.Add(versenyzok[i]);
                }
            }

            foreach (Versenyzo item in valasztottEvbenEloszorPalyaraLepok)
            {
                Console.WriteLine(item.nev);
                Console.WriteLine(item.elso);
                Console.WriteLine(item.utolso);
                Console.WriteLine(item.suly);
                Console.WriteLine(item.magassag);
                Console.WriteLine();
            }
        }//progind

        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
    }
}
