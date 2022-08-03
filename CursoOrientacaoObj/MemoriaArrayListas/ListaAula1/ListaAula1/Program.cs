using System.Collections.Generic;

namespace ListaAula1 {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>(); // criando e instanciando lista

            List<string> list2 = new List<string> { "Maria", "Alex"};

            foreach (string i in list2) {
                Console.WriteLine(i);
            }
        }
    }
}