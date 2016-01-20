using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Gbmono.WebAPI.Security.Identities
{
    // You can add profile data for the user by adding more properties to your GbmonoUser class
    public class GbmonoUser : IdentityUser
    {
        [ForeignKey("UserProfile")]
        public int UserProfileId { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        // create user instance
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<GbmonoUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserProfileId { get; set; }

        public string DisplayName { get; set; }

        public double? Lat { get; set; }
        public double? Long { get; set; }
        public int? EnableSMS { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreateTime { get; set; }

    }

    [Table("UserDeviceToken")]
    public class UserDeviceToken
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserDeviceTokenId { get; set; }
        public int UserId { get; set; }
        public string DeviceToken { set; get; }
        public bool Active { set; get; }
    }



    // DbContext which uses a custom user entity with a string primary key
    public class GBmonoUserDbContext : IdentityDbContext<GbmonoUser>
    {
        // constructor with default sql connection string
        public GBmonoUserDbContext() : base("GbmonoUserSqlConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<UserDeviceToken> UserDeviceToken { get; set; }

        public static GBmonoUserDbContext Create()
        {
            return new GBmonoUserDbContext();
        }
    }
}