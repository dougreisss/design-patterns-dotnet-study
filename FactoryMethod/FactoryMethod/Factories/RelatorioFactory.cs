using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public abstract class RelatorioFactory
    {
        public abstract IRelatorio CriarRelatorio();
    }
}
