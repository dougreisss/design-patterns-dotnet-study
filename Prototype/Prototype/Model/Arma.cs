using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Model
{
    public class Arma
    {
        public string Nome { get; set; }

        public Arma(string nomeArma)
        {
            Nome = nomeArma;
        }
    }
}
