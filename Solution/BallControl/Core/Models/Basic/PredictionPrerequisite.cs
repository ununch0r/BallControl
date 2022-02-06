

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Core.Models.Basic
{
    public partial class PredictionPrerequisite
    {
        public int Id { get; set; }
        public int PredictionId { get; set; }
        public int FixtureId { get; set; }
        public byte StatisticTypeId { get; set; }
        public decimal Value { get; set; }

        public virtual Prediction Prediction { get; set; }
        public virtual StatisticType StatisticType { get; set; }
    }
}
