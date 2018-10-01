using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExistingDb.Models.Manual
{
    public class ManualContext : DbContext
    {
        public ManualContext(DbContextOptions<ManualContext> options) : base(options) { }
        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<Style> ShoeStyles { get; set; }
    }
}
