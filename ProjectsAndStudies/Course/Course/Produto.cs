using System;
using System.Globalization;

namespace Course
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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

        //public override string ToString()
        //{
        //    return $"Dados do Produto: \nNome: {Nome}\nPreço: {Preco}\nUnidades: {Quantidade}" 
        //    + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        //}
    }
    class Program
    {
        static void Main_(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("****Teste*****");

            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do Produto: {produto.Nome}, $ {produto.Preco}, {produto.Quantidade} unidades, "
                + "Total: $ " + produto.ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture));

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int addProduto = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(addProduto);

            Console.WriteLine($"Dados atualizados: {produto.Nome}, $ {produto.Preco}, {produto.Quantidade} unidades, "
                + "Total: $ " + produto.ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture));

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            int removeProduto = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(removeProduto);

            Console.WriteLine($"Dados atualizados: {produto.Nome}, $ {produto.Preco}, {produto.Quantidade} unidades, "
                + "Total: $ " + produto.ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture));



        }
    }
}

