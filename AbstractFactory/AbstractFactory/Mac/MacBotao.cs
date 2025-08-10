using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Mac
{
    public class MacBotao : IBotao
    {
        public void Render()
        {
            Console.WriteLine("Mac botão");
        }
    }
}
