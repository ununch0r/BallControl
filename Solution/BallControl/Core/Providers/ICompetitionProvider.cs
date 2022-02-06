using System.Threading.Tasks;

namespace Core.Providers
{
    public interface ICompetitionProvider
    {
        Task<object> GetCompetitionsByCountryCode(string countryCode);
    }
}
