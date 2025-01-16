
using ExpenseeVista.Model;
using ExpenseeVista.Service;
using Microsoft.AspNetCore.Components;
namespace ExpenseeVista.Components.Pages
{
    public partial class TransactionEntry
    {
        private string errorMessage = null;
        private ExpenseeVista.Model.Transaction newTrans = new ExpenseeVista.Model.Transaction();
        private ExpenseeVista.Model.Transaction incomeModel = new ExpenseeVista.Model.Transaction();
        private ExpenseeVista.Model.Transaction expenseModel = new ExpenseeVista.Model.Transaction();
        private TransactionService transactionService = new TransactionService();


        private string? notificationMessage = null;
        private bool showNotification = false;

        private void ShowNotification(string message)
        {
            notificationMessage = message;
            showNotification = true;
            Task.Run(async () =>
            {
                await Task.Delay(3000);
                showNotification = false;
                StateHasChanged();
            });
        }
        private void AddTransaction()
        {
            var transaction = new ExpenseeVista.Model.Transaction
            {
                Amount = newTrans.Amount,
                Type = newTrans.Type,
                CustomTags = newTrans.CustomTags,
                Notes = newTrans.Notes,
                Date = DateTime.Now
            };
            transactionService.AddTransaction(transaction);

            newTrans = new ExpenseeVista.Model.Transaction();
        }

        private void NavigateBack()
        {
            Navigation.NavigateTo("/dash");
        }

        private async Task HandleIncomeSubmit()
        {
            var transaction = new ExpenseeVista.Model.Transaction
            {
                Amount = incomeModel.Amount,
                Type = incomeModel.Type,
                CustomTags = incomeModel.CustomTags,
                Notes = incomeModel.Notes,
                Date = DateTime.Now
            };
            transactionService.AddTransaction(transaction);

            ShowNotification("Income saved successfully!");
            incomeModel = new ExpenseeVista.Model.Transaction();
            Navigation.NavigateTo("/history");
        }

        private async Task HandleExpenseSubmit()
        {
            var transaction = new ExpenseeVista.Model.Transaction
            {
                Amount = expenseModel.Amount,
                Type = expenseModel.Type,
                CustomTags = expenseModel.CustomTags,
                Notes = expenseModel.Notes,
                Date = DateTime.Now
            };
            transactionService.AddTransaction(transaction);

            ShowNotification("Expense saved successfully!");
            expenseModel = new ExpenseeVista.Model.Transaction();
            Navigation.NavigateTo("/history");
        }
    }
}