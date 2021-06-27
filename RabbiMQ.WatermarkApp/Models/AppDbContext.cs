using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RabbiMQ.WatermarkApp.Models;

namespace RabbiMQ.WatermarkApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products;

        public DbSet<RabbiMQ.WatermarkApp.Models.Product> Product { get; set; }
    }
}
