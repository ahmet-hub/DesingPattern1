using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example2
{
    public class Factory : CrossCuttingConcernsFactory
    {
        public override ICacher CreateCacher(Cacher cacher)
        {
            switch (cacher)
            {
                case Cacher.Memory:
                    return new MemoryCacher();
                case Cacher.Redis:
                    return new RedisCacher();
                default: throw new Exception(message: "Invalid Model");
                 
            }
        }

        public override ILogger CreateLogger(Logger logger)
        {
            switch (logger)
            {
                    case Logger.Db:
                    return new DbLogger();
                    case Logger.Email:
                    return new EmailLogger();
                    default: throw new Exception(message: "Invalid Model");
                      
            }
        }
    }
}
