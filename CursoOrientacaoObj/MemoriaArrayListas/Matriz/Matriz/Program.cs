
namespace Matriz {
    class Program {
        static void Main(string[] args) {

            double[,] mat = new double[8,3];

            Console.WriteLine(mat.Length);          // retorna qtd de elementos na matriz
            Console.WriteLine(mat.Rank);            // retorna dimensão (uni, bidimensional ... etc) da matriz
            Console.WriteLine(mat.GetLength(0));    // retorna qtd de linhas na matriz
            Console.WriteLine(mat.GetLength(1));    // retorna qtd de colunas na matriz
        }
    }
}