namespace Bankkonto.Classes
{
    class Kreditkonto : Konto
    {
        public override double Fees { get => base.Fees; set => base.Fees = value; }
        public override double Balance { get => base.Balance; set => base.Balance = value; }
        public override double Limit { get => base.Limit; set => base.Limit = value; }
        public override int KontoNummer { get => base.KontoNummer; set => base.KontoNummer = value; }
        
        //Constructor
        public Kreditkonto(double fees, double balance, double limit, int kontoNummer)
        {
            Fees = fees;
            Balance = balance;
            Limit = limit;
            KontoNummer = kontoNummer;
        }

    }
}
