using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;

namespace Adapter.Example
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var response = kPSPublicSoapClient.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.IdentityNumber), customer.Name.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            return response.Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
