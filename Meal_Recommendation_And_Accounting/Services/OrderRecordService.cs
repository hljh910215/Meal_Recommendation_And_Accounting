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
    }
}

