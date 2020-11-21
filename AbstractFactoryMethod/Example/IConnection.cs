using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example
{
    public interface IConnection
    {
        public void Connection();
        public void Disconnection();
    }
}
