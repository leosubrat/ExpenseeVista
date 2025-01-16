using ExpenseeVista.Abstractions;
using ExpenseeVista.Model;
using ExpenseeVista.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseeVista.Service
{
    public class UserService : UserBase, iUserService
    {
        private List<User> _users;

        public const string SeedUsername = "admin";
        public const string SeedPassword = "password";

        public UserService()
        {
            _users = LoadUsers();

            if (!_users.Any())
            {
                _users.Add(new User { Username = SeedUsername, Password = SeedPassword });
                SaveUsers(_users);
            }
        }

        public bool Login(User users)
        {
            if (string.IsNullOrEmpty(users.Username) || string.IsNullOrEmpty(users.Password))
            {
                return false;
            }
            return _users.Any(u => u.Username == users.Username && u.Password == users.Password);


        }
    }
}
