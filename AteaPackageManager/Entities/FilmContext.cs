using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AteaPackageManager.Entities
{
    public class FilmContext:DbContext
    {
        public FilmContext() : base("name=FilmContextConnectionString")
        {

        }

        public DbSet<Film> Films { get; set; }
    }
}