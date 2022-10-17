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

            // Nullable: É um recurso de C# para que dados de tipo valor(struct) possam
            // receber o valor null.

            // Uso comum?
            // Campo de banco de dados que podem valer nulo(data de nascimento, algum valor numérco, etc)
            // Dados e parametros opcionais.

            // Para identificar o tipo de uma variavel como nullable, adicionamos a sintaxe o 
            // Simbolo de "?"
            // EX:
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());// O resultado retorna o valor padrão caso não tenha valor setado. No caso é zero
            Console.WriteLine(y.GetValueOrDefault()); // O resultado será 10
            Console.WriteLine();
            Console.WriteLine(x.HasValue); // Aqui ele retornar false, pois não tem valor
            Console.WriteLine(y.HasValue); // Aqui ele retorna true
            Console.WriteLine();
            //Console.WriteLine(x.Value); // Aqui o resultado é uma exception. Nesse caso se faz necessário fazer uma validação antes. Exemplo
                                        // usando um IF
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            // Operador de Coalecência nula.
            // Nesse exemplo a variável "b" que recebe o atributo de "a", Retornará o valor de 0.00 caso a seja null.
            double? a = null;
            double? b = 10.0;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);

            

        }
    }
}
