using System.Globalization;

namespace MembrosEstaticosExercicio1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dola = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pagar = ConversorDeMoeda.DolarParaReal(cotacao, dola);

            Console.WriteLine("Valor a ser pago em reais = " + pagar.ToString("F2" , CultureInfo.InvariantCulture));
        }
    }
}
