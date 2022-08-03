namespace DateTimeKindIso {
    class Program {
        static void Main(string[] args) {

            //Tipo enumerado especial que define três valores possíveis para a localidade da data:

            //• Local[fuso horário do sistema.Exemplo: São Paulo = GMT - 3 ]
            //• Utc[fuso horário GMT(Greenwich Mean Time)]
            //• Unspecified

            // Demo
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());

            //Padrão ISODemo
            Console.WriteLine();
            DateTime d5 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d6 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + d5);
            Console.WriteLine("d1 Kind: " + d5.Kind);
            Console.WriteLine("d1 to Local: " + d5.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d5.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d6);
            Console.WriteLine("d2 Kind: " + d6.Kind);
            Console.WriteLine("d2 to Local: " + d6.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d6.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d6.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d6.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
