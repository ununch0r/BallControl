using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Core.Models.Basic
{
    public partial class Competition
    {
        public Competition()
        {
            Fixtures = new HashSet<Fixture>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public byte CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Fixture> Fixtures { get; set; }
    }
}
