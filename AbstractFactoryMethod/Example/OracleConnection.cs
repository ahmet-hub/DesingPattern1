using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example
{
    public class OracleConnection : IConnection
    {
        public void Connection()
        {
            Console.WriteLine("Oracle Connection");
        }

        public void Disconnection()
        {
            Console.WriteLine("Oracle Disconnection");
        }
    }
}
