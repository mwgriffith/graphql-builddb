using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    /// <summary>
    /// Abstract class for the BuildDbEntities to add in base fields.
    /// </summary>
    public abstract class BuildDbEntity
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
