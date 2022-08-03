using ExercicioProposto01.Entities.Exceptions;

namespace ExercicioProposto01.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amaunt)
        {
            Balance += amaunt;
        }

        public void Withdraw(double amaunt)
        {
            if (amaunt > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amaunt > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amaunt;
        }
    }
}
