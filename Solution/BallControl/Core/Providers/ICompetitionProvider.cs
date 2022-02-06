﻿using Core.Models.ApiFootball;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Providers
{
    public interface ICompetitionProvider
    {
        Task<IList<LeagueWrapperDto>> GetCompetitionsByCountryCodeAsync(string countryCode);
    }
}
