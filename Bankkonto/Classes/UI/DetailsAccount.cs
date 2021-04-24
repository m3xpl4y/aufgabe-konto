using Bankkonto.Classes.addKontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto.Classes.UI
{
    class DetailsAccount
    {
        AddKonto ad = new AddKonto();
        
        public void GetKontoNumber(List<Konto> kontoListe)
        {
            Console.WriteLine("Gespeicherte Kontos");
            ad.GetKontoListe(kontoListe);
            CheckAccount(kontoListe);

        }
        private void CheckAccount(List<Konto> kontoListe)
        {
            Console.WriteLine("Kontopostition wählen");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            var selectedKonto = kontoListe.ElementAt(pos);
            var KontoNummer = selectedKonto.KontoNummer;
            var Fees = selectedKonto.Fees;
            var Limit = selectedKonto.Limit;
            var Balance = selectedKonto.Balance;
            var available = Balance - (Limit);
            Console.WriteLine("Folgende Informationen stehen zur Verfügung: \n" +
                "Kontonummer: " + KontoNummer + "\n" +
                "Zinsen: " + Fees + "\n" +
                "Überziehungsrahmen: " + Limit + "\n" +
                "Guthaben: " + Balance + "\n" +
                "Verfügbar: " + available);
            Console.WriteLine("Zum Fortfahren beliebige Taste drücken");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
