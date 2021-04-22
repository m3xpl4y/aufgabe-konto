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
            AddKreditkonto addkonto = new AddKreditkonto();
            addkonto.addKreditKonto();

            //Kreditkonto kk = new Kreditkonto(1234649898, 3.75, -200, 0);
            //Girokonto girokonto1 = new Girokonto(55555666, 2.2, 1500, -250);


            //Console.WriteLine("Wählen Sie den Betrag den Sie abheben möchten");
            //double abhenben = Convert.ToDouble(Console.ReadLine());
            //kk.WithdrawAmount(abhenben);

            //Console.WriteLine("Ihr Balance: " + girokonto1.Balance + " " + girokonto1.KontoNummer);
            //Console.WriteLine("Ihr Balance: " + kk.Balance + " " + kk.KontoNummer);
            //Console.WriteLine("einzahlen");
            //double einzahlen = Convert.ToDouble(Console.ReadLine());
            //kk.DepositAmount(einzahlen);

            //Console.WriteLine("Ihr GiroKonto Kontostand beträgt: " + girokonto1.Balance);
            //Console.WriteLine("Ihr KreditKonto Kontostand beträgt: " + kk.Balance);

            //Console.WriteLine("Ihr GiroKonto Nummer lautet: " + girokonto1.KontoNummer);
            //Console.WriteLine("Ihr KreditKonto Nummer lautet: " + kk.KontoNummer);

        }
    }
}
