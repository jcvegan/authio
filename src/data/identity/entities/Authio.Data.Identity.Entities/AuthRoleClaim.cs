using System;
using Microsoft.AspNetCore.Identity;

namespace Authio.Data.Identity.Entities {
    public class AuthRoleClaim : IdentityRoleClaim<Guid>
    {
        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }
    }
}