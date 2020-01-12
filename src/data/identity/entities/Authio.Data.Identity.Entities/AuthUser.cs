using System;
using Microsoft.AspNetCore.Identity;

namespace Authio.Data.Identity.Entities
{
    public class AuthUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }
    }
}