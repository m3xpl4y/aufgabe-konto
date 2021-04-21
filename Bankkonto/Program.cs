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


            Console.WriteLine("Wählen Sie den Betrag den Sie abheben möchten");
            double abhenben = Convert.ToDouble(Console.ReadLine());
            kk.WithdrawAmount(abhenben);

            Console.WriteLine("Ihr Balance: " + kk.Balance);

        }
    }
}
