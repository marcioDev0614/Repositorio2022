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
            int a = 10;
            //Calculator.Triple(ref a); // Camando o metodo sem o out ou ref, o valor não será multiplicado
            Calculator.Triple(ref a); // Adicionando o "ref", o valor declararo será multiplicado.
            Console.WriteLine(a);

        }
    }
}
