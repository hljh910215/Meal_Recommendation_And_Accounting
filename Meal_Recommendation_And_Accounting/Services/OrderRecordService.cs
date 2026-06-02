using Meal_Recommendation_And_Accounting.Models;
using Meal_Recommendation_And_Accounting.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal_Recommendation_And_Accounting.Services
{
    public class OrderRecordService
    {
        private OrderRecordRepository orderRecordRepository = new OrderRecordRepository();

        public void AddOrderRecord(OrderRecord record)
        {
            orderRecordRepository.Create(record);
        }

        public List<OrderRecord> GetByUserId(int userId)
        {
            return orderRecordRepository.GetByUserId(userId);
        }

        public List<OrderRecord> GetByUserIdAndDate(int userId, DateTime orderDate)
        {
            return orderRecordRepository.GetByUserIdAndDate(userId, orderDate);
        }

        public int GetTotalAmountByUserId(int userId)
        {
            List<OrderRecord> records = orderRecordRepository.GetByUserId(userId);

            int total = records.Sum(r => r.Amount);

            return total;
        }

        public int GetTotalAmount(List<OrderRecord> records)
        {
            int total = records.Sum(r => r.Amount);

            return total;
        }

        public bool DeleteOrderRecord(int id)
        {
            return orderRecordRepository.Delete(id);
        }

        // 以下是統計分析相關的方法
        public int GetOrderCount(int userId)
        {
            List<OrderRecord> records = orderRecordRepository.GetByUserId(userId);

            return records.Count;
        }

        public double GetAverageAmount(int userId)
        {
            List<OrderRecord> records = orderRecordRepository.GetByUserId(userId);

            if (records.Count == 0)
            {
                return 0;
            }

            double average = records.Average(r => r.Amount);

            return average;
        }

        public string GetFavoriteMealName(int userId)
        {
            List<OrderRecord> records = orderRecordRepository.GetByUserId(userId);

            if (records.Count == 0)
            {
                return "尚無資料";
            }

            string favoriteMeal = records
                .GroupBy(r => r.MealName)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;

            return favoriteMeal;
        }

        public string GetFavoriteRestaurantName(int userId)
        {
            List<OrderRecord> records = orderRecordRepository.GetByUserId(userId);

            if (records.Count == 0)
            {
                return "尚無資料";
            }

            string favoriteRestaurant = records
                .GroupBy(r => r.RestaurantName)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;

            return favoriteRestaurant;
        }
    }
}

