using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example2
{
    public class CustomerManager
    {

        private Factory _factory;
        public CustomerManager(Factory factory)
        {
            _factory = factory;

        }
        public void Save()
        {
            _factory.CreateCacher(CrossCuttingConcernsFactory.Cacher.Memory).Cache();

            Console.WriteLine("Customer Save");
            _factory.CreateLogger(CrossCuttingConcernsFactory.Logger.Email).Log();
        }
    }
}
