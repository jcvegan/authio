using System;
using System.Threading;
using System.Threading.Tasks;
using Authio.Data.Identity.Cqrs.Interface.Users.Factories;
using Authio.Data.Identity.Entities;

namespace Authio.Data.Identity.Cqrs.Users.Factories
{
    public class NewUserFactory : INewUserFactory
    {
        public async Task<AuthUser> BuildUserAsync(
            string username,
            string mailAddress,
            string phoneNumber,
            string firstName,
            string lastName,
            DateTime? dateOfBirth,
            bool isTwoFactorEnable,
            CancellationToken cancellationToken = new CancellationToken())
        {
            var user = new AuthUser();
            
            user.Id = Guid.NewGuid();

            user.UserName = username;

            user.FirstName = firstName;

            user.LastName = lastName;

            user.Email = mailAddress;

            user.PhoneNumber = phoneNumber;

            user.DateOfBirth = dateOfBirth;

            cancellationToken.ThrowIfCancellationRequested();

            return await Task.FromResult(user);
        }
    }
}