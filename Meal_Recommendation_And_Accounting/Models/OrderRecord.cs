using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal_Recommendation_And_Accounting.Models
{
    public class OrderRecord
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int MealId { get; set; }

        public string MealName { get; set; }

        public string RestaurantName { get; set; }

        public int Amount { get; set; }

        public DateTime OrderDate { get; set; }

        public string Note { get; set; }
        public bool IsDeleted { get; set; }
    }
}