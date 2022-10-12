using System;
using System.Globalization;

namespace Course
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() { // Exemplo de contrutores usando o "this"
            Quantidade = 10;
       
        } 
        public Produto(string nome, double preco) : this() // A palavra this sinaliza que o argumento quantidade
            // está sendo aproveitado do contrutor acima.
        {
            Nome = nome;
            Preco = preco;
           
        }
        public Produto(string nome, double preco, int quantidade) : this (nome,preco) 
            // A palavra this sinaliza que os argumentos: nome, preco está sendo aproveita do contrutor acima.
        {
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public int AdicionarProdutos(int quantidade)
        {
            return Quantidade += quantidade;
        }

        public int RemoverProdutos(int quantidade)
        {
            return Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Preco.ToString("f2",CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $"
            + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("****Teste*****");

            //Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new Produto(nome,preco); // Chamando o contrutor de 2 argumentos

            // Sintaxe alternativa de inicializar valores. Abrindo {} e usando as tecla ctrl + espaço
            Produto produto2 = new Produto { Nome = "Telefone", Preco = 8500.00, Quantidade = 2 };

            Console.WriteLine($"Dados do Produto: {produto}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");



        }
    }
}

