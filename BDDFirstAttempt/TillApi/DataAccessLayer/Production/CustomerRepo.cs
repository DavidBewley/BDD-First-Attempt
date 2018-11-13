using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TillApi.DataAccessLayer.Interfaces;
using TillApi.Models;

namespace TillApi.DataAccessLayer.Production
{
    public class CustomerRepo : ICustomerRepo
    {
        public void CreateCustomer(Customer customer)
        {          
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
