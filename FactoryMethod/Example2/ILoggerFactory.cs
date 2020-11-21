using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example2
{
    public interface ILoggerFactory
    {
        enum logger
        {
            DbLogger,
            EmailLogger
           
        }
        public ILogger CreateLogger(logger logger);
    }
}
