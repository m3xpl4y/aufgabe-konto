using System;
using Bankkonto.Classes;
using Bankkonto.Classes.addKontos;
using Bankkonto.Classes.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto.Classes.UI
{
    class CreateAccounts
    {
        AddGirokonto addGirokonto = new AddGirokonto();
        AddSparbuch addSparbuch = new AddSparbuch();
        AddKreditkonto addKreditkonto = new AddKreditkonto();
        AddLaendlekonto addLaendlekonto = new AddLaendlekonto();

        String[] AccountMenu = { "1. Girokonto", "2. Ländlekonto", "3. Sparbuch", "4. Kreditkonto", "5. Zurück" };
        public void CreateAccountMenu()
        {
            Console.WriteLine("KUNDENKONTO ERSTELLEN");
            Console.WriteLine("Bitte aus folgenden Möglichkeiten wählen");
            foreach(string menu in AccountMenu)
            {
                Console.WriteLine(menu);
            }
        }

        public void CreateAccountFunction()
        {
            int mySelection = Convert.ToInt32(Console.ReadLine());

            switch(mySelection)
            {
                case 1: 
                    Console.WriteLine("Girokonto erstellen!");
                    addGirokonto.addGirokonto();
                    break;
                case 2:
                    Console.WriteLine("Ländlekonto erstellen!");
                    addLaendlekonto.addLaendlekonto();
                    break;
                case 3:
                    Console.WriteLine("Sparbuch erstellen!");
                    addSparbuch.addSparbuch();
                    break;
                case 4:
                    Console.WriteLine("Kreditkonto erstellen!");
                    addKreditkonto.addKreditKonto();
                    break;
                case 5:
                    Console.WriteLine("Hier kommt Menu schritt zurück");
                    break;
                default: Console.WriteLine("Gibt doch das was da stehen ein");
                    break;
            }
        }
    }
}
