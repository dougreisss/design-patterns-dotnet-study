using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Mac
{
    public class MacUIFactory : IUIFactory
    {
        public IBotao CriarBotao()
        {
            return new MacBotao();
        }

        public ICheckbox CriarCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
