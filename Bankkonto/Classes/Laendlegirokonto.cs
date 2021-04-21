﻿namespace Bankkonto.Classes
{
    class Laendlegirokonto : Konto
    {
        public override double Balance { get => base.Balance; set => base.Balance = value; }
        public override double Limit { get => base.Limit; set => base.Limit = value; }
        public override double Fees { get => base.Fees; set => base.Fees = value; }
        public override int KontoNummer { get => base.KontoNummer; set => base.KontoNummer = value; }

        public Laendlegirokonto(double balance, double limit, double fees, int kontoNummer)
        {
            Balance = balance;
            Limit = limit;
            Fees = fees;
            KontoNummer = kontoNummer;
        }

        //Constructor

    }
}
