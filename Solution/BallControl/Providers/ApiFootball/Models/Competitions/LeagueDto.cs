using Core.Models.ApiFootball;

namespace Providers.ApiFootball.Models.Competitions
{
    public class LeagueDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Logo { get; set; }
    }

    public static class LeagueDtoMapper
    {
        public static LeagueModel ToModel(this LeagueDto dto)
        {
            return new LeagueModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Type = dto.Type,
                Logo = dto.Logo
            };
        }
    }
}
