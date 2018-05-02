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
        public DbSet<Temp> Temps { get; set; }
        public DbSet<TestTypeName> TestTypeNames { get; set; }
        public DbSet<TestTypeCategory> TestTypeCategories { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<TSH> TSHs { get; set; }
        public DbSet<T3T4> T3T4s { get; set; }
        public DbSet<USGPiersi> USGPiersis { get; set; }
        public DbSet<USGSerca> USGSercas { get; set; }
        public DbSet<USGSzyi> USGSzyis { get; set; }
        public DbSet<Morf> Morves { get; set; }
        public DbSet<Morf5> Morves5 { get; set; }
        public DbSet<Mocz> Moczs { get; set; }
        public DbSet<Glukoza> Glukozas { get; set; }
        public DbSet<Krzywa> Krzywas { get; set; }
        public DbSet<BetaHCG> BetaHCGs { get; set; }
        public DbSet<Estrogen> Estrogens { get; set; }
        public DbSet<OGTT> OGTTs { get; set; }
        public DbSet<Progesteron> Progesterons { get; set; }
        public DbSet<Szpik> Szpiks { get; set; }
             

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
