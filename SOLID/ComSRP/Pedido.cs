
using SOLID_SRP.ComSRP;
using System.Net.Mail;


namespace SOLID.SemSRP
{
    internal class PedidoSRP
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        private ILogger infologger;
        private EnviarEmail enviarEmail;

        public PedidoSRP()
        {
            enviarEmail = new EnviarEmail();
            infologger = new RegistraLog();
        }


        public void IncluirPedido()
        {
            try
            {
                infologger.Info("Iniciando o processo de inclusão do pedido.");
                
            }
            catch (Exception ex)
            {
               infologger.Info("Erro ao incluir o pedido: " + ex.ToString());

            }
        }

        public void DeletePedido()
        {
            try
            {
                //codigo para deletar o pedido
                infologger.Info("Iniciando o processo de exclusão do pedido.");
            }
            catch (Exception ex)
            {
                infologger.Info("Erro ao deletar o pedido: " + ex.ToString());
            }
        }
        
    }
}
