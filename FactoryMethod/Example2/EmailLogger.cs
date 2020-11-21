using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example2
{
    public class EmailLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Email Logger");
        }
    }
}
