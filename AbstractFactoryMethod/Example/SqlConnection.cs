using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example
{
    public class SqlConnection : IConnection
    {
        public void Connection()
        {
            Console.WriteLine("Sql Connection");
        }

        public void Disconnection()
        {
            Console.WriteLine("Sql Disconnection");
        }
    }
}
