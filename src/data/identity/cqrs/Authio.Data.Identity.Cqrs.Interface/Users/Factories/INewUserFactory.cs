using System;
using System.Threading;
using System.Threading.Tasks;
using Authio.Data.Identity.Entities;

namespace Authio.Data.Identity.Cqrs.Interface.Users.Factories
{
    public interface INewUserFactory
    {
        /// <summary>
        /// <strong>Factory Method</strong>
        /// Build a new instance of <see cref="AuthUser"/>
        /// </summary>
        /// <param name="username">The name of the user</param>
        /// <param name="mailAddress">The e-mail of the user</param>
        /// <param name="phoneNumber">The phone number associated to the account</param>
        /// <param name="firstName">The first name of the person</param>
        /// <param name="lastName">The last name of the person</param>
        /// <param name="dateOfBirth">The date of birth of the person</param>
        /// <param name="isTwoFactorEnable">Allow to factor authentication for the account</param>
        /// <returns></returns>
        Task<AuthUser> BuildUserAsync(
            string username,
            string mailAddress,
            string phoneNumber,
            string firstName,
            string lastName,
            DateTime? dateOfBirth,
            bool isTwoFactorEnable,
            CancellationToken cancellationToken = new CancellationToken());
    }
}