using System;
using System.Collections.Generic;
using System.Linq;

namespace Bankkonto.Classes.addKontos
{
    class AddSparbuch
    {
        List<Sparbuch> sparbuchliste = new List<Sparbuch>();

        private Sparbuch CreateSparbuch()
        {
            Console.WriteLine("Bitte Fees eingeben:");
            var Fees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Balance eingeben:");
            var Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte Limit eingeben:");
            var Limit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte KontoNummer eingeben:");
            var KontoNummer = Convert.ToInt32(Console.ReadLine());
            Sparbuch sparbuch = new Sparbuch(KontoNummer, Fees, Balance, Limit);
            return sparbuch;
        }

        public void addSparbuch()
        {
            while (true)
            {
                sparbuchliste.Add(CreateSparbuch()); ;
                int i = sparbuchliste.Count;
                Console.WriteLine(i);
                foreach (var konto in sparbuchliste)
                {
                    Console.WriteLine(konto.KontoNummer);
                }
                //break;

                //var firstItem = kreditkontoListe.ElementAt(0);
                //Console.WriteLine(firstItem.KontoNummer);
            }
        }
    }
}
