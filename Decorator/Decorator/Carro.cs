using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Concrete Component
    public sealed class Carro : ICarro
    {
        public string RetornarCarro()
        {
            string carro = "Esse é um carro básico: ";
            return carro;
        }
    }
}
