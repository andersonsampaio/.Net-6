using System;

namespace VetorExercicio1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Hospede[] vect = new Hospede[10];    

            for (int i = 0; i < n; i++) {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + (i+1) + " :");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Hospede(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < vect.Length; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i
                        +": "
                        + vect[i].Name
                        + ", "
                        + vect[i].Email);
                }
            }
        }
    }
}
