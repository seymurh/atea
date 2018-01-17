﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AteaPackageManager.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}