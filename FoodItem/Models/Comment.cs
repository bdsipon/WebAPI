using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodItem.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string DishComment { get; set; }
        public DateTime date { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Dish Dish { get; set; }
    }
}
