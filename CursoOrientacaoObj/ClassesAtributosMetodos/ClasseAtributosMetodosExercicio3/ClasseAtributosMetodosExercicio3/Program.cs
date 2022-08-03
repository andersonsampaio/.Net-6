using System.Globalization;

namespace ClasseAtributosMetodosExercicio3 {
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double nota = aluno.NotaAluno();
            Console.WriteLine("Nota final: " + nota);
            string sit = aluno.SituacaoAluno(nota);
            Console.WriteLine(sit);
            if (sit == "Reprovado") {
                Console.WriteLine("Falataram " + aluno.FaltaParaPassar().ToString("F2", CultureInfo.InvariantCulture) + " pontos.");
            }
        }

    }
}
