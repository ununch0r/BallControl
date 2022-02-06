using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Core.Models.Basic
{
    public partial class Fixture
    {
        public Fixture()
        {
            Predictions = new HashSet<Prediction>();
        }

        public int Id { get; set; }
        public short CompetitionId { get; set; }
        public DateTime UtcDate { get; set; }

        public virtual Competition Competition { get; set; }
        public virtual ICollection<Prediction> Predictions { get; set; }
    }
}
