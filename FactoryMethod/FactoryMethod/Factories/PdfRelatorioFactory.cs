using FactoryMethod.Interface;
using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public class PdfRelatorioFactory : RelatorioFactory
    {
        public override IRelatorio CriarRelatorio()
        {
            return new PdfRelatorio();
        }
    }
}
