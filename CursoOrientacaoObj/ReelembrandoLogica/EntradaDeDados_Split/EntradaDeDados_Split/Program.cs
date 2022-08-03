using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            string x;
            int y;
            double z;
            char w;

            x = Console.ReadLine();
            y = int.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //coloca vírgula como padrão
            w = char.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);

            //split -> quebra os valores separados por espaço para quardar em vetor
            Console.WriteLine("Digite três palavras separadas por vírgula");
            string[] vetor = Console.ReadLine().Split(' ');
            
            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);
            Console.WriteLine(vetor[2]);


        }
    }
}
