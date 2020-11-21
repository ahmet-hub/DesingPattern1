using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Example
{
    public class CustomerCheckService : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true; //Fake
        }
    }
}
