﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models.ApiFootball;
using Core.Providers;
using Providers.ApiFootball.Models;
using Providers.ApiFootball.Models.Competitions;
using RestSharp;

namespace Providers.ApiFootball.Providers
{
    public class CompetitionProvider : ICompetitionProvider
    {
        private readonly ApiFootballClient _client;
        private const string ApiPrefix = "leagues";

        public CompetitionProvider(ApiFootballClient client)
        {
            _client = client;
        }

        public async Task<IList<LeagueWrapperModel>> GetCompetitionsByCountryCodeAsync(string countryCode)
        {
            var request = new RestRequest(ApiPrefix).AddQueryParameter("code",countryCode);
            var response = await _client.GetAsync<IList<LeagueWrapperDto>>(request);
            return response.ToModels();
        }
    }
}
