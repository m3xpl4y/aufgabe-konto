using System;
namespace Bankkonto.Classes
{
    class AddKonto
    {
        public void CreateKreditKonto(Kreditkonto name)
        {
            System.Console.WriteLine("Bitte KontoNummer eingeben:" );
            var KontoNummer = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Bitte Balance eingeben:");
            var Balance = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Bitte Limit eingeben:");
            var Limit = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Bitte Fees eingeben:");
            var Fees = Convert.ToInt32(Console.ReadLine());
            var konto = new Kreditkonto(KontoNummer, Balance, Limit, Fees);
        }
    }
}
