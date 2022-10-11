using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class ConversorMoeda
    {
        public static double IOF = 6.0;

        public static double Conversor(double cotacao, double qtdDolar)
        {
            double total = qtdDolar * cotacao;
            return total + total * IOF / 100.0;
        }



    }
}
