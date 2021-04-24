using System;
using System.Collections.Generic;
using Bankkonto.Classes.addKontos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto.Classes.UI
{
    class DepositWithdraw
    {
        String[] EinAuszahlungsMenu = { "1. Einzahlen", "2. Auszahlen", "3. Zurück" };
        private void PrintMenu()
        {
            Console.WriteLine("BETRAG EINZAHLEN ODER ABHEBEN");
            Console.WriteLine("Bitte aus folgenden Möglichkeiten wählen");
            foreach (string menu in EinAuszahlungsMenu)
            {

                Console.WriteLine(menu);
            }
        }
        public void PrintMenuFunction(List<Konto> kontoListe)
        {
            PrintMenu();
            double amount = 0;
            int mySelection = Convert.ToInt32(Console.ReadLine());
            AddKonto ad = new AddKonto();
            MainMenu mm = new MainMenu();
            switch (mySelection)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Bitte aus folgenden Kontopositionen, eine auswählen");
                    ad.GetKontoListe(kontoListe);
                    Console.WriteLine("Position wählen");
                    int pos = Convert.ToInt32(Console.ReadLine());
                    var selectedKonto = kontoListe.ElementAt(pos);
                    var KontoNummer = selectedKonto.KontoNummer;
                    var Fees = selectedKonto.Fees;
                    var Limit = selectedKonto.Limit;
                    var Balance = selectedKonto.Balance;
                    Console.WriteLine("Das ausgewählte Konto ist " + KontoNummer + " Balance: " + Balance);
                    Console.WriteLine("Betrag zum Einzahlen eingeben: ");
                    if (amount < 0)
                    {
                        Console.WriteLine("Flascher Betrag eingeben");
                    }
                    else
                    {
                        amount = Convert.ToDouble(Console.ReadLine());
                    }
                    Balance = kontoListe.ElementAt(pos).DepositAmount(amount);
                    Console.WriteLine("neue Balance: " + Balance);
                    Console.WriteLine("Zum Fortfahren beliebige Taste drücken");
                    Console.ReadLine();
                    Console.Clear();
                    mm.PrintMenuFunction(kontoListe);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Bitte aus folgenden Kontopositionen, eine auswählen");
                    ad.GetKontoListe(kontoListe);
                    Console.WriteLine("Position wählen");
                    int posWithdraw = Convert.ToInt32(Console.ReadLine());
                    var selectedWithdrawAcc = kontoListe.ElementAt(posWithdraw);
                    var KontoNummerWithdraw = selectedWithdrawAcc.KontoNummer;
                    var FeesWithdraw = selectedWithdrawAcc.Fees;
                    var LimitWithdraw = selectedWithdrawAcc.Limit;
                    var BalanceWithdraw = selectedWithdrawAcc.Balance;
                    Console.WriteLine("Das ausgewählte Konto ist " + KontoNummerWithdraw + " Balance: " + BalanceWithdraw);
                    Console.WriteLine("Betrag zum Einzahlen eingeben: ");
                    if (amount < 0)
                    {
                        Console.WriteLine("Flascher Betrag eingeben");
                    }
                    else
                    {
                        amount = Convert.ToDouble(Console.ReadLine());
                    }
                    BalanceWithdraw = kontoListe.ElementAt(posWithdraw).WithdrawAmount(amount);
                    Console.WriteLine("neue Balance: " + BalanceWithdraw);
                    Console.WriteLine("Zum Fortfahren beliebige Taste drücken");
                    Console.ReadLine();
                    Console.Clear();
                    mm.PrintMenuFunction(kontoListe);
                    break;
                case 3:
                    Console.Clear();
                    mm.PrintMenuFunction(kontoListe);
                    break;
                default: 
                    break;
            }
        }
    }
}
