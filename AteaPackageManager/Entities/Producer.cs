using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AteaPackageManager.Entities
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surename { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}