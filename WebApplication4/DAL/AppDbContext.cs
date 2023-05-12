﻿using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Slide> Slides { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
