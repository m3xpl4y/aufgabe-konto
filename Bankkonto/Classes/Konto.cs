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
        public virtual double DepositAmount(double deposit)
        {
            Balance = this.Balance + deposit;
            return Balance;
        }
        public virtual double WithdrawAmount(double amount)
        {
            Balance = this.Balance - amount;
            return Balance;
        }
    }
}
