using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCÖvning.Models;

namespace MVCÖvning.Data
{
    public class MVCÖvningContext : DbContext
    {
        public MVCÖvningContext (DbContextOptions<MVCÖvningContext> options)
            : base(options)
        {
        }

        public DbSet<MVCÖvning.Models.Product>? Product { get; set; }
    }
}
