using Bankkonto.Classes.addKontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto.Classes.UI
{
    class DetailsAccount
    {
        AddKonto ad = new AddKonto();
        
        public void GetKontoNumber(List<Konto> kontoListe)
        {
            Console.WriteLine("Gespeicherte Kontos");
            ad.GetKontoListe(kontoListe);

        }
    }
}
