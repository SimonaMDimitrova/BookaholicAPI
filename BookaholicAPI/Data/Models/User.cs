using Microsoft.AspNetCore.Identity;

namespace BookaholicAPI.Data.Models
{
    public class UserProfile
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public Country Country { get; set; }

        public string? CountryId { get; set; }

        public string? Description { get; set; }

        public DateTime Birthdate { get; set; }

        public ICollection<IdentityUser>? Users { get; set; }
    }
}
