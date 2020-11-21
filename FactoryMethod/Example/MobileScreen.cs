using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example
{
    public class MobileScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("Mobile Screen");
        }
    }
}
