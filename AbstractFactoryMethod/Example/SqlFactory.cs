using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example
{
    public class SqlFactory : DbFactory
    {
        public override ICommand CreateCommand()
        {
            return new SqlCommand();
        }
        public override IConnection CreateConnection()
        {
            return new SqlConnection();
        }
    }
}
