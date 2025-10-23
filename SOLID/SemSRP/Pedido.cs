
using System.Net.Mail;


namespace SOLID.SemSRP
{
    internal class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }

        public void IncluirPedido()
        {
            try
            {
                // Lógica para incluir o pedido
                // Após cloncluir, envia um e-mail
                MailMessage mail = new MailMessage("EmailFrom", "EmailTo", "EmailSubject", "EmailBody");

                this.EnviarEmailPedido(mail);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\dados\ErrorLog.txt", ex.ToString());

            }
        }

        public void DeletePedido()
        {
            try
            {
                // Lógica para deletar o pedido
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\dados\ErrorLog.txt", ex.ToString());
            }
        }

        public void EnviarEmailPedido(MailMessage mail)
        {
            try
            {
                //Lógica para enviar e-mail

            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\dados\ErrorLog.txt", ex.ToString());
            }
        }
        
    }
}
