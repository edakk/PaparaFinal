using EdaKok_PaparaFinalProject.Papara.Data.Configuration;
using Microsoft.EntityFrameworkCore;

using Papara.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papara.Data.Context
{
    public class FDbContext : DbContext
    {
        public FDbContext(DbContextOptions<FDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public  DbSet<Role> Roles { get; set; }
        public DbSet<Apartment> Apartments { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Message> Messages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

    }
}
