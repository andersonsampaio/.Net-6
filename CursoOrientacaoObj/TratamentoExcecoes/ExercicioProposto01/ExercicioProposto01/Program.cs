using ExercicioProposto01.Entities;
using ExercicioProposto01.Entities.Exceptions;
using System.Globalization;
namespace ExercicioProposto01

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.Write("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
                Console.WriteLine();
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
                 
        }
    }
}