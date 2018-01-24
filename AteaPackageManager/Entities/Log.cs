using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AteaPackageManager.Entities
{
    public class Log
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime LogDate { get; set; } = DateTime.UtcNow;
    }
}