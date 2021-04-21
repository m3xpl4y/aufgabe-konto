namespace Bankkonto.Classes
{
    class Kreditkonto : Konto
    {
        public override double Fees { get => base.Fees; set => base.Fees = value; }
        public override double Balance { get => base.Balance; set => base.Balance = value; }
        public double Limit = 0.0;
        public override int KontoNummer { get => base.KontoNummer; set => base.KontoNummer = value; }
        
        //Constructor
        public Kreditkonto(int kontoNummer, double fees, double balance, double limit)
        {
            Fees = fees;
            Balance = balance;
            Limit = limit;
            KontoNummer = kontoNummer;
        }

        public override double WithdrawAmount(double amount)
        {            
            double overLimit = Balance - (Limit);
            if(amount == 0)
            {
                System.Console.WriteLine("Vielen Dank!");
            }
            else if(overLimit <= 0)
            {
                System.Console.WriteLine("Leider kein Guthaben vorhaden");
            }
            else if (overLimit <= amount)
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
