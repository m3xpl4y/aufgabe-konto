namespace Bankkonto
{
    class Konto
    {
        //Variables + GET & SET
        public int KontoNummer { get; set; }
        public virtual double Balance { get; set; }
        public virtual double Limit { get; set; }
        public virtual double Fees { get; set; }

        //CONSTRUCTOR
        public Konto()
        {
            
        }

        //FUNCTIONS
        public double DepositAmount(double deposit)
        {
            Balance = this.Balance + deposit;
            return Balance;
        }
        public double WithdrawAmount(double amount)
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
