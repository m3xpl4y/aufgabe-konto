using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    class Konto
    {
        private int kontonummer;
        private double limit;
        private double balance;
        public double Limit
        {
            get { return limit; }
            set { limit = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public int KontoNummer
        {
            get { return kontonummer; }
            set { kontonummer = value; }
        }

        //FUNCTIONS
        public void WithdrawLimit()
        {
            if(limit <= 0)
            {
                Console.WriteLine("Sie können nicht ins Minus");
            }
        }

    }
}
