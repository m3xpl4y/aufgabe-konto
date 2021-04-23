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
    class MainMenu
    {
        CreateAccounts cr = new CreateAccounts();
        DepositWithdraw dw = new DepositWithdraw();


        String[] mainMenu = { "1. Konto erstellen", "2. Konto abrufen", "3. Beenden" };

        private void PrintMenu()
        {
            Console.WriteLine("WILLKOMMEN BEI DER BANK OF 'Wir nehmen dein Geld und du bekommst es nicht mehr zurück");
            Console.WriteLine("Wähle wie wir dein Geld nehmen sollen");
            foreach (string menu in mainMenu)
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
                    cr.CreateAccountFunction();
                    break;
                case 2:
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default: break;
            }
        }
    }

}
