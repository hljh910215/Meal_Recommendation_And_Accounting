using Meal_Recommendation_And_Accounting.Helpers;
using Meal_Recommendation_And_Accounting.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Meal_Recommendation_And_Accounting.Repositories
{
    public class UserRepository
    {
        public void Create(User user)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                string sql = @"
INSERT INTO Users
(Account, Password, Name, Email, Phone, UserType)
VALUES
(@Account, @Password, @Name, @Email, @Phone, @UserType)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Account", user.Account);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    cmd.Parameters.AddWithValue("@UserType", user.UserType);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public User? GetByAccount(string account)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                string sql = @"
SELECT Id, Account, Password, Name, Email, Phone, UserType
FROM Users
WHERE Account = @Account";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Account", account);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return ReadUser(reader);
                        }
                    }
                }
            }

            return null;
        }

        public User? GetByAccountAndPassword(string account, string password)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                string sql = @"
SELECT Id, Account, Password, Name, Email, Phone, UserType
FROM Users
WHERE Account = @Account
AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Account", account);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return ReadUser(reader);
                        }
                    }
                }
            }

            return null;
        }

        public User? GetByAccountAndEmail(string account, string email)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                string sql = @"
SELECT Id, Account, Password, Name, Email, Phone, UserType
FROM Users
WHERE Account = @Account
AND Email = @Email";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Account", account);
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return ReadUser(reader);
                        }
                    }
                }
            }

            return null;
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                string sql = @"
SELECT Id, Account, Password, Name, Email, Phone, UserType
FROM Users";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(ReadUser(reader));
                        }
                    }
                }
            }

            return users;
        }

        public bool Update(User user)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                string sql = @"
UPDATE Users
SET
    Account = @Account,
    Password = @Password,
    Name = @Name,
    Email = @Email,
    Phone = @Phone,
    UserType = @UserType
WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.Parameters.AddWithValue("@Account", user.Account);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    cmd.Parameters.AddWithValue("@UserType", user.UserType);

                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0;
                }
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();

                string sql = @"
DELETE FROM Users
WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rows = cmd.ExecuteNonQuery();

                    return rows > 0;
                }
            }
        }

        private User ReadUser(SqlDataReader reader)
        {
            User user = new User
            {
                Id = (int)reader["Id"],
                Account = reader["Account"].ToString(),
                Password = reader["Password"].ToString(),
                Name = reader["Name"].ToString(),
                Email = reader["Email"].ToString(),
                Phone = reader["Phone"].ToString(),
                UserType = reader["UserType"].ToString()
            };

            return user;
        }
    }
}