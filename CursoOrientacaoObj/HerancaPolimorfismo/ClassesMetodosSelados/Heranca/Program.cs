using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.00, 0.01);

            acc1.WithDraw(10.00);
            acc2.WithDraw(10.00);

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
                    
        }
    }
}