using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    class Sparbuch : Konto
    {
        //private int Kontonummer;
        //private double SparBuchBalance;
        Konto konto;

        public Sparbuch(Konto konto)
        {
            this.konto = konto;
        }

        public double SavingsWithdraw(double i)
        {
            if(konto.Balance <= 0)
            {
                Console.WriteLine("Sie haben kein Guthaben, das Sie abheben können");
            }
            else
            {
                konto.Balance = this.konto.Balance - i;
            }
            return konto.Balance;
        }
        public double SavingsDeposit(double i)
        {
            {
                konto.Balance = this.konto.Balance + i;
            }
            return konto.Balance;
        }

        public void GetSavingsBalance()
        {
            Console.WriteLine("Ihr Kontostand lautet: " + this.konto.Balance);
        }

        public int GetKontoNummer(Sparbuch sparbuch)
        {
            int i = sparbuch.KontoNummer;
            return i;
        }
    }
}
