using Meal_Recommendation_And_Accounting.Models;
using Meal_Recommendation_And_Accounting.Repositories;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Meal_Recommendation_And_Accounting.Services
{
    public class UserService
    {
        private UserRepository userRepository = new UserRepository();

        public User? Login(string account, string password)
        {
            if (account == "" || password == "")
            {
                return null;
            }

            User? user = userRepository.GetByAccountAndPassword(account, password);

            return user;
        }

        public bool Register(string account, string password, string name,string phone, string email)
        {
            if (account == "" || password == "" || name == "" || phone == "" || email == "")
            {
                return false;
            }

            User? oldUser = userRepository.GetByAccount(account);

            if (oldUser != null)
            {
                return false;
            }

            User newUser = new User
            {
                Account = account,
                Password = password,
                Name = name,
                Phone = phone,
                Email = email,
                UserType = "Member"
            };

            userRepository.Create(newUser);

            return true;
        }

        public User? FindByAccountAndEmail(string account, string email)
        {
            if (account == "" || email == "")
            {
                return null;
            }

            User? user = userRepository.GetByAccountAndEmail(account, email);

            return user;
        }

        public List<User> GetAllUsers()
        {
            return userRepository.GetAll();
        }

        public bool UpdateUser(User user)
        {
            return userRepository.Update(user);
        }

        public bool DeleteUser(int id)
        {
            return userRepository.Delete(id);
        }
    }
}
