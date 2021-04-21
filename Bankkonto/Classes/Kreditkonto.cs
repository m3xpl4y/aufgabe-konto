namespace Bankkonto.Classes
{
    class Kreditkonto : Konto
    {
        public override double Fees { get => base.Fees; set => base.Fees = value; }
        public override double Balance { get => base.Balance; set => base.Balance = value; }
        public override double Limit { get => base.Limit; set => base.Limit = value; }

        public Kreditkonto(double fees, double balance, double limit)
        {
            Fees = fees;
            Balance = balance;
            Limit = limit;
        }

        public override double WithdrawAmount(double amount)
        {
            double overLimit = Balance - (Limit);
            if (overLimit <= amount)
            {
                double withdrawAmount = overLimit - amount;
                System.Console.WriteLine("Sie haben Ihr Limit erreicht");
                System.Console.WriteLine("Sie können nur: " + withdrawAmount + " abheben");
            }
            else
            {
                Balance = this.Balance - amount;
            }
            return Balance;
        }
    }
}
