using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example
{
    public abstract class DbFactory
    {
        public abstract ICommand CreateCommand();
        public abstract IConnection CreateConnection();

    }
}
