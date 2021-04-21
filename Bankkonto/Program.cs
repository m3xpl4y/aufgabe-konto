using Bankkonto.Classes;
using System;

namespace Bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {
            Kreditkonto kk = new Kreditkonto(3.75, -200, -1200);
            kk.KontoNummer = 1234649898;
            Kreditkonto kk2 = new Kreditkonto(2.75, 200, -2000);
            kk2.KontoNummer = 123456780;

            Console.WriteLine("Wählen Sie den Betrag den Sie abheben möchten");
            double abhenben = Convert.ToDouble(Console.ReadLine());
            kk.WithdrawAmount(abhenben);

            Console.WriteLine("Ihr Balance: " + kk.Balance);
            Console.WriteLine("einzahlen");
            double einzahlen = Convert.ToDouble(Console.ReadLine());
            kk.DepositAmount(einzahlen);
            Console.WriteLine("Ihr Kontostand beträgt: " + kk.Balance);

            Console.WriteLine("Ihr Konto Nummer lautet: " + kk.KontoNummer);
            Console.WriteLine("Ihr Konto Nummer lautet: " + kk2.KontoNummer);

        }
    }
}
