using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example
{
    public class WindowsScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("WindowsScreen");
        }
    }
}
