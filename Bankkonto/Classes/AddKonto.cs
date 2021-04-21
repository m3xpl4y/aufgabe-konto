using System;
using System.Collections.Generic;
using System.Linq;
namespace Bankkonto.Classes
{
    class AddKonto : Konto
    {
        List<Kreditkonto> kreditkontoListe = new List<Kreditkonto>();
        List<Sparbuch> sparbuchliste = new List<Sparbuch>();
        List<Girokonto> girokontoliste = new List<Girokonto>();
        List<Laendlegirokonto> laendlegirokontoliste = new List<Laendlegirokonto>();

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
        public Sparbuch CreateSparbuch()
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
        public Laendlegirokonto CreateLaendlekonto()
        {
            Console.WriteLine("Bitte Fees eingeben:");
            var Fees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Balance eingeben:");
            var Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte Limit eingeben:");
            var Limit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte KontoNummer eingeben:");
            var KontoNummer = Convert.ToInt32(Console.ReadLine());
            Laendlegirokonto laendlegirokonto = new Laendlegirokonto(KontoNummer, Fees, Balance, Limit);
            return laendlegirokonto;
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
                    Console.WriteLine(konto.KontoNummer);
                }
                //break;

                //var firstItem = kreditkontoListe.ElementAt(0);
                //Console.WriteLine(firstItem.KontoNummer);
            }
        }
    }
}
