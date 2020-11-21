using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example2
{
    public class EmailLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log with Email Logger");
        }
    }
}
