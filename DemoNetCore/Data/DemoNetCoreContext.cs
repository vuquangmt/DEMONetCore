using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoNetCore.Models;

namespace DemoNetCore.Data
{
    public class DemoNetCoreContext : DbContext
    {
        public DemoNetCoreContext (DbContextOptions<DemoNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<DemoNetCore.Models.Movie> Movie { get; set; }
    }
}
