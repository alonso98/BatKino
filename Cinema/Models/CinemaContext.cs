using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Cinema.Models
{
    public class CinemaContext:DbContext
    {
        public DbSet<Film> Films { get; set; }
    }
}