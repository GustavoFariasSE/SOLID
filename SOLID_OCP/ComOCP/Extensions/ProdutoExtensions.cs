using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP.ComOCP.Extensions
{
    public static class ProdutoExtensions
    {
        public static double MargemDeLucro(this ProdutoOCP produto)
        {
            try
            {
                var lucroLiquido = produto.Venda - produto.Custo;
                var margem = (double)(lucroLiquido / produto.Venda) * 100;
                return Convert.ToDouble(margem);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Erro ao calcular a margem de erro de lucro " + ex.ToString());
                throw;
            }
        }
    }
}
