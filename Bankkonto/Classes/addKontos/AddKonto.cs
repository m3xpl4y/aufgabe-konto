using Bankkonto.Classes.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto.Classes.addKontos
{
    class AddKonto
    {
        private double Fees;
        private double Balance;
        private double Limit;
        private int KontoNummer;

        private void AddParameters()
        {
            Console.WriteLine("Bitte Fees eingeben:");
            Fees = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte Balance eingeben:");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte Limit eingeben:");
            Limit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte KontoNummer eingeben:");
            KontoNummer = Convert.ToInt32(Console.ReadLine());
        }

        public List<Konto> GetKontoListe(List<Konto> kontoListe)
        {
            int i = kontoListe.Count;
            Console.WriteLine("Anzahl Kontos: " + i);
            int count = 0;
            foreach (var konto in kontoListe)
            {
                Console.Write("Position: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(count);
                Console.ResetColor();
                Console.WriteLine(" Kontonummer: " + konto.KontoNummer);
                count++;
            }
            return kontoListe;
        }

        public void addGirokonto(List<Konto> kontoListe)
        {
            AddParameters();
            Konto girokonto = new Girokonto(KontoNummer, Fees, Balance, Limit);
                kontoListe.Add(girokonto);
        }
        public void addSparbuch(List<Konto> kontoListe)
        {
            AddParameters();
            Konto sparbuch = new Sparbuch(KontoNummer, Fees, Balance, Limit);
                kontoListe.Add(sparbuch);
        }
        public void addLaendlekonto(List<Konto> kontoListe)
        {
            AddParameters();
            Konto laendlekonto = new Laendlegirokonto(KontoNummer, Fees, Balance, Limit);
                kontoListe.Add(laendlekonto);
        }
        public void addKreditkonto(List<Konto> kontoListe)
        {
            AddParameters();
            Konto kreditkonto = new Kreditkonto(KontoNummer, Fees, Balance, Limit);
                kontoListe.Add(kreditkonto);
        }
    }
}
