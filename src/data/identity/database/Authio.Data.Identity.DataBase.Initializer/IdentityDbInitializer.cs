using System;
using Authio.Data.Identity.DataBase.EntityFrameworkCore.Factory;
using Authio.Data.Identity.DataBase.Model;
using Authio.Data.Identity.DataBase.Stores;
using Authio.Data.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Authio.Data.Identity.DataBase.Initializer
{
    public static class IdentityDbInitializer
    {
        public static IServiceCollection AddAuthioDatabase(
            this IServiceCollection services,
            Action<DbContextOptionsBuilder> optionsAction,
            Action<IdentityOptions> identityAction)
        {
            services.AddDbContext<AuthioIdentityContext>(optionsAction);

            services.AddDefaultIdentity<AuthUser>(identityAction)
                .AddRoles<AuthRole>()
                .AddUserStore<AuthioUserStore>()
                .AddRoleStore<AuthioRoleStore>()
                .AddClaimsPrincipalFactory<AuthUserClaimsPrincipalFactory>()
                .AddDefaultTokenProviders();

            return services;
        }
    }
}
