using System;
using System.Globalization;

namespace VetoresParte2 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine();
                Console.Write("Digite o nome do produto " + i + ": ");
                string name = Console.ReadLine();
                Console.Write("Valor: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product(name, price);
            }

            double sum = 0;
            for (int i = 0; i < vect.Length; i++) {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("Média = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}