using System;
using Microsoft.AspNetCore.Identity;

namespace Authio.Data.Identity.Entities {
    public class AuthRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }
    }
}