using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_De_Estoque
{
    internal class Produto
    {
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }
        public int QuantidadeEstoque { get; set; }

        // Sobrecarga de construtores;
        public Produto() { }

        public Produto(string NomeProduto, double PrecoProduto, int QuantidadeEstoque)
        {
            this.NomeProduto = NomeProduto;
            this.PrecoProduto = PrecoProduto;
            this.QuantidadeEstoque = QuantidadeEstoque;
        }

        public Produto(string NomeProduto, double PrecoProduto)
        {
            this.NomeProduto = NomeProduto;
            this.PrecoProduto = PrecoProduto;
            QuantidadeEstoque = 10;
        }
        public double ValorTotalEmEstoque()
        {
            return PrecoProduto * QuantidadeEstoque;
        }

        public int AdicionarProdutos(int adicionaProduto)
        {
            return QuantidadeEstoque += adicionaProduto;
        }
        
        public int RemoveProdutos(int removeProduto)
        {
            return QuantidadeEstoque -= removeProduto;
        }

        public override string ToString()
        {
            return $"{NomeProduto.ToUpper()}, R$ {PrecoProduto.ToString("F2", CultureInfo.InvariantCulture)}, {QuantidadeEstoque} " +
                $"unidades, Total: R$ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)} ";
        }
    }

    
}
