using System.Globalization;

namespace ExemploCapitulo {
    internal class ContaBancaria {

        // Atributos + encapsulamento dos atributos 
        public int Numero { get; private set; } 
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // Construtores
        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) { //sobrecarga de construtor utilizando this
            Deposito(depositoInicial);
        }

        //Métodos
        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia;
            Saldo -= 5.0;
        }

        override public string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
