using System;
using System.Globalization;

namespace Course
{
    class Produto
    {
        private string _nome; // Sinalizando atributos como private. Onde só será possivel acessa-los
        private double _preco; // pela propria classe. Detalhe para a convenção. O nome dos atributos, colocamos o
        private int _quantidade; // anderline no nome "_". Metodos também teram que ser alterados os nome
                                // colocando o _ no começo para que não haja erro na compilação.
        public Produto() { // Exemplo de contrutores usando o "this"
            _quantidade = 10;
       
        } 
        public Produto(string nome, double preco) : this() // A palavra this sinaliza que o argumento quantidade
            // está sendo aproveitado do contrutor acima.
        {
            _nome = nome;
            _preco = preco;
           
        }
        public Produto(string nome, double preco, int quantidade) : this (nome,preco) 
            // A palavra this sinaliza que os argumentos: nome, preco está sendo aproveita do contrutor acima.
        {
            _quantidade = quantidade;
        }

        //public string GetNome() // Para que outra classe consiga acessar o nome. Será necessário 
        //{                       // inplementar o metodo Get conforme exemplo.
        //    return _nome;
        //}

        public double Preco // Propriedade.
        {
            get { return _preco; }
        }
        
        //public double GetPreco() // Com essa inplementação, só será possivel acessar os atributos
        //{                          // atrevés do metodos e não pelo proprio atributo
        //    return _preco;
        //}

        public string Nome // Propriedade inplementada para o atributo "Nome".
        {                   // Com isso, sera possivel acessar o atributos diretamente e não pelo metodo
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Quantidade // Propriedade Quantidade
        {
            get { return _quantidade; }
        }
        //public double GetQuantidade()
        //{
        //    return _quantidade;
        //}

        //public void SetNome(string nome) // Para que seja possivel alterar o nome de uma atributo
        //                                 // privado, é necessário inplementar o metodo Set conforme exemplo
        //{
        //    _nome = nome;
        //}

        public void SetNome2(string nome) // Exemplo de set onde há uma valição antes de realizar a
        {                                   // alteração do valor do atributo.
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public int AdicionarProdutos(int quantidade)
        {
            return _quantidade += quantidade;
        }

        public int RemoverProdutos(int quantidade)
        {
            return _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{_nome}, $ {_preco.ToString("f2",CultureInfo.InvariantCulture)}, {_quantidade} unidades, Total: $"
            + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("****Teste*****");

            Produto p = new Produto("Tv",500.00,10);

            Console.WriteLine(p.Nome); // Acessando o atributo

            //p.SetNome("Tv 4K"); // Alterando o valor do atributo

            p.Nome = "Tv 4k";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            //p.Preco = 800.00 // Não será possivel pois a propriedade set não foi inplementada.
            //Console.WriteLine(p.GetPreco());
            //Console.WriteLine(p.GetQuantidade());

          


        }
    }
}

