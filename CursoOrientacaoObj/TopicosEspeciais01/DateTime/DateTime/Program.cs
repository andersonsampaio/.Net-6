using System.Globalization;

namespace DateTime_ {
    class Program {
        static void Main(string[] args) {

            // Demo - construtores
            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            // Demo - Now, UtcNow, Today
            DateTime a1 = DateTime.Now;
            DateTime a2 = DateTime.UtcNow;
            DateTime a3 = DateTime.Today;

            Console.WriteLine();
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);

            // Demo - Parse converte o string para padrão
            DateTime c1 = DateTime.Parse("2000-08-15");
            DateTime c2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime c3 = DateTime.Parse("15/08/2000");
            DateTime c4 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine();
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);


            // Demo - ParseExact -  CONVERTE STRING PARA DataTime
            // ParseExact determinamos o formato de saída
            DateTime b1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
                CultureInfo.InvariantCulture);
            DateTime b2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
                CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            
        }
    }
}