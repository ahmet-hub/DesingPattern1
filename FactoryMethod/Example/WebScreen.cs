using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example
{
    public class WebScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("Web Screen");
        }
    }
}
