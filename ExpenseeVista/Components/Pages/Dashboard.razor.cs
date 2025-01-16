namespace ExpenseeVista.Components.Pages
{
    public partial class Dashboard
    {
        private void NavigateToIncome()
        {
            Nav.NavigateTo("/transaction?type=income");
        }
        private void NavigateToDebt()
        {
            Nav.NavigateTo("/transaction?type=debt");
        }
        private void NavigateToExpense()
        {
            Nav.NavigateTo("/transaction?type=expense");
        }

    }
}