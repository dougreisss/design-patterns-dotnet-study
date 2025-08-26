using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class PastaLeaf : Diretorio
    {
        public PastaLeaf(string nome) : base(nome) { }
        public override void Mostrar()
        {
            Console.WriteLine(this.Nome);
        }

    }
}
