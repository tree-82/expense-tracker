namespace ExpensesTracker.Data.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Description { get; set; } = String.Empty;
        public DateTime DateAdded { get; set; }
    }
}