namespace ExpenseeVista.Components.Pages
{
    public partial class History
    {
        private string searchQuery = "";
        private string selectedType = "";
        private string selectedTags = "";
        private string sortByDate = "";
        private string sortByAmount = "";

        private List<Transaction> transactions = new()
    {
        new Transaction
        {
            Date = new DateTime(2024, 12, 17),
            Title = "Grocery Shopping",
            Amount = 50.00m,
            Type = "Debit",
            Tags = "Food, drinks",
            Notes = "Monthly Expense"
        },
        new Transaction
        {
            Date = new DateTime(2024, 12, 14),
            Title = "Salary",
            Amount = 2000.00m,
            Type = "Credit",
            Tags = "Income",
            Notes = "-"
        },
        new Transaction
        {
            Date = new DateTime(2024, 12, 12),
            Title = "Loan Payment",
            Amount = 5000.00m,
            Type = "Debt",
            Tags = "Loan",
            Notes = "Paid to Bank"
        }
    };

        private void HandleSearch()
        {
            // Implement search logic here
        }

        public class Transaction
        {
            public DateTime Date { get; set; }
            public string Title { get; set; } = string.Empty;
            public decimal Amount { get; set; }
            public string Type { get; set; } = string.Empty;
            public string Tags { get; set; } = string.Empty;
            public string Notes { get; set; } = string.Empty;
        }
    }
}