using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_WebApplication.Models;

namespace MVC_WebApplication.Data
{
    public class MVC_WebApplicationContext : DbContext
    {
        public MVC_WebApplicationContext (DbContextOptions<MVC_WebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_WebApplication.Models.Player> players { get; set; } = default!;

        public DbSet<MVC_WebApplication.Models.Country> Country { get; set; }

        public DbSet<MVC_WebApplication.Models.Group> Group { get; set; }
    }
}
