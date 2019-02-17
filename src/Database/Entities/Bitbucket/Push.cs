using Microsoft.EntityFrameworkCore;

namespace Database.Entities.Bitbucket
{
    /// <summary>
    /// Entity that contains the GitHub Commit messages.
    /// </summary>
    public class Push : BuildDbEntity
    {
        public string PushMessage { get; set; }


        /// <summary>
        /// Static function which creates the table for this entity.
        /// </summary>
        /// <param name="mb">ModelBuilder used to create the entity.</param>
        public static void CreateTable(ModelBuilder mb)
        {
            mb.Entity<Github.Commit>(e =>
            {
                e.ToTable("bitbucket.push");

                e.Property(p => p.CommitMessage)
                    .HasColumnName("pushmessage")
                    .HasColumnType("jsonb")
                    .IsRequired();
            });
        }
    }
}
