using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Core.Models.Basic
{
    public partial class PredictionStatus
    {
        public PredictionStatus()
        {
            Predictions = new HashSet<Prediction>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Prediction> Predictions { get; set; }
    }
}
