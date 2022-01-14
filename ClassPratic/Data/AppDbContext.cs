using ClassPratic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassPratic.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employe> Employes  { get; set; }
        public DbSet<Position> Positions { get; set; }

        public DbSet<CostumUser> CostumUsers { get; set; }
    }
}
