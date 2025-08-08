using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    public class CsvRelatorio : IRelatorio
    {
        public void Exportar()
        {
            Console.WriteLine($"Exportando CSV");
        }
    }
}
