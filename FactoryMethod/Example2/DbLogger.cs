using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example2
{
    public class DbLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log with DbLogger");
        }
    }
}
