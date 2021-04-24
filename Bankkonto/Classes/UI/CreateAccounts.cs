using Bankkonto.Classes.addKontos;
using System;
using System.Collections.Generic;

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

        public void CreateAccountFunction(List<Konto> kontoListe)
        {
            CreateAccountMenu();
            int mySelection = Convert.ToInt32(Console.ReadLine());
            MainMenu mm = new MainMenu();
            switch (mySelection)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Girokonto erstellen!");
                    addKonto.addGirokonto(kontoListe);
                    mm.PrintMenuFunction(kontoListe);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ländlekonto erstellen!");
                    addKonto.addLaendlekonto(kontoListe);
                    mm.PrintMenuFunction(kontoListe);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Sparbuch erstellen!");
                    addKonto.addSparbuch(kontoListe);
                    mm.PrintMenuFunction(kontoListe);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Kreditkonto erstellen!");
                    addKonto.addKreditkonto(kontoListe);
                    mm.PrintMenuFunction(kontoListe);
                    break;
                case 5:
                    Console.Clear();
                    mm.PrintMenuFunction(kontoListe);
                    break;
                default:
                    Console.WriteLine("Gibt doch das was da stehen ein");
                    break;
            }
        }
    }
}
