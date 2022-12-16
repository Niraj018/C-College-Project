using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onine_Shopping.Models;
using OnlineShopping.Models;

namespace onine_Shopping.Data
{
    public class onine_ShoppingContext : DbContext
    {
        public onine_ShoppingContext (DbContextOptions<onine_ShoppingContext> options)
            : base(options)
        {
        }

        public DbSet<onine_Shopping.Models.Category> Category { get; set; } = default!;

        public DbSet<onine_Shopping.Models.Product> Product { get; set; }

        public DbSet<OnlineShopping.Models.User> User { get; set; }
    }
}
