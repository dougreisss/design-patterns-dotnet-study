using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Mac
{
    public class MacCheckbox : ICheckbox
    {
        public void Marcar()
        {
            Console.WriteLine("Mac Checkbox");
        }
    }
}
