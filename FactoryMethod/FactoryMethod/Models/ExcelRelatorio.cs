using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    public class ExcelRelatorio : IRelatorio
    {
        public void Exportar()
        {
            Console.WriteLine($"Exportando Excel");
        }
    }
}
