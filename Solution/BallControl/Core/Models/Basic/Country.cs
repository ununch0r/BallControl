using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Core.Models.Basic
{
    public partial class Country
    {
        public Country()
        {
            Competitions = new HashSet<Competition>();
        }

        public byte Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FlagUrl { get; set; }

        public virtual ICollection<Competition> Competitions { get; set; }
    }
}
