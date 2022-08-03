using System;
using System.Globalization;

namespace VetoresParte1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {

                Console.Write("Digite o valor do vetor na posição " + i + ": ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }
            Console.WriteLine("A média do vetor é: " + (sum/n).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

