using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Core.Models.Basic
{
    public partial class User
    {
        public User()
        {
            UserBets = new HashSet<UserBet>();
            UserRoles = new HashSet<UserRole>();
            UserSavedPredictions = new HashSet<UserSavedPrediction>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public virtual ICollection<UserBet> UserBets { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserSavedPrediction> UserSavedPredictions { get; set; }
    }
}
