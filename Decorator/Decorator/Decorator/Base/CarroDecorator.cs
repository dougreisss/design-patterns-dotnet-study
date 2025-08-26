using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator.Base
{
    // Decorator (Base)
    public class CarroDecorator : ICarro
    {
        private readonly ICarro _carro;

        public CarroDecorator(ICarro carro)
        {
            this._carro = carro;
        }
        public virtual string RetornarCarro()
        {
           return this._carro.RetornarCarro();
        }
    }
}
