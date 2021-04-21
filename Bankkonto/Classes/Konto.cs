namespace Bankkonto
{
    class Konto
    {
        public int KontoNummer { get; set; }
        public double Balance { get; set; }
        public int Limit { get; set; }
        public double Fees { get; set; }
        //CONSTRUCTOR
        
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
