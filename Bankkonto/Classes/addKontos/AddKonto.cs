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

        List<Konto> kontos = new List<Konto>();

        private void AddParameters()
        {
            Console.WriteLine("Bitte Fees eingeben:");
            Fees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Balance eingeben:");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte Limit eingeben:");
            Limit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte KontoNummer eingeben:");
            KontoNummer = Convert.ToInt32(Console.ReadLine());
        }

        public void addGirokonto()
        {
            AddParameters();
            Konto girokonto = new Girokonto(KontoNummer, Fees, Balance, Limit);
            while (true)
            {
                kontos.Add(girokonto); ;
                int i = kontos.Count;
                Console.WriteLine(i);
                foreach (var konto in kontos)
                {
                    Console.WriteLine("GiroKonto: " + konto.KontoNummer);
                }
                break;
            }
        }
        public void addSparbuch()
        {
            AddParameters();
            Konto sparbuch = new Sparbuch(KontoNummer, Fees, Balance, Limit);
            while (true)
            {
                kontos.Add(sparbuch); ;
                int i = kontos.Count;
                Console.WriteLine(i);
                foreach (var konto in kontos)
                {
                    Console.WriteLine("Sparbuch: " + konto.KontoNummer);
                }
                break;
            }
        }
        public void addLaendlekonto()
        {
            AddParameters();
            Konto laendlekonto = new Laendlegirokonto(KontoNummer, Fees, Balance, Limit);
            while (true)
            {
                kontos.Add(laendlekonto); ;
                int i = kontos.Count;
                Console.WriteLine(i);
                foreach (var konto in kontos)
                {
                    Console.WriteLine("Ländlegirokonto: " + konto.KontoNummer);
                }
                break;
            }
        }
        public void addKreditkonto()
        {
            AddParameters();
            Konto kreditkonto = new Kreditkonto(KontoNummer, Fees, Balance, Limit);
            while (true)
            {
                kontos.Add(kreditkonto); ;
                int i = kontos.Count;
                Console.WriteLine(i);
                foreach (var konto in kontos)
                {
                    Console.WriteLine("Ländlegirokonto: " + konto.KontoNummer);
                }
                break;
            }
        }
    }
}
