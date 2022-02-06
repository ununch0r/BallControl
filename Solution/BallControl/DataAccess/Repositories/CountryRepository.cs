using Core.Models.Basic;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Context;

namespace DataAccess.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly BallControlContext _ballControlContext;

        public CountryRepository(BallControlContext ballControlContext)
        {
            _ballControlContext = ballControlContext;
        }

        public Country GetById()
        {
            throw new NotImplementedException();
        }

        public IList<Country> GetAll()
        {
            return _ballControlContext.Countries.ToList();
        }

        public void Add(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
