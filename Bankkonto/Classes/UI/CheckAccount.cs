using System;
using System.Collections.Generic;
using Bankkonto.Classes.addKontos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto.Classes.UI
{
    class CheckAccount
    {
        String[] checkAccounts = { "1. Konten anzeigen", "2. Konto wählen und ändern", "3. Zurück"};
        AddKonto ad = new AddKonto();
        private void PrintMenu()
        {
            Console.WriteLine("Bitte wählen!");
            foreach (string menu in checkAccounts)
            {
                Console.WriteLine(menu);
            }
        }
        public void PrintMenuFunction(List<Konto> kontoListe)
        {
            PrintMenu();
            int mySelection = Convert.ToInt32(Console.ReadLine());
            MainMenu mm = new MainMenu();
            DetailsAccount da = new DetailsAccount();
            switch(mySelection)
            {
                case 1:
                    Console.Clear();
                    da.GetKontoNumber(kontoListe);
                    mm.PrintMenuFunction(kontoListe);
                    break;
                case 2:
                    Console.Clear();
                    ChangeDetailsMenu();
                    int newSelection = Convert.ToInt32(Console.ReadLine());
                    if(newSelection == 1)
                    {
                        Console.WriteLine("Ihre neue Limit wurde auf " + ChangeLimit(kontoListe) + " gesetzt");
                        mm.PrintMenuFunction(kontoListe);
                    }
                    else if (newSelection == 2)
                    {
                        Console.WriteLine("Ihre neue Zinsen wurden auf " + ChangeFees(kontoListe) + " gesetzt");
                        mm.PrintMenuFunction(kontoListe);
                    }
                    else
                    {
                        mm.PrintMenuFunction(kontoListe);
                    }

                    break;
                case 3:
                    Console.Clear();
                    mm.PrintMenuFunction(kontoListe);
                    break;
                default:
                    break;
            }
        }
        private void ChangeDetailsMenu()
        {
            String[] detailsMenu = { "1. Überziehungsramen ändern", "2. Zinsen ändern" };
            foreach(string menu in detailsMenu)
            {
                Console.WriteLine(menu);
            }
            Console.WriteLine("Bitte eine Auswahl treffen:");
        }
        private double ChangeLimit(List<Konto> kontoListe)
        {
            ad.GetKontoListe(kontoListe);
            Console.WriteLine("Kontopostition wählen");
            int pos = Convert.ToInt32(Console.ReadLine());
            var selectedKonto = kontoListe.ElementAt(pos);
            Console.WriteLine("Neuer Überziehungsrahmen eingeben:");
            selectedKonto.Limit = Convert.ToDouble(Console.ReadLine());
            return selectedKonto.Limit;
        }
        private double ChangeFees(List<Konto> kontoListe)
        {
            ad.GetKontoListe(kontoListe);
            Console.WriteLine("Kontopostition wählen");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zinsen eingeben:");
            var selectedKonto = kontoListe.ElementAt(pos);
            selectedKonto.Fees = Convert.ToDouble(Console.ReadLine());
            return selectedKonto.Fees;
        }
    }
}
