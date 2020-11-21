using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example
{
    public class OracleCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Oracle Execute");
        }
    }
}
