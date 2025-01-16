
using ExpenseeVista.Abstractions;
using ExpenseeVista.Model;
using ExpenseeVista.Service.Interface;
namespace ExpenseVista.Service
{
    public class UserService : UserBase, iUserService
    {
        private List<User> _users;

        public const string SeedUsername = "Subrat";
        public const string SeedPassword = "Thapa";
        public const string SeedCurrency = "USD - US Dollar";
        private User _currentUser;

        public UserService()
        {
            _users = LoadUsers();

            if (!_users.Any())
            {
                _users.Add(new User { Username = SeedUsername, Password = SeedPassword, PreferredCurrency = SeedCurrency });
                SaveUsers(_users);
            }
        }

        public bool Login(User user)
        {
            if (string.IsNullOrEmpty(user.Username) ||
                string.IsNullOrEmpty(user.Password) ||
                string.IsNullOrEmpty(user.PreferredCurrency))
            {
                return false;
            }

            if (!user.PreferredCurrency.Equals("USD", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            var validUser = _users.FirstOrDefault(u => u.Username == user.Username &&
                                                       u.Password == user.Password &&
                                                       u.PreferredCurrency.Equals("USD - US Dollar", StringComparison.OrdinalIgnoreCase));
            if (validUser != null)
            {
                _currentUser = validUser; 
                return true;
            }

            return false;
        }
    }
}