using AbstractFactoryMethod.Example;
using System;

namespace AbstractFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager(new Factory());
            //customerManager.GetAll();


            //DbFactoryConcrete SqlDbFactory = new DbFactoryConcrete();

            //SqlDbFactory.CreateCommand(IDbFactory.Db.Sql).Execute();
            //SqlDbFactory.CreateConnection(IDbFactory.Db.Sql).Connection();

            //Console.WriteLine(" ");

            //DbFactoryConcrete OracleDbFactory = new DbFactoryConcrete();

            //OracleDbFactory.CreateCommand(IDbFactory.Db.Oracle).Execute();
            //OracleDbFactory.CreateConnection(IDbFactory.Db.Oracle).Connection();

            //Console.WriteLine(" ");


            //Client client1 = new Client(new SqlFactory());
            //client1.Start();

            //Console.WriteLine(" ");

            //Client client2 = new Client(new OracleFactory());
            //client2.Start();

            Example.Client client = new Client(new SqlFactory());
            client.Start();


            //Example2.CustomerManager customerManager = new Example2.CustomerManager(new Example2.Factory());
            //customerManager.Save();

        }

    }


}

