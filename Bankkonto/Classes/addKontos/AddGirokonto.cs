using System;
using System.Collections.Generic;
using System.Linq;

namespace Bankkonto.Classes.addKontos
{
    class AddGirokonto
    {
        List<Girokonto> girokontoliste = new List<Girokonto>();

        public Girokonto CreateGirokonto()
        {
            Console.WriteLine("Bitte Fees eingeben:");
            var Fees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Balance eingeben:");
            var Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte Limit eingeben:");
            var Limit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte KontoNummer eingeben:");
            var KontoNummer = Convert.ToInt32(Console.ReadLine());
            Girokonto girokonto = new Girokonto(KontoNummer, Fees, Balance, Limit);
            return girokonto;
        }
        public void addGirokonto()
        {
            while (true)
            {
                girokontoliste.Add(CreateGirokonto()); ;
                int i = girokontoliste.Count;
                Console.WriteLine(i);
                foreach (var konto in girokontoliste)
                {
                    Console.WriteLine("GiroKonto: " + konto.KontoNummer);
                }
                //break;

                //var firstItem = kreditkontoListe.ElementAt(0);
                //Console.WriteLine(firstItem.KontoNummer);
            }
        }
    }
}
