
namespace Nullable {
    class Program {
        static void Main(string[] args) {

            double? x = null; // ? É um recurso de C# para que dados de tipo valor (structs) possam receber o valor null
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("x is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("y is null");

            double? x1 = null;
            double? y1 = 10;

            //operador de coalescência nula
            double a = x1 ?? 5; // Se x1 for nulo atribui 5
            double b = y1 ?? 7; // Se y1 for nulo atribui 7

            Console.WriteLine(a);
            Console.WriteLine(b);



        }
    }
}