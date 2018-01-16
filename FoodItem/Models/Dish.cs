﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodItem.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DishLabel { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string imageUrl { get; set; }

    }
}
