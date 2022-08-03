

namespace MembrosEstaticosExercicio1 {
    internal class ConversorDeMoeda {

        public static double Iof = 6.0;

        public static double DolarParaReal(double cotacao, double dola) {
            double total = dola * cotacao;
            return total + total * Iof / 100;
        }
    }
}
