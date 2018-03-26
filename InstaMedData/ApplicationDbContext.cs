using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InstaMedData.Models;

namespace InstaMedData
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
     
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public new DbSet<Role> Roles { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<TestTypeName> TestTypeNames { get; set; }
        public DbSet<TestTypeCategory> TestTypeCategories { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<TSH> TSHs { get; set; }


      

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
