using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<IEnumerable<Company>> List()
        {
            return null;
        }

        [HttpPost]
        public async Task<Company> Add(Company company)
        {
            return null;
        }
    }
}