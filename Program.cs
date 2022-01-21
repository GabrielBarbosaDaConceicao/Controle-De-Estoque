using System;
using System.Globalization;
namespace Controle_De_Estoque
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 300.00, 10);

            Console.WriteLine("Dados atuais do produto:");
            Console.WriteLine("Produto: " + produto);

            Console.WriteLine("\nEntre os dados para atualizar o produto:");
            Console.Write("Nome: ");
            produto.NomeProduto = Console.ReadLine();
            Console.Write("Preço: ");
            produto.PrecoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         
            

            Console.WriteLine("\nDados atualizados: " + produto);

            Console.Write("\nDigite o numero de produtos a ser adicionado ao estoque: ");
            int adicionaEstoque = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(adicionaEstoque);

            Console.WriteLine("\nDados atualizados: " + produto);

            Console.Write("\nDigite o numero de produtos a ser removido do estoque: ");
            int removerEstoque = int.Parse(Console.ReadLine());
            produto.RemoveProdutos(removerEstoque);
            

            Console.WriteLine("\nDados atualizados: " + produto);
        }

    }
}
