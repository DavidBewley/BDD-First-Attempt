using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TillApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AliveController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}