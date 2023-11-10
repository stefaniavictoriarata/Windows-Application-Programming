using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class ClientContext : DbContext
    {
        public ClientContext()
        {
            try
            {
                Database.Migrate();
            }
            catch (Exception)
            {
                Console.WriteLine("Database already exists." +
                    " No additional migration have to be applied.");
            }
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ExtraOption> ExtraOptions { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "User ID=postgres;Password=dianavilceanu123;Server=localhost;Port=5432;Database=PhoneService;Integrated Security=true;Pooling=true";
                optionsBuilder.UseNpgsql(connectionString);
            }
        }

    }
}
