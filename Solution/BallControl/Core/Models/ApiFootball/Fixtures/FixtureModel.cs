using System;

namespace Core.Models.ApiFootball.Fixtures
{
    public class FixtureModel
    {
        public int Id { get; set; }
        public string Referee { get; set; }
        public string Timezone { get; set; }
        public DateTime Date { get; set; }
        public string Timestamp { get; set; }
        public FixtureStatusModel Status { get; set; }
    }
}
