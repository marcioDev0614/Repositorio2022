
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



    }
}
