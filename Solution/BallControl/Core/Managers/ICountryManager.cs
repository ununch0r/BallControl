using Core.Models.Basic;
using System.Collections.Generic;

namespace Core.Managers
{
    public interface ICountryManager
    {
        IList<Country> GetAll();
    }
}
