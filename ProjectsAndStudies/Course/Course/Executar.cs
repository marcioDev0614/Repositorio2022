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
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorMoeda.Conversor(cotacao, qtdDolar);
            Console.WriteLine();
            Console.WriteLine("O valor a ser pago em reais R$" + total.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
