using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example2
{
    public class RedisCacher : ICacher
    {
        public void Cache()
        {
            Console.WriteLine("Cache with Redis Cacher");
        }
    }
}
