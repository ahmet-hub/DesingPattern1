using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example2
{
    public abstract class CrossCuttingConcernsFactory
    {
        public enum Cacher
        {
            Memory,
            Redis
        }
        public enum Logger
        {
            Db,
            Email
        }
        public abstract ICacher CreateCacher(Cacher cacher);
        public abstract ILogger CreateLogger(Logger logger);
    }
}
