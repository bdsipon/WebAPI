using FoodItem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodItem.Persistence
{
    public class FoodDbContext:DbContext
    {

        public FoodDbContext(DbContextOptions<FoodDbContext> options):base(options)
        {

        }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Comment> Comments { get; set; }

    }
}
