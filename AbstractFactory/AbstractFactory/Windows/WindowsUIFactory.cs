using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Windows
{
    public class WindowsUIFactory : IUIFactory
    {
        public IBotao CriarBotao()
        {
            return new WindowsBotao();
        }

        public ICheckbox CriarCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
