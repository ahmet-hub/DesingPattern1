using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example
{
    public interface IDbFactory
    {
        enum Db
        {
            Sql,
            Oracle
        }
        public  ICommand CreateCommand(Db db);
        public  IConnection CreateConnection(Db db);

    }
}
