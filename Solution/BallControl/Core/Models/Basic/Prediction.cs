using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Core.Models.Basic
{
    public partial class Prediction
    {
        public Prediction()
        {
            PredictionPrerequisites = new HashSet<PredictionPrerequisite>();
            UserBets = new HashSet<UserBet>();
            UserSavedPredictions = new HashSet<UserSavedPrediction>();
        }

        public int Id { get; set; }
        public int FixtureId { get; set; }
        public string DisplayText { get; set; }
        public string Description { get; set; }
        public byte StatusId { get; set; }

        public virtual Fixture Fixture { get; set; }
        public virtual PredictionStatus Status { get; set; }
        public virtual ICollection<PredictionPrerequisite> PredictionPrerequisites { get; set; }
        public virtual ICollection<UserBet> UserBets { get; set; }
        public virtual ICollection<UserSavedPrediction> UserSavedPredictions { get; set; }
    }
}
