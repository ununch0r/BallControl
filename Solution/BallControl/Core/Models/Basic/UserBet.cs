using System;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Core.Models.Basic
{
    public partial class UserBet
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PredictionId { get; set; }
        public decimal Multiplier { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDateUtc { get; set; }

        public virtual Prediction Prediction { get; set; }
        public virtual User User { get; set; }
    }
}
