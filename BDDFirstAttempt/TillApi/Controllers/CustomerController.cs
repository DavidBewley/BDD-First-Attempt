using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TillApi.DataAccessLayer.Interfaces;
using TillApi.DataAccessLayer.Production;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;

namespace TillApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private ICustomerRepo _customerRepo;

         public CustomerController(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var customerList = _customerRepo.GetAllCustomers();
            string data = JsonConvert.SerializeObject(customerList);

            return Ok(data);
        }
    }
}