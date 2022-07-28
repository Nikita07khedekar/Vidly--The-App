﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(255)]
        public string DrivingLicense { get; set; }

        public decimal Phone { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       public  DbSet<Movie> movies { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<MembershipType> membershipTypes { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Rental> rentals { get; set; }
        public ApplicationDbContext()
            : base("N_Context", throwIfV1Schema: false)
        {

    }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
  
    }
}