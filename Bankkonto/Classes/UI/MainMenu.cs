using System;
using System.Collections.Generic;

namespace Bankkonto.Classes.UI
{
    class MainMenu
    {
        String[] mainMenu = { "1. Konto erstellen", "2. Konto abrufen", "3. Beenden" };
        private void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("WILLKOMMEN BEI DER BANK OF");
            Console.WriteLine("**Wir nehmen dein Geld und du bekommst es nicht mehr zurück**");
            Console.WriteLine();
            Console.WriteLine("Wählen Sie wie wir dein Geld nehmen sollen");
            foreach (string menu in mainMenu)
            {
                Console.WriteLine(menu);
            }
        }
        public void PrintMenuFunction(List<Konto> kontoListe)
        {
            PrintMenu();
            int mySelection = Convert.ToInt32(Console.ReadLine());
            CreateAccounts cr = new CreateAccounts();
            CheckAccount ca = new CheckAccount();
            switch (mySelection)
            {
                case 1:
                    Console.Clear();
                    cr.CreateAccountFunction(kontoListe);
                    break;
                case 2:
                    Console.Clear();
                    ca.PrintMenuFunction(kontoListe);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default: break;
            }
        }
    }

}
