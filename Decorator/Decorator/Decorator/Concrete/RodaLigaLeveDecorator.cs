using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Decorator.Base;

namespace Decorator.Decorator.Concrete
{
    public class RodaLigaLeveDecorator : CarroDecorator
    {
        public RodaLigaLeveDecorator(ICarro carro) : base(carro)
        {
        }

        public override string RetornarCarro()
        {
            return base.RetornarCarro() + " com Roda de Liga Leve";
        }
    }
}
