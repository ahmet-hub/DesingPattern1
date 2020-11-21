using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example
{
    public class DbFactoryConcrete : IDbFactory
    {
        public ICommand CreateCommand(IDbFactory.Db db)
        {
            ICommand command = null;



            switch (db)
            {
                case IDbFactory.Db.Sql:
                    command = new SqlCommand();
                    break;
                case IDbFactory.Db.Oracle:

                    command = new OracleCommand();
                    break;
                default:
                    break;
            }

            return command;
        }

        public IConnection CreateConnection(IDbFactory.Db db)
        {
            IConnection connection = null;
            switch (db)
            {
                case IDbFactory.Db.Sql:
                    connection = new SqlConnection();

                    break;
                case IDbFactory.Db.Oracle:
                    connection = new OracleConnection();
                    break;
                default:
                    break;
            }
            return connection;
        }
    }

}
