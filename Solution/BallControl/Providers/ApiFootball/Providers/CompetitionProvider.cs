using System.Threading.Tasks;
using Core.Models.ApiFootball;
using Core.Providers;
using Providers.ApiFootball.Models;
using RestSharp;

namespace Providers.ApiFootball.Providers
{
    public class CompetitionProvider : ICompetitionProvider
    {
        private readonly ApiFootballClient _client;

        public CompetitionProvider(ApiFootballClient client)
        {
            _client = client;
        }

        public async Task<object> GetCompetitionsByCountryCode(string countryCode)
        {
            var request = new RestRequest($"leagues?code={countryCode}");
            var response = await _client.Client.GetAsync<GenericResponseModel<LeagueWrapperDto>>(request);
            return response;
        }
    }
}
