using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ConfiguracaoProxy : IConfiguracao
    {
        Configuracao _configuracao = new Configuracao();

        public void Atualizar()
        {
            _configuracao.Atualizar();
        }

        public string GetConfig(string key)
        {
           return _configuracao.GetConfig(key);   
        }

        public void Inicializar()
        {
            _configuracao.Inicializar();
        }

        public void SetConfig(string key, string value)
        {
            _configuracao.SetConfig(key, value);
        }
    }
}
