using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Windows
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Marcar()
        {
            Console.WriteLine("Windows Checkbox");
        }
    }
}
