namespace ExpenseeVista.Model
{
    public class Transaction
    {

        public decimal Amount { get; set; }
        public string Type { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Today;
        public string Notes { get; set; } = string.Empty;
        public string CustomTags { get; set; } = string.Empty;
    }
}