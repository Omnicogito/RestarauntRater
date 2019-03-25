using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestarauntRater1.Models
{
    public class Restaraunt
    {
        public int RestarauntID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
    }

    public class RestarauntDBContext : DbContext
    {
        public DbSet<Restaraunt> Restaraunts { get; set; }
    }
}