using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Core.Models.Basic
{
    public partial class StatisticType
    {
        public StatisticType()
        {
            PredictionPrerequisites = new HashSet<PredictionPrerequisite>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<PredictionPrerequisite> PredictionPrerequisites { get; set; }
    }
}
