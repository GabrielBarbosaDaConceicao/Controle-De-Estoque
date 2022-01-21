using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_De_Estoque
{
    internal class Produto
    {
        private string _nomeProduto { get; set; }
        private double _precoProduto { get; set; }
        private int _quantidadeEstoque { get; set; }

        public Produto(string nomeProduto, double precoProduto, int quantidadeEstoque)
        {
            _nomeProduto = nomeProduto;
            _precoProduto = precoProduto;
            _quantidadeEstoque = quantidadeEstoque;
        }

        public string NomeProduto
        {
            get { return _nomeProduto; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nomeProduto = value;
                }
            }
        }

        public double PrecoProduto
        {
            get { return _precoProduto; }
            set { _precoProduto = value; }
        }

        public int Quantidade
        {
            get { return _quantidadeEstoque; }
        }
        public double ValorTotalEmEstoque()
        {
            return _precoProduto * _quantidadeEstoque;
        }

        public int AdicionarProdutos(int adicionaProduto)
        {
            return _quantidadeEstoque += adicionaProduto;
        }
        
        public int RemoveProdutos(int removeProduto)
        {
            return _quantidadeEstoque -= removeProduto;
        }

        public override string ToString()
        {
            return $"{_nomeProduto.ToUpper()}, R$ {_precoProduto.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidadeEstoque} " +
                $"unidades, Total: R$ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)} ";
        }
    }

    
}
