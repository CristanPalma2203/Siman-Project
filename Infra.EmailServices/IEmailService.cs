using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EmailServices
{
    interface IEmailService
    {//Define métodos públicos de la clase EmailService
        void Send(string recipient,string subject, string body);
        void Send(List<string> recipients, string subject, string body);    
    }
}
