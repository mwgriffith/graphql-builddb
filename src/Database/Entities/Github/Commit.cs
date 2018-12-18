using Microsoft.EntityFrameworkCore;


namespace Database.Entities.Github
{
    /// <summary>
    /// Entity that contains the GitHub Commit messages.
    /// </summary>
    public class Commit: BuildDbEntity
    {
        public string CommitMessage { get; set; }


        /// <summary>
        /// Static function which creates the table for this entity.
        /// </summary>
        /// <param name="mb">ModelBuilder used to create the entity.</param>
        public static void CreateTable(ModelBuilder mb)
        {
            mb.Entity<Github.Commit>(e =>
            {
                e.ToTable("github.commit");

                e.Property(p => p.CommitMessage)
                    .HasColumnName("commitmessage")
                    .HasColumnType("jsonb")
                    .IsRequired();
            });
        }
    }
}
