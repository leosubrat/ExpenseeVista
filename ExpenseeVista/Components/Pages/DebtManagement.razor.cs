namespace ExpenseeVista.Components.Pages
{
    public partial class DebtManagement
    {
        private DebtModel debtModel = new();

        private void HandleSubmit()
        {
            // Add your debt saving logic here
            debtModel = new();
        }

        private void Cancel()
        {
            debtModel = new();
        }

        public class DebtModel
        {
            public string Source { get; set; } = string.Empty;
            public decimal Amount { get; set; }
            public DateTime DueDate { get; set; } = DateTime.Today;
            public string Notes { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
            public string CustomTags { get; set; } = string.Empty;
        }
    }
}