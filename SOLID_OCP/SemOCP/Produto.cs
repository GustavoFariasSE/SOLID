using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP.SemOCP
{
    public class Produto
    {
        public int ProdutoId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        private decimal _custo = 0;
        public decimal Custo
        {
            get => _custo;

            private set
            {
                if (value > 0) _custo = value;
            }
        }

        private decimal _venda = 1;
        public decimal Venda
        {
            get => _venda;
            private set
            {
                if (value > 0) _venda = value;
            }
        }

        public int Estoque { get; private set; }  
        public bool Ativo { get; private set; }

        public Produto(int produtoId, string nome, string descricao, decimal custo, decimal venda, int estoque, bool ativo)
        {
            ProdutoId = produtoId;
            Nome = nome;
            Descricao = descricao;
            Custo = custo;
            Venda = venda;
            Estoque = estoque;
            Ativo = ativo;
        }

        public double CalcularMargemLucro()
        {
            try
            {
                var lucroLiquido = Venda - Custo;
                var margem = (double)(lucroLiquido / Venda) * 100;
                return Convert.ToDouble(margem);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Erro ao calcular a margem de erro de lucro " + ex.ToString());
                return 0;
            }
        }
    }
}
