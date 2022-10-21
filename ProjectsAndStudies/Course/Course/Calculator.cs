
namespace Course
{
    class Calculator
    {
        public static int SumInt(int n1, int n2) // Exemplo ruim de ser implementado
        {
            return n1 + n2;
        }

        public static int SumInt(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public static int SumIntVetor(int[] numbers) // Inplementação que recebe n sobrecargas
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static int SumIntVetorParans(params int[] numbers) // Inplementação mais adequada passando o params
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static double MultiNotas(params double[] notas)
        {
            double result = 0.0;
            for(int i = 0; i < notas.Length; i++)
            {
                result += notas[i];
            }
            return result;
        }

        //public static void Triple(int x) // Metoto ruim
        //{
        //    x = x * 3;
        //}

        //public static void Triple(ref int x) // Metoto usando ref no parametro.
        //{                                    // Atenção! usando o ref, quando chamamos a função, a variável deve ser iniciada.
        //    x = x * 3;
        //}

        public static void Triple(int origin, out int result) // Metodo usando out no parametro
        {        // Diferente do ref, o sintaxe out, não obriga que a variável original seja iniciada                               
            result = origin * 3;
        }

    }
}
