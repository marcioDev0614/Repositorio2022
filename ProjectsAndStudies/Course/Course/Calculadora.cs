using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Calculadora
    {
        // Para que o metodo estático seja visualizado, é necessário trocar de "static" para "public"
        // Para chamar o metodo de classe, é necessário instanciar um novo objeto no metodo Main().
        // Ex: Calcularora calc = new Calculadora();
        public static double PI = 3.14;

        // Adicionando o "static" será possivel chamar o metodo sem precisar instanciar um novo objeto.
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * PI * r * r * r;
        }

        public static double Circunferencia(double r)
        {
            return 2.0 * PI * r;
        }
    }
}
