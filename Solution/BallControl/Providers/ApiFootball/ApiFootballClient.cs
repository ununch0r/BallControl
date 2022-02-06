using System.Collections.Generic;
using RestSharp;

namespace Providers.ApiFootball
{
    public class ApiFootballClient
    {
        public readonly RestClient Client;

        public ApiFootballClient(string host, string key)
        {
            var headers = new Dictionary<string, string>
            {
                {"x-rapidapi-host", host},
                {"x-rapidapi-key", key}
            };

            Client = new RestClient("https://api-football-v1.p.rapidapi.com/v3")
                .AddDefaultHeaders(headers);
        }
    }
}
