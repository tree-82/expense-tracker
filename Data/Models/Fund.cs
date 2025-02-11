using System.ComponentModel.DataAnnotations;

namespace ExpensesTracker.Data.Models
{
    public class Fund
    {
        public int Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
    }
}