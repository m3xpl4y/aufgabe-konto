using Bankkonto.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    class Konto
    {
        public int KontoNummer { get; set; }
        public double Balance { get; set; }
        public int Limit { get; set; }
        public double Fees { get; set; }
        //CONSTRUCTOR
        public Konto(int kontoNummer, double balance, int limit, double fees)
        {
            KontoNummer = kontoNummer;
            Balance = balance;
            Limit = limit;
            Fees = fees;
        }
        //FUNCTIONS
        public double DepositAmount(double deposit)
        {
            Balance = this.Balance + deposit;
            return Balance;
        }
        public double WithdrawAmount(double amount)
        {
            Balance = this.Balance - amount;
            return Balance;
        }
    }
}
