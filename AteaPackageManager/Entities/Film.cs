using System;
using System.Collections.Generic;

namespace AteaPackageManager.Entities
{
    public class Film
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Description { get; set; }

        public DateTime Length { get; set; }

        public IEnumerable<Producer> Producers { get; set; }

        public IEnumerable<Screenshot> Screenshots { get; set; }
    }
}