using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Executar
    {
        static void Main()
        {

            // Boxing: É um processo de conversão de um objeto tipo valor para um objeto tipo referência compativível
            // Ex:

            int x = 20;
            object obj = x; // Exemplo de boxing
            Console.WriteLine(obj);

            // Unboxing: É um processo de conversão de um objeto tipo referência para um objeto tipo valor compátivel
            // EX:

            int y = (int)obj; // Exemplo de Unboxing. Onde será necessário fazer um casting pois se isso não fo feito
                              // o compilador não irá aceitar
            Console.WriteLine(y);


        }
    }
}
