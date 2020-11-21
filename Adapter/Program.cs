using Adapter.Example;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
             CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
             customerManager.Save(new Customer { Id = 1, IdentityNumber = "11111111111", Name = "Ahmet", LastName = "Yardımcı", DateOfBirth = new DateTime(1998, 7, 28) });           
        }
    }


}
