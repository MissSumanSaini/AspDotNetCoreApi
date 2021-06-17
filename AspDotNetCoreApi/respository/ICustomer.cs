using AspDotNetCoreApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreApi.respository
{
    public  interface ICustomer
    {
        Customer AddCustomer(Customer customer);
        List<Customer> GetCustomers();
    }
}
