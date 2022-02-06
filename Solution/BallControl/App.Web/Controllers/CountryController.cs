using System.Threading.Tasks;
using Core.Managers;
using Core.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace App.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryManager _countryManager;
        private readonly ICompetitionProvider _competitionProvider;

        public CountryController(ICountryManager countryManager, ICompetitionProvider competitionProvider)
        {
            _countryManager = countryManager;
            _competitionProvider = competitionProvider;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var countries = _countryManager.GetAll();
            //add mapping to VM
            return Ok(countries);
        }

        [HttpGet]
        [Route("leagues")]
        public async Task<IActionResult> GetLeaguesAsync()
        {
            var competitions = await _competitionProvider.GetCompetitionsByCountryCodeAsync("it");
            //add mapping to VM
            return Ok(competitions);
        }
    }
}
