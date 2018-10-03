using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Database
{
    public class BuildDBContext : DbContext
    {
        private readonly string _connectionString;

        public BuildDBContext(DbContextOptions<BuildDBContext> options, IConfiguration configuration) : base(options)
        {
            _connectionString = configuration.GetConnectionString("BuildDbContext");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString, p =>
            {
                p.MigrationsHistoryTable("ef_core_migrations_history", "builddb");
            });
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("builddb");
            CreateTables(modelBuilder);
        }

        private void CreateTables(ModelBuilder modelBuilder)
        {

        }

    }
}
