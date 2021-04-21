﻿namespace Bankkonto
{
    class Girokonto : Konto
    {
        public override double Balance { get => base.Balance; set => base.Balance = value; }
        public override double Limit { get => base.Limit; set => base.Limit = value; }
        public override double Fees { get => base.Fees; set => base.Fees = value; }

        public Girokonto(double balance, double limit, double fees)
        {
            Balance = balance;
            Limit = limit;
            Fees = fees;
        }

        //Constructor

    }
}
