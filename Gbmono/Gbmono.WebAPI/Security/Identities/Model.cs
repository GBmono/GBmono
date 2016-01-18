﻿using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Gbmono.WebAPI.Security.Identities
{
    // You can add profile data for the user by adding more properties to your GbmonoUser class
    public class GbmonoUser : IdentityUser
    {
        // create user instance
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<GbmonoUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    // DbContext which uses a custom user entity with a string primary key
    public class GBmonoUserDbContext : IdentityDbContext<GbmonoUser>
    {
        // constructor with default sql connection string
        public GBmonoUserDbContext(): base("GbnomuUser", throwIfV1Schema: false)
        {
        }

        public static GBmonoUserDbContext Create()
        {
            return new GBmonoUserDbContext();
        }
    }
}