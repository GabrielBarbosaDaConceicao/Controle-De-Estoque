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
            Console.Write("Quantidade no estoque: ");
            int quantidadeEstoque = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nomeProduto, precoProduto, quantidadeEstoque);

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
