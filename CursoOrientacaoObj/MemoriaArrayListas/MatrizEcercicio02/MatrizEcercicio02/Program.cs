
namespace MatrizExercicio02 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite dimensão da matriz (m,n): ");
            string[] dimensao = Console.ReadLine().Split(' ');
            int m = int.Parse(dimensao[0]);
            int n = int.Parse(dimensao[1]);

            int[,] mat = new int[m, n];
            Console.WriteLine();

            for (int i = 0; i < m; i++) {
                Console.Write("Digite "
                    + n
                    + " Inteiros pertencentes a "
                    + (i+1)
                    +"ª linha: ");
                string[] linha = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(linha[j]);
                }

            }

            Console.WriteLine();
            Console.Write("Digite um valor existente na matriz: ");
            int localiza = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    if (mat[i,j] == localiza) {
                        Console.WriteLine("Posição de " 
                            + localiza
                            +" na matriz é: ("
                            + i
                            +","
                            +j
                            +")");
                        if(j > 0) {
                            Console.WriteLine("Left: "
                                + mat[i,j-1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: "
                                + mat[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Right: "
                                + mat[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Down: "
                                + mat[i + 1, j]);
                        }
                    }
                }
            }

        }
    }
}