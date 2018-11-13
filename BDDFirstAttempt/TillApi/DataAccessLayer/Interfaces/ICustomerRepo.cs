using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TillApi.Models;

namespace TillApi.DataAccessLayer.Interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomer(int id);
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void RemoveCustomer(int id);
    }
}
