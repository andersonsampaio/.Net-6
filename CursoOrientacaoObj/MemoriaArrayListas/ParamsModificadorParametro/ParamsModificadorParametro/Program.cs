namespace ParamsModificadorParametro {
    class Program {
        static void Main(string[] args) {

            int S1 = Calculadora.Sum(5, 20);
            int S2 = Calculadora.Sum(5, 20, 30);

            Console.WriteLine(S1);
            Console.WriteLine(S2);
        }
    }
}