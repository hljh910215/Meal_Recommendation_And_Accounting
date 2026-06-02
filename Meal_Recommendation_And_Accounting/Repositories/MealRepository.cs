using Meal_Recommendation_And_Accounting.Helpers;
using Meal_Recommendation_And_Accounting.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Meal_Recommendation_And_Accounting.Repositories
{
    public class MealRepository
    {
        public List<Meal> Search(
            string area,
            string mealTime,
            string restaurantType,
            string mealType,
            int minPrice,
            int maxPrice)
        {
            List<Meal> meals = new List<Meal>();

            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                string sql = @"
SELECT
    m.Id,
    m.RestaurantId,
    r.Name AS RestaurantName,
    r.Area,
    r.RestaurantType,
    m.Name AS MealName,
    m.MealType,
    m.Price,
    m.MealTime,
    m.Note
FROM Meals m
JOIN Restaurants r ON m.RestaurantId = r.Id
WHERE
    (@Area = N'不限' OR r.Area = @Area)
AND (@MealTime = N'不限' OR m.MealTime = @MealTime)
AND (@RestaurantType = N'不限' OR r.RestaurantType = @RestaurantType)
AND (@MealType = N'不限' OR m.MealType = @MealType)
AND m.Price >= @MinPrice
AND m.Price <= @MaxPrice";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Area", area);
                    cmd.Parameters.AddWithValue("@MealTime", mealTime);
                    cmd.Parameters.AddWithValue("@RestaurantType", restaurantType);
                    cmd.Parameters.AddWithValue("@MealType", mealType);
                    cmd.Parameters.AddWithValue("@MinPrice", minPrice);
                    cmd.Parameters.AddWithValue("@MaxPrice", maxPrice);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Meal meal = new Meal
                            {
                                Id = (int)reader["Id"],
                                RestaurantId = (int)reader["RestaurantId"],
                                RestaurantName = reader["RestaurantName"].ToString(),
                                Area = reader["Area"].ToString(),
                                RestaurantType = reader["RestaurantType"].ToString(),
                                MealName = reader["MealName"].ToString(),
                                MealType = reader["MealType"].ToString(),
                                Price = (int)reader["Price"],
                                MealTime = reader["MealTime"].ToString(),
                                Note = reader["Note"].ToString()
                            };

                            meals.Add(meal);
                        }
                    }
                }
            }

            return meals;
        }
    }
}