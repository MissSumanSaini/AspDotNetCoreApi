using AspDotNetCoreApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreApi.respository
{
    public class CustomerService : ICustomer
    {
        private CustomerContext context = new CustomerContext();
        public Customer AddCustomer(Customer customer)
        {
            context.customers.Add(customer);
            context.SaveChanges();
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            return context.customers.ToList();
        }

        public string SendMail()
        {
            return "mail sended";
        }
    }
}
