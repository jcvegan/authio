using System.Security.Claims;
using System.Threading.Tasks;
using Authio.Data.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Authio.Data.Identity.DataBase.EntityFrameworkCore.Factory
{
    public class AuthUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<AuthUser>
    {
        public AuthUserClaimsPrincipalFactory(UserManager<AuthUser> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor) { }

        public override async Task<ClaimsPrincipal> CreateAsync(AuthUser user)
        {
            var principal = await base.CreateAsync(user);

            ((ClaimsIdentity)principal.Identity).AddClaims(new Claim[]
            {
                new Claim(ClaimTypes.GivenName, user.FirstName),
                new Claim(ClaimTypes.Surname, user.LastName),
                new Claim(ClaimTypes.DateOfBirth, user.DateOfBirth?.ToString("u")) 
            });

            return principal;
        }
    }
}