using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Windows
{
    public class WindowsBotao : IBotao
    {
        public void Render()
        {
            Console.WriteLine("Windows botão");
        }
    }
}
