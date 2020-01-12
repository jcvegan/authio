using System;
using Authio.Data.Identity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authio.Data.Identity.DataBase.Model
{
    public class AuthioIdentityContext : IdentityDbContext<AuthUser,AuthRole, Guid, AuthUserClaim, AuthUserRole, AuthUserLogin, AuthRoleClaim, AuthUserToken>

    {
        public AuthioIdentityContext(DbContextOptions<AuthioIdentityContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AuthRole>().ToTable(schema: "Identity", name: "Roles");

            builder.Entity<AuthRoleClaim>().ToTable(schema: "Identity", name: "RoleClaims");

            builder.Entity<AuthUser>().ToTable(schema: "Identity", name: "Users");

            builder.Entity<AuthUserClaim>().ToTable(schema: "Identity", name: "UserClaims");

            builder.Entity<AuthUserLogin>().ToTable(schema: "Identity", name: "UserLogins");

            builder.Entity<AuthUserRole>().ToTable(schema: "Identity", name: "UserRoles");

            builder.Entity<AuthUserToken>().ToTable(schema: "Identity", name: "UserTokens");
        }
    }
}
