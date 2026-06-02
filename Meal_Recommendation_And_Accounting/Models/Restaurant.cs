using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal_Recommendation_And_Accounting.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string RestaurantType { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
    }
}
