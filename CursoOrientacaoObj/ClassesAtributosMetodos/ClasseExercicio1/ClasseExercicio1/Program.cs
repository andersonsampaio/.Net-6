using System;
using System.Globalization;

namespace ClasseExercicio1 {
    class Program {
        static void Main(string[] args) {

            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("\nDados primeira pessoa");
            Console.Write("Digite o nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o salário: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDados segunda pessoa ");
            Console.Write("Digite o segundo nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            p2.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o salário: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (p1.Idade > p2.Idade) {
                Console.WriteLine("A pessoa mais velha é " + p1.Nome);
            }
            else {
                Console.WriteLine("A pessoa mais velha é " + p2.Nome);
            }
            
            Console.WriteLine("O salário médio dos funcionários é: " + ((p1.Salario + p2.Salario) / 2.0).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
