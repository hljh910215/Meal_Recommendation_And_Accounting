using Meal_Recommendation_And_Accounting.Helpers;
using Meal_Recommendation_And_Accounting.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Meal_Recommendation_And_Accounting.Repositories
{
    public class OrderRecordRepository
    {
        private static List<OrderRecord> orderRecords = new List<OrderRecord>();

        // Create：新增訂單紀錄
        public void Create(OrderRecord record)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                string sql = @"
INSERT INTO OrderRecords
(UserId, MealId, MealName, RestaurantName, Amount, OrderDate, Note, IsDeleted)
VALUES
(@UserId, @MealId, @MealName, @RestaurantName, @Amount, @OrderDate, @Note, 0)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", record.UserId);

                    if (record.MealId == 0)
                    {
                        cmd.Parameters.AddWithValue("@MealId", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@MealId", record.MealId);
                    }

                    cmd.Parameters.AddWithValue("@MealName", record.MealName);
                    cmd.Parameters.AddWithValue("@RestaurantName", record.RestaurantName);
                    cmd.Parameters.AddWithValue("@Amount", record.Amount);
                    cmd.Parameters.AddWithValue("@OrderDate", record.OrderDate);
                    cmd.Parameters.AddWithValue("@Note", record.Note ?? "");

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Read：取得某個會員的全部訂單紀錄
        public List<OrderRecord> GetByUserId(int userId)
        {
            List<OrderRecord> records = new List<OrderRecord>();

            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                string sql = @"
SELECT Id, UserId, MealId, MealName, RestaurantName, Amount, OrderDate, Note, IsDeleted
FROM OrderRecords
WHERE UserId = @UserId
AND IsDeleted = 0
ORDER BY OrderDate DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderRecord record = ReadOrderRecord(reader);
                            records.Add(record);
                        }
                    }
                }
            }

            return records;
        }


        // Read：取得某個會員某一天的訂單紀錄
        public List<OrderRecord> GetByUserIdAndDate(int userId, DateTime orderDate)
        {
            List<OrderRecord> records = new List<OrderRecord>();

            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                string sql = @"
SELECT Id, UserId, MealId, MealName, RestaurantName, Amount, OrderDate, Note, IsDeleted
FROM OrderRecords
WHERE UserId = @UserId
AND IsDeleted = 0
AND CONVERT(date, OrderDate) = @OrderDate
ORDER BY OrderDate DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@OrderDate", orderDate.Date);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderRecord record = ReadOrderRecord(reader);
                            records.Add(record);
                        }
                    }
                }
            }

            return records;
        }

        // Delete：刪除訂單紀錄
        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                string sql = @"
UPDATE OrderRecords
SET IsDeleted = 1
WHERE Id = @Id
AND IsDeleted = 0";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0;
                }
            }
        }
        private OrderRecord ReadOrderRecord(SqlDataReader reader)
        {
            OrderRecord record = new OrderRecord
            {
                Id = (int)reader["Id"],
                UserId = (int)reader["UserId"],
                MealName = reader["MealName"].ToString(),
                RestaurantName = reader["RestaurantName"].ToString(),
                Amount = (int)reader["Amount"],
                OrderDate = (DateTime)reader["OrderDate"],
                Note = reader["Note"].ToString(),
                IsDeleted = (bool)reader["IsDeleted"]
            };

            if (reader["MealId"] != DBNull.Value)
            {
                record.MealId = (int)reader["MealId"];
            }

            return record;
        }
    }
}

