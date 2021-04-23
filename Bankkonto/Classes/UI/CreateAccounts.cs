using Bankkonto.Classes.addKontos;
using System;

namespace Bankkonto.Classes.UI
{
    class CreateAccounts
    {
        String[] AccountMenu = { "1. Girokonto", "2. Ländlekonto", "3. Sparbuch", "4. Kreditkonto", "5. Zurück" };
        AddKonto addKonto = new AddKonto();
        private void CreateAccountMenu()
        {
            Console.WriteLine("KUNDENKONTO ERSTELLEN");
            Console.WriteLine("Bitte aus folgenden Möglichkeiten wählen");
            foreach (string menu in AccountMenu)
            {
                Console.WriteLine(menu);
            }
        }

        public void CreateAccountFunction()
        {
            CreateAccountMenu();
            int mySelection = Convert.ToInt32(Console.ReadLine());

            switch (mySelection)
            {
                case 1:
                    Console.WriteLine("Girokonto erstellen!");
                    addKonto.addGirokonto();
                    break;
                case 2:
                    Console.WriteLine("Ländlekonto erstellen!");
                    addKonto.addLaendlekonto();
                    break;
                case 3:
                    Console.WriteLine("Sparbuch erstellen!");
                    addKonto.addSparbuch();
                    break;
                case 4:
                    Console.WriteLine("Kreditkonto erstellen!");
                    addKonto.addKreditkonto();
                    break;
                case 5:
                    Console.Clear();
                    MainMenu mm = new MainMenu();
                    mm.PrintMenuFunction();
                    break;
                default:
                    Console.WriteLine("Gibt doch das was da stehen ein");
                    break;
            }
        }
    }
}
