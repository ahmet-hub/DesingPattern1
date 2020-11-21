using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example
{
    public class OracleFactory : DbFactory
    {
        public override ICommand CreateCommand()
        {
            return new OracleCommand();
        }

        public override IConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
