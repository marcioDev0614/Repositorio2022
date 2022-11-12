using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class OperadorTernario
    {
        static void Main()
        {
            Console.Write("Informe o preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine("Descoto de R$: " + desconto);

            //if(preco < 20.0)
            //{
            //    desconto = (preco * 0.1); // Desconto de 10%
            //}
            //else
            //{
            //    desconto = (preco * 0.05); // Desconto de 5%
            //}

            //Console.WriteLine(desconto);
        }
    }
}
