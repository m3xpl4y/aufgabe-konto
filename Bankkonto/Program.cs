using System;

namespace Bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k = new Konto();
            Sparbuch sk = new Sparbuch(k);
            Girokonto gk = new Girokonto(k);
            gk.KontoNummer = 1000111;
            sk.KontoNummer = 1234567;
            Console.WriteLine("Geld einzahlen!");
            double einzahlen = Convert.ToInt32(Console.ReadLine());
            sk.SavingsDeposit(einzahlen);
            sk.GetSavingsBalance();
            Console.WriteLine("Girokonto Nummer lautet: " + gk.GetKontoNummer(gk));
            Console.WriteLine("Sparbuch Konto Nummer lautet: " + sk.GetKontoNummer(sk));
        }
    }
}
