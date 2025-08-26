using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class DiretorioComposite : Diretorio
    {
        protected List<Diretorio> _children = new();

        public DiretorioComposite(string nome) : base(nome) { }
       
        public override void Mostrar()
        {
            Console.WriteLine(string.Concat(this.Nome, "\n\t", string.Join("\n\t", _children.ToList().Select( (pastas) => pastas.Nome))));
        }

        public override void Add(Diretorio pasta)
        {
            this._children.Add(pasta);
        }

        public override void Remove(Diretorio pasta)
        {
            this._children.Remove(pasta);
        }

        public override Diretorio Get(int index)
        {
            return this._children[index];
        }
    }
}
