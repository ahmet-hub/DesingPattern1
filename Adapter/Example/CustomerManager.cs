using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Example
{
    public class CustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;

        }
        public void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {

                Console.WriteLine("Customer Save");

            }
            else
            {
                Console.WriteLine("Invalid Customer");
            }

        }
    }
}
