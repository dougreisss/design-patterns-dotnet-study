using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Model;

namespace Prototype.Interface
{
    public interface IPersonagemPrototype
    {
        Personagem ShallowCopy();
        Personagem DeepCopy();
    }
}
