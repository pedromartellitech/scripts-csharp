using System;  // Importa a biblioteca para funcionalidades básicas do sistema
using System.Net;  // Importa a biblioteca para credenciais de rede
using System.Net.Mail;  // Importa a biblioteca para envio de e-mails

class Program
{
    static void SendEmail(string subject, string body, string toEmail)
    {
        // Define o e-mail do remetente
        string fromEmail = "youremail@example.com";
        // Define a senha do e-mail do remetente
        string password = "yourpassword";

        // Configura o cliente SMTP, definindo o servidor e a porta
        SmtpClient smtpClient = new SmtpClient("smtp.example.com", 587)
        {
            // Define as credenciais do remetente (e-mail e senha)
            Credentials = new NetworkCredential(fromEmail, password),
            // Ativa a conexão segura (SSL)
            EnableSsl = true
        };

        // Cria uma mensagem de e-mail
        MailMessage mailMessage = new MailMessage
        {
            // Define o endereço do remetente
            From = new MailAddress(fromEmail),
            // Define o assunto do e-mail
            Subject = subject,
            // Define o corpo do e-mail
            Body = body,
            // Define se o corpo do e-mail é em HTML (false para texto puro)
            IsBodyHtml = false
        };

        // Adiciona o destinatário ao e-mail
        mailMessage.To.Add(toEmail);

        try
        {
            // Tenta enviar o e-mail
            smtpClient.Send(mailMessage);
            // Informa que o e-mail foi enviado com sucesso
            Console.WriteLine("E-mail enviado com sucesso!");
        }
        catch (Exception ex)
        {
            // Captura e exibe erros caso o envio falhe
            Console.WriteLine("Erro ao enviar e-mail: " + ex.Message);
        }
    }

    static void Main(string[] args)
    {
        // Chama a função SendEmail para enviar o e-mail com os parâmetros desejados
        SendEmail("Assunto do E-mail", "Corpo do e-mail", "destinatario@example.com");
    }
}
