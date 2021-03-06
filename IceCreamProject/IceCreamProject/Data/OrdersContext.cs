using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IceCreamProject.Models;

    public class OrdersContext : DbContext
    {
        public OrdersContext (DbContextOptions<OrdersContext> options)
            : base(options)
        {
        }

        public DbSet<IceCreamProject.Models.Orders> Orders { get; set; }
    }
