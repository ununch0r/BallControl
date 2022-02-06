using Core.Managers;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryManager _countryManager;

        public CountryController(ICountryManager countryManager)
        {
            _countryManager = countryManager;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var countries = _countryManager.GetAll();
            //add mapping to VM
            return Ok(countries);
        }
    }
}
