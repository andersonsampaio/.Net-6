namespace Heranca.Entities
{
    internal class SavingsAccount : Account
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

        public override void WithDraw(double amount)
        {
            base.WithDraw(amount); // BASE mantem a regra do método WithDram da superclasse
            Balance -= amount;     // podendo adicionar regras adicionais
        }
    }
}
