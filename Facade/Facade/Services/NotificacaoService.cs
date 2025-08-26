using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Services
{
    public class NotificacaoService
    {
        public void EnviarNotificacao(string nome, string email)
        {
            Console.WriteLine($"Enviando confirmação de pedido para {nome} - {email}");
        }
    }
}
