using System.Globalization;

namespace ObjectToStringExercicio2 {
    internal class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double Porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto*(Porcentagem/100));
        }

        public override string ToString() {
            return Nome +
                ", R$ " +
                SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
