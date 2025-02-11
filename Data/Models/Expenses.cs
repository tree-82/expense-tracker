using System.ComponentModel.DataAnnotations;

namespace ExpensesTracker.Data.Models
{
    public class Expenses
    {
        public int Id  { get; set; }
        [Required, StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = String.Empty;
        [Required]
        public decimal Amount { get; set; }  = 1.99m;
        [Required]
        public DateTime DateAdded { get; set; }
    }
}