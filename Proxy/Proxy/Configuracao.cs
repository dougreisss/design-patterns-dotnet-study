using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Configuracao : IConfiguracao
    {
        public void Inicializar()
        {
            Console.WriteLine("Configurações inicializadas");
        }
        public void Atualizar()
        {
            Console.WriteLine("Configurações Atualizadas");
        }

        public string GetConfig(string key)
        {
            Random rand = new Random();
            return $"Valor da configuração {key} é: {rand.NextInt64()}";
        }

        public void SetConfig(string key, string value)
        {
           Console.WriteLine($"Configurações setadas {key} --> {value}");
        }
    }
}
