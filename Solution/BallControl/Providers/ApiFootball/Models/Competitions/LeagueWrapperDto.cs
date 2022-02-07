using System.Collections.Generic;
using System.Linq;
using Core.Models.ApiFootball;

namespace Providers.ApiFootball.Models.Competitions
{
    public class LeagueWrapperDto
    {
        public LeagueDto League { get; set; }
    }

    public static class LeagueWrapperDtoMapper
    {
        public static LeagueWrapperModel ToModel(this LeagueWrapperDto dto)
        {
            return new LeagueWrapperModel
            {
                League = dto.League.ToModel()
            };
        }

        public static IList<LeagueWrapperModel> ToModels(this IList<LeagueWrapperDto> dtos)
        {
            return dtos == null ? new List<LeagueWrapperModel>() : dtos.Select(dto => dto.ToModel()).ToList();
        }
    }
}
