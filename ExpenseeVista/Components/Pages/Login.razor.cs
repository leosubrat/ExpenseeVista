using ExpenseeVista.Model;

namespace ExpenseeVista.Components.Pages
{
    public partial class Login
    {
        private string? ErrorMessage;

        public User Users { get; set; } = new();

        private async void HandleLogin()
        {
            if (UserService.Login(Users))
            {
                Nav.NavigateTo("/home");
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
            }
        }

        private async void HandleRegister()
        {
            Nav.NavigateTo("/register");
        }
    }
}