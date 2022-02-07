using System;

namespace Providers.ApiFootball.Models.Fixtures
{
    public class FixtureDto
    {
        public int Id { get; set; }
        public string Referee { get; set; }
        public string Timezone { get; set; }
        public DateTime Date { get; set; }
        public string Timestamp { get; set; }
        public FixtureStatusDto Status { get; set; }
    }
}
