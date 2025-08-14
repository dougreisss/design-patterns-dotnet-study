using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Interface;

namespace Prototype.Model
{
    public class PersonagemA : Personagem, IPersonagemPrototype
    {
        public Personagem DeepCopy()
        {
            var result = (Personagem)this.MemberwiseClone();
            result.Arma = new Arma("Cajado");
            return result;
        }

        public Personagem ShallowCopy()
        {
            return (Personagem)this.MemberwiseClone();
        }
    }
}
