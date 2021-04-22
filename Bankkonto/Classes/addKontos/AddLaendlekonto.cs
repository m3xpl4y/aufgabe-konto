using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto.Classes.addKontos
{
    class AddLaendlekonto
    {
        List<Laendlegirokonto> laendlegirokontoliste = new List<Laendlegirokonto>();

        private Laendlegirokonto CreateLaendlekonto()
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

        public void addLaendlekonto()
        {
            while (true)
            {
                laendlegirokontoliste.Add(CreateLaendlekonto()); ;
                int i = laendlegirokontoliste.Count;
                Console.WriteLine(i);
                foreach (var konto in laendlegirokontoliste)
                {
                    Console.WriteLine(konto.KontoNummer);
                }
                break;

                //var firstItem = kreditkontoListe.ElementAt(0);
                //Console.WriteLine(firstItem.KontoNummer);
            }
        }
    }
}
