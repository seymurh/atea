using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AteaPackageManager.Entities
{
    public class Film
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Category { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        public string Description { get; set; }

        public DateTime? Length { get; set; }

        public int? ProducerId { get; set; }

        public virtual Producer Producer { get; set; }

        public virtual IEnumerable<Screenshot> Screenshots { get; set; }
    }
}