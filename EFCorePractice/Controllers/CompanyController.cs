using System.Collections.Generic;
using System.Linq;
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
        private readonly EFDBContext _efdbContext;

        public CompanyController(EFDBContext efdbContext)
        {
            _efdbContext = efdbContext;
        }

        [HttpGet]
        public IEnumerable<Company> List()
        {
            using (_efdbContext)
            {
                return _efdbContext.Companies.ToList();
            }
        }

        [HttpPost]
        public async Task<Company> Add(Company company)
        {
            using (_efdbContext)
            {
                var addedCompany = this._efdbContext.Add(company).Entity;
                await this._efdbContext.SaveChangesAsync();
                return addedCompany;
            }
        }
    }
}