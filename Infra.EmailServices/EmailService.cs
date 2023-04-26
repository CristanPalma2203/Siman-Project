using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EmailServices
{
    public class EmailService : IEmailService
    {
        /// <summary>
        /// Esta clase implementa la interfaz IEmailService junto a sus métodos para enviar 
        /// mensajes de correo electrónico, para ello se inicializa el objeto SmtpClient.
        /// No olvides de configurar la conexión al servidor de correo remitente (MailServer), 
        /// con tus datos de correo electrónico (El que se encargará de enviar los mensajes de correo).
        /// En caso que uses Gmail como email remitente, debes de activar la opcion Permitir el acceso de aplicaciones
        /// poco seguras para que tu aplicación pueda enviar correos electrónicos.
        /// Leer la guía rápida para mas información.
        /// </summary>

        #region -> Definición de Campos

        private SmtpClient smtpClient;//Obtiene o establece el cliente SMTP
        private struct MailServer//Obtiene o establece el correo servidor quíen se encarga de enviar los mensajes de correo.
        {
            //Aquí realice las configuraciones  del Protocolo simple de transferencia de correo (SMTP)

            public const string Address = "VitalClinicSystem@gmail.com";//Establece la dirección del correo servidor remitente(Aquí coloque el correo electrónico responsable de enviar los correos electrónicos).
            public const string Password = "@admin123";//Establece la contraseña del correo servidor remitente(Aquí coloque la contraseña del correo que estableciste en la linea anterior).
            public const string DisplayName = "Vital Clinic";//Establece el nombre para mostrar cuando se envia un mensaje de correo.
            public const string Host = "smtp.gmail.com";//Establece el nombre o la dirección IP del host para las transacciones SMTP.
            public const int Port = 587;//Establece el puerto utilizado para las transacciones SMTP.
            public const bool SSL = true;//Establece si el cliente SMTP utiliza Secure Sockets Layer (SSL) para cifrar la conexión.
        };
        #endregion

        #region -> Constructor

        public EmailService()
        {
            smtpClient = new SmtpClient();//Inicializar cliente SMTP.
            smtpClient.Credentials = new NetworkCredential(MailServer.Address, MailServer.Password);//Establecer las credenciales (Usuario y contraseña).
            smtpClient.Host = MailServer.Host;//Establecer el host.
            smtpClient.Port = MailServer.Port;//Establecer el puerto.
            smtpClient.EnableSsl = MailServer.SSL;//Establecir el cifrado SSL.
        }
        #endregion

        #region -> Métodos

        public void Send(string recipient, string subject, string body)
        {//Este método es responsable de enviar un mensaje de correo a un solo destinatario.

            var mailMessage = new MailMessage();//Inicializar el objeto mensaje de correo.
            var mailSender = new MailAddress(MailServer.Address, MailServer.DisplayName);//Inicializar el objeto dirección de correo electrónico remitente.

            try
            {
                mailMessage.From = mailSender;//Establecer la dirección de correo remitente.
                mailMessage.To.Add(recipient);//Establecer y agregar la dirección de correo destinatario.
                mailMessage.Subject = subject;//Establecer el asunto del mensaje de correo.
                mailMessage.Body = body;//Establecer el contenido del mensaje de correo.
                mailMessage.Priority = MailPriority.Normal;//Establecer la prioridad del mensaje de correo.

                smtpClient.Send(mailMessage);//Enviar el mensaje de correo mediante el cliente SMTP(Protocolo simple de transferencia de correo)
            }
            catch (SmtpException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                mailMessage.Dispose();               
            }
        }
        public void Send(List<string> recipients, string subject, string body)
        {//Este método es responsable de enviar un mensaje de correo a varios destinatarios.

            var mailMessage = new MailMessage();//Inicializar el objeto mensaje de correo.
            var mailSender = new MailAddress(MailServer.Address, MailServer.DisplayName);//Inicializar el objeto dirección de correo electrónico remitente.

            try
            {
                mailMessage.From = mailSender;//Establecer la dirección de correo remitente.
                foreach (var recipientMail in recipients)//Recorrer la lista de destinatarios para obtener cada dirección de correo.
                {
                    mailMessage.To.Add(recipientMail);//Agregar la dirección de correo destinatario a la colección de direcciones de correo.
                }
                mailMessage.Subject = subject;//Establecer el asunto del mensaje de correo.
                mailMessage.Body = body;//Establecer el contenido del mensaje de correo.
                mailMessage.Priority = MailPriority.Normal;//Establecer la prioridad del mensaje de correo.

                smtpClient.Send(mailMessage);//Enviar el mensaje de correo mediante el cliente SMTP(Protocolo simple de transferencia de correo)
            }
            catch (SmtpException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                mailMessage.Dispose();
            }
        }
        #endregion

    }
}
