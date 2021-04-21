using Bankkonto.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddKonto addKonto = new AddKonto();
            //addKonto.addKreditKonto();

            Kreditkonto kk = new Kreditkonto(1234649898, 3.75, -200, -1200);
            Girokonto girokonto1 = new Girokonto(200, -500, 1, 755575);


            Console.WriteLine("Wählen Sie den Betrag den Sie abheben möchten");
            double abhenben = Convert.ToDouble(Console.ReadLine());
            girokonto1.WithdrawAmount(abhenben);

            Console.WriteLine("Ihr Balance: " + girokonto1.Balance + " " + girokonto1.KontoNummer);
            Console.WriteLine("Ihr Balance: " + kk.Balance + " " + kk.KontoNummer);
            Console.WriteLine("einzahlen");
            double einzahlen = Convert.ToDouble(Console.ReadLine());
            girokonto1.DepositAmount(einzahlen);

            Console.WriteLine("Ihr Kontostand beträgt: " + girokonto1.Balance);
            Console.WriteLine("Ihr Kontostand beträgt: " + kk.Balance);

            Console.WriteLine("Ihr Konto Nummer lautet: " + girokonto1.KontoNummer);
            Console.WriteLine("Ihr Konto Nummer lautet: " + kk.KontoNummer);

        }
    }
}
