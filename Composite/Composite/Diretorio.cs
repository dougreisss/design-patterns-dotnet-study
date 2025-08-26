using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Component
    public abstract class Diretorio
    {
        public string Nome {  get; set; }
        public Diretorio(string nome) { this.Nome = nome; }   
        public abstract void Mostrar();

        public virtual void Add(Diretorio pasta)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Diretorio pasta)
        {
            throw new NotImplementedException();
        }

        public virtual Diretorio Get(int index)
        {
            throw new NotImplementedException();
        }
    }
}
