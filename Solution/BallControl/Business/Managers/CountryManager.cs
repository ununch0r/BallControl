using Core.Managers;
using Core.Models.Basic;
using Core.Repositories;
using System.Collections.Generic;

namespace Business.Managers
{
    public class CountryManager : ICountryManager
    {
        private readonly ICountryRepository _countryRepository;

        public CountryManager(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IList<Country> GetAll()
        {
            return _countryRepository.GetAll();
        }
    }
}
