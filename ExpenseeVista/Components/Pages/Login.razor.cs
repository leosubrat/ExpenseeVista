using ExpenseeVista.Model;

namespace ExpenseeVista.Components.Pages
{
    public partial class Login
    {
        private User User { get; set; } = new User();
        private string? ErrorMessage;
        private bool IsLoading = false;
        private bool WasValidated = false;

        private async Task HandleLogin()
        {
            WasValidated = true;

            if (string.IsNullOrWhiteSpace(User.Username) ||
                string.IsNullOrWhiteSpace(User.Password) ||
                string.IsNullOrWhiteSpace(User.PreferredCurrency))
            {
                ErrorMessage = "Please fill in all fields";
                return;
            }

            try
            {
                IsLoading = true;
                ErrorMessage = null;

                if (await Task.Run(() => UserService.Login(User)))
                {

                    Nav.NavigateTo("/dash");
                }

                else
                {
                    ErrorMessage = "Please enter valid username, password and prefered currency type";
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = "An error occurred. Please try again.";
                Console.WriteLine($"Login error: {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }
        }

        private bool IsFieldInvalid(string value)
        {
            return WasValidated && string.IsNullOrWhiteSpace(value);
        }
    }
}