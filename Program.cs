using System;
using System.Globalization;
namespace Controle_De_Estoque
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Preço: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*
            A quantidade foi adicionada diretamente na classe, dentro do costrutor;

            Console.Write("Quantidade no estoque: ");
            int quantidadeEstoque = int.Parse(Console.ReadLine());
            */

            // Produto (produto1) faz referência a sobrecarga de construtores;
            Produto produto1 = new Produto();

            /* Também já poderia instanciar o construtor com os dados necessarios;
            
            Produto produto2 = new Produto
            {
                NomeProduto = Bicicleta,
                PrecoProduto = 800.00,
                QuantidaadeEstoque = 10
            };
            */
            Produto produto = new Produto(nomeProduto, precoProduto);

            Console.WriteLine("\nDados do produto: " + produto);

            Console.Write("\nDigite o numero de produtos a ser adicionado ao estoque: ");
            int adicionaEstoque = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(adicionaEstoque);

            Console.WriteLine("\nDados do produto: " + produto);

            Console.Write("\nDigite o numero de produtos a ser removido do estoque: ");
            int removerEstoque = int.Parse(Console.ReadLine());
            produto.RemoveProdutos(removerEstoque);
            

            Console.WriteLine("\nDados do produto: " + produto);
        }

    }
}
