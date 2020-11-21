using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod.Example
{
    public class Client
    {
        private DbFactory _dbFactory;
        private IConnection _connection;
        private ICommand _command;
        public Client(DbFactory dbFactory)
        {
            _dbFactory = dbFactory;
            _connection = _dbFactory.CreateConnection();
            _command = _dbFactory.CreateCommand();
        }

       


        public void Start()
        {
            _connection.Connection();
            _command.Execute();
        }
    }
}
