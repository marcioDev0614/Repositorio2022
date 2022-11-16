using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Exemplo_DateTime
    {
        static void Main_()
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1); // Retorna a data e hora atual do sistema

            // Usando o datetime com o construtor instanciando um objeto

            DateTime d2 = new DateTime(2022, 11, 14);
            Console.WriteLine("Data e hora zerada: " + d2); // Impressão sem a hora
            DateTime d3 = new DateTime(2022, 11, 14, 11, 22, 03);
            Console.WriteLine("Data e hora: " + d3); // Data e hora

            // Datetime usando o build

            DateTime d4 = DateTime.Today;
            Console.WriteLine(d4); // Data do dia com zero horas
            DateTime d5 = DateTime.UtcNow;
            Console.WriteLine(d5); // Horário atual mais duas horas de diferença

            // DateTime usando o Parse

            DateTime d6 = DateTime.Parse("2022-11-15");
            Console.WriteLine(d6);
            DateTime d7 = DateTime.Parse("2022-11-15 11:31:45");
            Console.WriteLine(d7);
            DateTime d8 = DateTime.Parse("14/11/2022");
            Console.WriteLine("Formato Brasileiro: " + d8);
            DateTime d9 = DateTime.Parse("14/11/2022 11:34:05");
            Console.WriteLine("Formato Brasileiro: " + d9);

            // Datetime usando o ParseExact

            DateTime d10 = DateTime.ParseExact("2022-11-14", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);
            DateTime d11 = DateTime.ParseExact("14/11/2022 11:38:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);

        }
    }
}
