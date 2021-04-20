using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    class Girokonto : Konto
    {
        Konto konto;
        public Girokonto(Konto konto)
        {
            this.konto = konto;
        }
        public int GetKontoNummer(Girokonto girokonto)
        {
            int i = girokonto.KontoNummer;
            return i;
        }
    }
}
