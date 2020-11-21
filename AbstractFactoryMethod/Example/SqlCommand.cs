using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example
{
    public class SqlCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Sql Execute");
        }
    }
}
