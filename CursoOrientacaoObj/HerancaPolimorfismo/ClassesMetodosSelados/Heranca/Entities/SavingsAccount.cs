namespace Heranca.Entities
{
    sealed class SavingsAccount : Account // 'SEALED' evita que a CLASSE seja HERDADA
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpDateBalance()
        {
            Balance += Balance * InterestRate; 
        }

        public sealed override void WithDraw(double amount) // 'SEALED' evita que MÉTODO sobreposto seja sobreposto novamente
        {
            base.WithDraw(amount);
            Balance -= amount;
        }
    }
}
