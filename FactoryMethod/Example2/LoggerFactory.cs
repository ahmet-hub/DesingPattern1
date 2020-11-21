using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example2
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger(ILoggerFactory.logger logger)
        {
            switch (logger)
            {
                case ILoggerFactory.logger.DbLogger:
                    return new DbLogger();

                case ILoggerFactory.logger.EmailLogger:
                    return new EmailLogger();
                default: throw new Exception(message: "Invalid Model");

            }

        }
    }
}
