using System.Collections.Generic;
using EFCorePractice.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCorePractice.Controllers
{
    [ApiController]
    [Route("companies")]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Company> List()
        {
            return null;
        }

        [HttpPost]
        public Company Add(Company company)
        {
            return null;
        }

    }
}
