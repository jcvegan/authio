using System;
using Microsoft.AspNetCore.Identity;

namespace Authio.Data.Identity.Entities {
    public class AuthUserClaim : IdentityUserClaim<Guid>
    {
        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }
    }
}