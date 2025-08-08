using FactoryMethod.Interface;
using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public class CsvRelatorioFactory : RelatorioFactory
    {
        public override IRelatorio CriarRelatorio()
        {
            return new CsvRelatorio();
        }
    }
}
