using Meal_Recommendation_And_Accounting.Models;
using Meal_Recommendation_And_Accounting.Repositories;

namespace Meal_Recommendation_And_Accounting.Services
{
    namespace Meal_Recommendation_And_Accounting.Services
    {
        public class MealService
        {   //從符合條件的餐點清單中，隨機抽一筆回傳。
            private MealRepository mealRepository = new MealRepository();

            public Meal? GenerateMeal(string area, string mealTime, string restaurantType, string mealType, string priceRange)
            {
                int minPrice = 0;
                int maxPrice = 99999;

                if (priceRange == "100元以下")
                {
                    maxPrice = 100;
                }
                else if (priceRange == "101~150元")
                {
                    minPrice = 101;
                    maxPrice = 150;
                }
                else if (priceRange == "151~200元")
                {
                    minPrice = 151;
                    maxPrice = 200;
                }
                else if (priceRange == "201元以上")
                {
                    minPrice = 201;
                    maxPrice = 99999;
                }

                List<Meal> meals = mealRepository.Search(
                    area,
                    mealTime,
                    restaurantType,
                    mealType,
                    minPrice,
                    maxPrice);

                if (meals.Count == 0)
                {
                    return null;
                }

                Random random = new Random();
                int index = random.Next(meals.Count);

                return meals[index];
            }
        }
    }
}