using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto.Classes.UI
{
    class CreateAccounts
    {            
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
        String[] EinAuszahlungsMenu = { "1. Einzahlen", "2. Auszahlen", "3. Zurück" };
        public void EinAusWahlMenu()
        {

            Console.WriteLine("BETRAG EINZAHLEN ODER ABHEBEN");
            Console.WriteLine("Bitte aus folgenden Möglichkeiten wählen");
            foreach (string menu in EinAuszahlungsMenu)
            {
                
                Console.WriteLine(menu);
            }
        }

    }
}
