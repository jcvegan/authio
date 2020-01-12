using System;
using Authio.Data.Identity.DataBase.Model;
using Authio.Data.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Authio.Data.Identity.DataBase.Stores
{
    public class AuthioUserStore : UserStore<AuthUser, AuthRole, AuthioIdentityContext, Guid>
    {
        public AuthioUserStore(AuthioIdentityContext context, IdentityErrorDescriber describer = null) : base(context, describer) { }
    }
}