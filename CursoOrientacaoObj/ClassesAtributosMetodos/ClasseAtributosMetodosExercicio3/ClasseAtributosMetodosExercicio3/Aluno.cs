
namespace ClasseAtributosMetodosExercicio3 {
    internal class Aluno {

        public double Nota1, Nota2, Nota3;

        public double NotaAluno() {
            return Nota1 + Nota2 + Nota3;
        }

        public string SituacaoAluno(double nota) {
            if (nota >= 60){
                return "Aprovado";
            }
            else {
                return "Reprovado";
            }
        }

        public double FaltaParaPassar() {
            return 60 - NotaAluno();
        }
    }
}
