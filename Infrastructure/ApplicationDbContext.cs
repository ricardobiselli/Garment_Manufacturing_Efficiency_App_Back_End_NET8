using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Users;
using Domain.Models.Garments;


namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<FloorAdmin>FloorAdmins { get; set; }
        public DbSet<Garment> Garments { get; set; }
        public DbSet<Operation> Operations { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Garment>()
            .HasMany(o => o.Operations)
            .WithOne(g => g.Garment)
            .HasForeignKey(f => f.GarmentId)
            .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
