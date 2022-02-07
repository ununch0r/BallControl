using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models.ApiFootball;
using Core.Providers;
using Providers.ApiFootball.Models;
using Providers.ApiFootball.Models.Competitions;
using RestSharp;

namespace Providers.ApiFootball.Providers
{
    public class FixtureProvider : IFixtureProvider
    {
        private readonly ApiFootballClient _client;
        private const string ApiPrefix = "fixtures";

        public FixtureProvider(ApiFootballClient client)
        {
            _client = client;
        }

        public async Task<IList<LeagueWrapperModel>> GetFixturesByDateAsync(string date)
        {
            var request = new RestRequest(ApiPrefix).AddQueryParameter("date", date);
            var response = await _client.GetAsync<IList<LeagueWrapperDto>>(request);
            return response.ToModels();
        }
    }
}
