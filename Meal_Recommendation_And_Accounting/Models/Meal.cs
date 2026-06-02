using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal_Recommendation_And_Accounting.Models
{
    public class Meal
    {
        public int Id { get; set; }

        public int RestaurantId { get; set; }

        public string Area { get; set; }

        public string MealTime { get; set; }

        public string RestaurantType { get; set; }

        public string MealType { get; set; }

        public string RestaurantName { get; set; }

        public string MealName { get; set; }

        public int Price { get; set; }

        public string Note { get; set; }
    }
}