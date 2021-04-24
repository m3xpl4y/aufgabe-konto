using System;
using System.Collections.Generic;
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
        public void PrintMenuFunction()
        {
            PrintMenu();
            int mySelection = Convert.ToInt32(Console.ReadLine());

            switch (mySelection)
            {
                case 1:
                    Console.Clear();
                    
                    break;
                case 2:
                    break;
                case 3:
                    Console.Clear();
                    MainMenu mm = new MainMenu();
                    mm.PrintMenuFunction();
                    break;
                default: 
                    break;
            }
        }
    }
}
