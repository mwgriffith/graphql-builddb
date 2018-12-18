using System;
using System.Threading;
using System.Threading.Tasks;

using Database.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Database
{
    public class BuildDBContext : DbContext
    {
        // the connection string to the db.
        private readonly string _connectionString;


        // Constructor with configuration injected.
        public BuildDBContext(DbContextOptions<BuildDBContext> options, IConfiguration configuration) : base(options)
        {
            _connectionString = configuration.GetConnectionString("BuildDbContext");
        }


        #region Protected method overloads.

        /// <summary>
        /// Sets the configuration options for the context.
        /// </summary>
        /// <param name="optionsBuilder">The options we'll be configuring.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString, p =>
            {
                p.MigrationsHistoryTable("ef_core_migrations_history", "builddb");
            });
        }


        /// <summary>
        /// Handles the creating of the model for the context.
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder we'll be using to create the tables.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("builddb");
            CreateTables(modelBuilder);
            AddBoilerPlate(modelBuilder);
        }

        /// <summary>
        /// Overriding Savechanges to add in some housekeeping.
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            DoHouseKeeping();
            return base.SaveChanges();
        }


        /// <summary>
        /// Overriding SaveChangesAsync to add in some housekeeping.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            DoHouseKeeping();
            return await base.SaveChangesAsync(cancellationToken);
        }

        #endregion


        #region Private methods

        /// <summary>
        /// This is the function where all of the tables are created, add new tables/entities here.
        /// </summary>
        /// <param name="modelBuilder">The modelbuilder we're using to create the tables.</param>
        private void CreateTables(ModelBuilder modelBuilder)
        {
            Entities.Github.Commit.CreateTable(modelBuilder);
        }
      

        /// <summary>
        /// Function which adds in boilerplate/inherited code for entities.  
        /// If you have an inherited entity add it in here.
        /// </summary>
        /// <param name="modelBuilder">The modelbuilder we'll use to add the boilderplate code.</param>
        private void AddBoilerPlate(ModelBuilder modelBuilder)
        {
            AddBoilerPlate<Entities.Github.Commit>(modelBuilder);
        }


        /// <summary>
        /// Function which will add inherited code for an entity of the BuildDbEntity type.
        /// </summary>
        /// <typeparam name="T">Class that inherits from BuildDbEntity</typeparam>
        /// <param name="modelBuilder">The modelbuilder we'll use to add the boilderplate code.</param>
        /// <param name="hasId">Does the entity have an id or not.  defaults to true.</param>
        private void AddBoilerPlate<T>(ModelBuilder modelBuilder, bool hasId = true) where T : BuildDbEntity
        {
            modelBuilder.Entity<T>(e => {
                if (hasId)
                {
                    e.Property(p => p.Id).HasColumnName("id").IsRequired();
                    e.HasKey(p => p.Id).HasName($"pk_{e.Metadata.Relational().TableName}");
                }
                e.HasQueryFilter(p => p.DeletedAt == null);

                e.Property(p => p.CreatedAt).HasColumnName("created_at").IsRequired();
                e.Property(p => p.ModifiedAt).HasColumnName("modified_at").IsRequired();
                e.Property(p => p.DeletedAt).HasColumnName("deleted_at").IsRequired(false);
            });
        }


        /// <summary>
        /// Does some entity housekeeping to add in inherited fields.
        /// </summary>
        private void DoHouseKeeping()
        {
            var entities = ChangeTracker.Entries();
            foreach (var entry in entities)
            {
                if (!(entry.Entity is BuildDbEntity))
                {
                    continue;
                }

                var e = entry.Entity as BuildDbEntity;
                switch (entry.State)
                {
                    case EntityState.Added:
                        e.CreatedAt = DateTime.UtcNow;
                        break;
                    case EntityState.Deleted:
                        e.DeletedAt = DateTime.UtcNow;
                        entry.State = EntityState.Modified;
                        break;
                }

                e.ModifiedAt = DateTime.UtcNow;
            }
        }
        #endregion

    }
}
