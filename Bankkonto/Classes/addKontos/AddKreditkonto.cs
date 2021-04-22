using System;
using System.Collections.Generic;
using System.Linq;
namespace Bankkonto.Classes
{
    class AddKreditkonto : Konto
    {
        List<Kreditkonto> kreditkontoListe = new List<Kreditkonto>();


        //INPUT FUNCTIONS
        public Kreditkonto CreateKreditKonto()
        {
            Console.WriteLine("Bitte Fees eingeben:");
            var Fees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Balance eingeben:");
            var Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte Limit eingeben:");
            var Limit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte KontoNummer eingeben:" );
            var KontoNummer = Convert.ToInt32(Console.ReadLine());
            Kreditkonto kreditkonto = new Kreditkonto(KontoNummer, Fees, Balance, Limit);
            return kreditkonto;
        }

        public void addKreditKonto()
        {
            while (true)
            {
                kreditkontoListe.Add(CreateKreditKonto()); ;
                int i = kreditkontoListe.Count;
                Console.WriteLine(i);
                foreach(var konto in kreditkontoListe)
                {
                    Console.WriteLine("KreditKonto: " + konto.KontoNummer);
                }
                //break;

                //var firstItem = kreditkontoListe.ElementAt(0);
                //Console.WriteLine(firstItem.KontoNummer);
            }
        }
    }
}
