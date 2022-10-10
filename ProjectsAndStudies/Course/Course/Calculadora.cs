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
        public double PI = 3.14;

        public double Volume(double r)
        {
            return 4.0 / 3.0 * PI * r * r * r;
        }

        public double Circunferencia(double r)
        {
            return 2.0 * PI * r;
        }
    }
}
