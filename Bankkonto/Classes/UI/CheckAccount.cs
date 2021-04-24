using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto.Classes.UI
{
    class CheckAccount
    {
        String[] checkAccounts = { "1. Konten anzeigen", "2. Konto wählen und ändern", "3. Zurück"};

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

            switch(mySelection)
            {
                case 1:
                    //Console.Clear();
                    DetailsAccount da = new DetailsAccount();
                    da.GetKontoNumber(kontoListe);
                    break;
                case 2:
                    break;
                case 3:
                    //Console.Clear();
                    MainMenu mm = new MainMenu();
                    mm.PrintMenuFunction(kontoListe);
                    break;
                default:
                    break;
            }
        }
}
}
