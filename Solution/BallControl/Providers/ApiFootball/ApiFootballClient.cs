using System.Collections.Generic;
using RestSharp;

namespace Providers.ApiFootball
{
    public class ApiFootballClient
    {
        public readonly RestClient Client;

        public ApiFootballClient()
        {
            var headers = new Dictionary<string, string>
            {
                {"x-rapidapi-host", "api-football-v1.p.rapidapi.com"},
                {"x-rapidapi-key", "ce54e36d64msh605fbf99d93fd76p148c19jsnf59cd9c166d8"}
            };

            Client = new RestClient("https://api-football-v1.p.rapidapi.com/v3")
                .AddDefaultHeaders(headers);
        }
    }
}
