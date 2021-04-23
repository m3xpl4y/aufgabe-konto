using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto.Classes.UI
{
    class MainMenu
    {
        CreateAccounts cr = new CreateAccounts();
        DepositWithdraw dw = new DepositWithdraw();


        String[] mainMenu = { "1. Konto erstellen", "2. Konto abrufen", "3. Beenden"};
        
        public void Menu()
        {
            Console.WriteLine("WILLKOMMEN BEI DER BANK OF 'Wir nehmen dein Geld und du bekommst es nicht mehr'");
            Console.WriteLine("Wähle wie wir dein Geld nehmen sollen");
            foreach (string menu in mainMenu)
            {
                Console.WriteLine(menu);
            }
        }
    }

}
